using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace FozzySystems.Utils
{
    /// <summary>
    /// Класс с набором системных методов.
    /// </summary>
    public static class utils
    {
        private static readonly BindingFlags SEARCH_BINDING_FLAGS =
          BindingFlags.FlattenHierarchy |
          BindingFlags.Static |
          BindingFlags.Instance |
          BindingFlags.Public |
          BindingFlags.NonPublic;

        /// <summary>
        /// Информация о файле и методе из стека трассировки.
        /// </summary>
        public static string fileInfo()
        {
            StackTrace stack = new StackTrace(true);
            StackFrame sf = stack.GetFrame(1);
#if DEBUG
            string file = sf.GetFileName();
            if (!string.IsNullOrEmpty(file))
                file = file.Remove(0, file.LastIndexOf('\\') + 1);
            int line = sf.GetFileLineNumber();
            int col = sf.GetFileColumnNumber();
            return string.Format("{0}:{1}:{2}::{3}", file, line, col, sf.GetMethod().Name);
#else
      return sf.GetMethod().Name;
#endif
        }

        /// <summary>
        /// Информация о методе из стека трассировки.
        /// </summary>
        public static string methodInfo()
        {
            StackTrace stack = new StackTrace(true);
            return stack.GetFrame(1).GetMethod().Name;
        }

        /// <summary>
        /// Для WCF - возвращает IP адрес клиента или null если ошибка.
        /// </summary>
        /// <returns></returns>
        public static string GetClientIpAddress()
        {
            try
            {
                if (OperationContext.Current == null)
                    return null;
                MessageProperties prop = OperationContext.Current.IncomingMessageProperties;
                if (utils.GetFieldValue<bool>(typeof(MessageProperties), prop, "disposed"))
                    return null;
                //HttpRequestMessageProperty h = (HttpRequestMessageProperty)prop[HttpRequestMessageProperty.Name];
                //return h.Headers.ToString();
                if (prop.TryGetValue(HttpRequestMessageProperty.Name, out object propertyValue))
                {
                    HttpRequestMessageProperty httpRequestProperty = (HttpRequestMessageProperty)propertyValue;
                    string addr = httpRequestProperty.Headers.Get("X-Forwarded-For");
                    if (addr != null)
                        return addr;
                }
                RemoteEndpointMessageProperty endpoint =
                  prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
                return endpoint.Address;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string ShortTypeName(Type type)
        {
            return type.ToString().Substring(type.ToString().LastIndexOf('.') + 1);
        }

        public static string ShortTypeName(object o)
        {
            return ShortTypeName(o.GetType());
        }

        public static PropertyDescriptor SetAttribute(PropertyDescriptor prop, Attribute attr)
        {
            if (prop == null)
                return null;

            AttributeCollection runtimeAttributes = prop.Attributes;
            int index = -1;
            for (int i = 0; i < runtimeAttributes.Count; i++)
            {
                if (runtimeAttributes[i].GetType() != attr.GetType())
                    continue;

                index = i;
                break;
            }

            Attribute[] attrs = new Attribute[runtimeAttributes.Count + (index == -1 ? 1 : 0)];
            runtimeAttributes.CopyTo(attrs, 0);
            attrs[(index == -1) ? runtimeAttributes.Count : index] = attr;

            return TypeDescriptor.CreateProperty(prop.ComponentType, prop.Name, prop.PropertyType, attrs);
        }

        /// <summary>
        /// Создать экземпляр по имени класса.
        /// Ищет тип во всех загруженных сборках в текущем AppDomain.
        /// Если тип не найден, возвращает null.
        /// </summary>
        /// <param name="TypeName">название типа</param>
        public static object CreateInstance(string TypeName)
        {
            Assembly assembly = Array.Find<Assembly>(AppDomain.CurrentDomain.GetAssemblies(),
              x => x.GetType(TypeName) != null);
            return assembly == null ? null : assembly.CreateInstance(TypeName);
        }

        /// <summary>
        /// Получить экземпляр поля объекта через Reflection
        /// </summary>
        /// <typeparam name="T">Тип поля</typeparam>
        /// <param name="obj">Объект</param>
        /// <param name="fieldName">Название поля</param>
        /// <returns>Экземпляр значения поля</returns>
        public static T GetFieldValue<T>(object obj, string fieldName)
        {
            return GetFieldValue<T>(obj.GetType(), obj, fieldName);
        }

        /// <summary>
        /// Получить экземпляр поля объекта через Reflection
        /// </summary>
        /// <typeparam name="T">Тип поля</typeparam>
        /// <param name="type">Тип объекта</param>
        /// <param name="obj">Объект</param>
        /// <param name="fieldName">Название поля</param>
        /// <returns>Экземпляр значения поля</returns>
        public static T GetFieldValue<T>(Type type, object obj, string fieldName)
        {
            FieldInfo fieldInfo = type.GetField(fieldName, SEARCH_BINDING_FLAGS);
            return (T)fieldInfo.GetValue(obj);
        }

        /// <summary>
        /// Установить значение поля объекта через Reflection
        /// </summary>
        /// <param name="obj">Объект</param>
        /// <param name="fieldName">Название члена класса</param>
        /// <param name="value">Новое значение</param>
        public static void SetFieldValue(object obj, string fieldName, object value)
        {
            SetFieldValue(obj.GetType(), obj, fieldName, value);
        }

        /// <summary>
        /// Установить значение поля объекта через Reflection
        /// </summary>
        /// <param name="type">Тип объекта члена класса</param>
        /// <param name="obj">Объект (null для static)</param>
        /// <param name="fieldName">Название члена класса</param>
        /// <param name="value">Новое значение</param>
        public static void SetFieldValue(Type type, object obj, string fieldName, object value)
        {
            FieldInfo fieldInfo = type.GetField(fieldName, SEARCH_BINDING_FLAGS);
            fieldInfo.SetValue(obj, value);
        }

        public static void CopyFieldValue(object src, object dst, string fieldName)
        {
            BindingFlags flags = SEARCH_BINDING_FLAGS & ~BindingFlags.Static;
            FieldInfo si = src.GetType().GetField(fieldName, flags);
            FieldInfo di = dst.GetType().GetField(fieldName, flags);
            object sv = GetFieldValue<object>(src, fieldName);
            if (si.FieldType == di.FieldType)
            {
                // ok
            }
            else if (si.FieldType.IsSerializable && di.FieldType.IsSerializable)
            {
                sv = Serialization.XmlCast(di.FieldType, sv);
            }
            else
            {
                throw new NotSupportedException(
                  string.Format("Cannot convert field type: {0} -> {1}", si.GetType(), di.GetType()));
            }
            SetFieldValue(dst.GetType(), dst, fieldName, sv);
        }

        /// <summary>
        /// Получить экземпляр свойства (Property) объекта через Reflection
        /// Просматривается вся иерархия объекта, выбираются как public, так и private свойства
        /// </summary>
        /// <typeparam name="T">Тип свойства</typeparam>
        /// <param name="obj">Объект</param>
        /// <param name="name">Название свойства</param>
        /// <returns>Экземпляр значения свойства</returns>
        public static T GetPropertyValue<T>(object obj, string propertyName)
        {
            return GetPropertyValue<T>(obj.GetType(), obj, propertyName);
        }

        /// <summary>
        /// Получить экземпляр свойства (Property) объекта через Reflection
        /// Просматривается вся иерархия объекта, выбираются как public, так и private свойства
        /// </summary>
        /// <typeparam name="T">Тип свойства</typeparam>
        /// <param name="type">Тип объекта</param>
        /// <param name="obj">Объект</param>
        /// <param name="name">Название свойства</param>
        /// <returns>Экземпляр значения свойства</returns>
        public static T GetPropertyValue<T>(Type type, object obj, string propertyName)
        {
            PropertyInfo info = type.GetProperty(propertyName, SEARCH_BINDING_FLAGS);
            return (T)info.GetValue(obj, null);
        }

        /// <summary>
        /// Установить значение свойства объекта через Reflection
        /// </summary>
        /// <param name="type">Тип свойства</param>
        /// <param name="obj">Объект (null для static)</param>
        /// <param name="propertyName">Название свойства</param>
        /// <param name="value">Новое значение</param>
        public static void SetPropertyValue(Type type, object obj, string propertyName, object value)
        {
            PropertyInfo propertyInfo = type.GetProperty(propertyName, SEARCH_BINDING_FLAGS);
            propertyInfo.SetValue(obj, value, null);
        }

        public static void CopyPropertyValue(object src, object dst, string propertyName)
        {
            BindingFlags flags = BindingFlags.FlattenHierarchy | BindingFlags.Instance |
              BindingFlags.Public | BindingFlags.NonPublic;
            PropertyInfo si = src.GetType().GetProperty(propertyName, flags);
            PropertyInfo di = dst.GetType().GetProperty(propertyName, flags);
            object sv = GetPropertyValue<object>(src, propertyName);
            if (si.PropertyType == di.PropertyType)
            {
                // ok
            }
            else if (si.PropertyType.IsSerializable && di.PropertyType.IsSerializable)
            {
                sv = Serialization.XmlCast(di.PropertyType, sv);
            }
            else
            {
                throw new NotSupportedException(
                  string.Format("Cannot convert property type: {0} -> {1}", si.GetType(), di.GetType()));
            }
            SetPropertyValue(dst.GetType(), dst, propertyName, sv);
        }

        public static object InvokePublicMethod(Type type, object instance, string methodName,
          params object[] args)
        {
            return InvokeMethodInternal(type, instance, methodName, args,
              BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
        }

        public static object InvokePrivateMethod(object instance, string methodName,
          params object[] args)
        {
            return InvokePrivateMethod(instance.GetType(), instance, methodName, args);
        }

        public static object InvokePrivateMethod(Type type, object instance, string methodName,
          params object[] args)
        {
            return InvokeMethodInternal(type, instance, methodName, args,
              BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
        }

        #region InvokeMethodInternal
        private static object InvokeMethodInternal(Type type, object instance, string methodName, object[] args,
          BindingFlags flags)
        {
            List<Type> argTypes = new List<Type>();
            foreach (object o in args)
                argTypes.Add(o == null ? null : o.GetType());

            MethodInfo[] methods = type.GetMethods(flags);
            MethodInfo mi = Array.Find<MethodInfo>(methods, x =>
            {
                if (string.Compare(x.Name, methodName, false) != 0)
                    return false;
                ParameterInfo[] parameters = x.GetParameters();
                if (parameters.Length != argTypes.Count)
                    return false;
                foreach (ParameterInfo pi in parameters)
                {
                    if (argTypes[pi.Position] == null)
                        continue;
                    if (pi.ParameterType.IsAssignableFrom(argTypes[pi.Position]))
                        continue;
                    return false;
                }
                return true;
            });
            if (mi == null)
                return null;

            return mi.Invoke(instance, args);
        }
        #endregion

        /// <summary>
        /// Найти тип по имени.
        /// Ищет тип во всех загруженных сборках в текущем AppDomain.
        /// Если тип не найден, возвращает null.
        /// </summary>
        /// <param name="TypeName">название типа</param>
        public static Type GetType(string TypeName)
        {
            Assembly assembly = Array.Find<Assembly>(AppDomain.CurrentDomain.GetAssemblies(),
              x => x.GetType(TypeName) != null);
            return assembly == null ? null : assembly.GetType(TypeName);
        }

        /// <summary>
        /// Проверка принадлежности экземпляра объекта к числовому типу.
        /// Числовые типы: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal
        /// </summary>
        /// <param name="value">Экземпляр объекта</param>
        public static bool IsNumericType(object value)
        {
            return IsNumericType(value.GetType());
        }

        /// <summary>
        /// Проверка принадлежности экземпляра объекта к числовому типу.
        /// Числовые типы: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal
        /// </summary>
        /// <param name="type">Проверяемый тип</param>
        public static bool IsNumericType(Type type)
        {
            return IsIntegralType(type) || IsFractionalType(type);
        }

        /// <summary>
        /// Проверка принадлежности экземпляра объекта к интегральному числовому типу
        /// (sbyte, byte, short, ushort, int, uint, long, ulong)
        /// </summary>
        /// <param name="value">Экземпляр объекта</param>
        public static bool IsIntegralType(object value)
        {
            return IsIntegralType(value.GetType());
        }

        /// <summary>
        /// Проверка принадлежности типа к интегральному числовому типу
        /// (sbyte, byte, short, ushort, int, uint, long, ulong)
        /// </summary>
        /// <param name="type">Проверяемый тип</param>
        public static bool IsIntegralType(Type type)
        {
            return
              type == typeof(sbyte) ||
              type == typeof(byte) ||
              type == typeof(short) ||
              type == typeof(ushort) ||
              type == typeof(int) ||
              type == typeof(uint) ||
              type == typeof(long) ||
              type == typeof(ulong);
        }

        /// <summary>
        /// Проверка принадлежности экземпляра объекта к дробному числовому типу
        /// (float, double, decimal)
        /// </summary>
        /// <param name="value">Экземпляр объекта</param>
        public static bool IsFractionalType(object value)
        {
            return IsFractionalType(value.GetType());
        }

        /// <summary>
        /// Проверка принадлежности экземпляра объекта к дробному числовому типу
        /// (float, double, decimal)
        /// </summary>
        /// <param name="type">Проверяемый тип</param>
        public static bool IsFractionalType(Type type)
        {
            return
              type == typeof(float) ||
              type == typeof(double) ||
              type == typeof(decimal);
        }

        public static void CreateEventLogSource(string EventSourceName, string EventSourceLogName)
        {
            // Create the source, if it does not already exist.
            // Administrator rights required !!!
            bool sourceExists;
            try
            {
                sourceExists = EventLog.SourceExists(EventSourceName);
            }
            catch
            {
                sourceExists = false;
            }

            if (!sourceExists)
            {
                //An event log source should not be created and immediately used.
                //There is a latency time to enable the source, it should be created
                //prior to executing the application that uses the source.
                EventLog.CreateEventSource(EventSourceName, EventSourceLogName);
            }
        }

        #region processor architecture

        public enum ProcessorArchitecture
        {
            x86,
            AMD64,
            Other
        }

        public static ProcessorArchitecture GetProcessorArchitecture()
        {
            string pa = GetProcessorArchitectureName();
            switch (pa)
            {
                case "AMD64":
                    return ProcessorArchitecture.AMD64;

                case "x86":
                    return ProcessorArchitecture.x86;

                default:
                    return ProcessorArchitecture.Other;
            }
        }

        public static string GetProcessorArchitectureName()
        {
            return Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
        }

        public static MachineType GetDllMachineType(string dllPath)
        {
            //see http://www.microsoft.com/whdc/system/platform/firmware/PECOFF.mspx
            //offset to PE header is always at 0x3C
            //PE header starts with "PE\0\0" =  0x50 0x45 0x00 0x00
            //followed by 2-byte machine type field (see document above for enum)
            using (FileStream fs = new FileStream(dllPath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                fs.Seek(0x3c, SeekOrigin.Begin);
                int peOffset = br.ReadInt32();
                fs.Seek(peOffset, SeekOrigin.Begin);
                uint peHead = br.ReadUInt32();
                if (peHead != 0x00004550)
                    // "PE\0\0", little-endian
                    throw new Exception("Can't find PE header");
                MachineType machineType = (MachineType)br.ReadUInt16();
                br.Close();
                fs.Close();
                return machineType;
            }
        }

        public enum MachineType : ushort
        {
            IMAGE_FILE_MACHINE_UNKNOWN = 0x0,
            IMAGE_FILE_MACHINE_AM33 = 0x1d3,
            IMAGE_FILE_MACHINE_AMD64 = 0x8664,
            IMAGE_FILE_MACHINE_ARM = 0x1c0,
            IMAGE_FILE_MACHINE_EBC = 0xebc,
            IMAGE_FILE_MACHINE_I386 = 0x14c,
            IMAGE_FILE_MACHINE_IA64 = 0x200,
            IMAGE_FILE_MACHINE_M32R = 0x9041,
            IMAGE_FILE_MACHINE_MIPS16 = 0x266,
            IMAGE_FILE_MACHINE_MIPSFPU = 0x366,
            IMAGE_FILE_MACHINE_MIPSFPU16 = 0x466,
            IMAGE_FILE_MACHINE_POWERPC = 0x1f0,
            IMAGE_FILE_MACHINE_POWERPCFP = 0x1f1,
            IMAGE_FILE_MACHINE_R4000 = 0x166,
            IMAGE_FILE_MACHINE_SH3 = 0x1a2,
            IMAGE_FILE_MACHINE_SH3DSP = 0x1a3,
            IMAGE_FILE_MACHINE_SH4 = 0x1a6,
            IMAGE_FILE_MACHINE_SH5 = 0x1a8,
            IMAGE_FILE_MACHINE_THUMB = 0x1c2,
            IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x169,
        }

        // returns true if the dll is 64-bit, false if 32-bit, and null if unknown
        public static bool? UnmanagedDllIs64Bit(string dllPath)
        {
            switch (GetDllMachineType(dllPath))
            {
                case MachineType.IMAGE_FILE_MACHINE_AMD64:
                case MachineType.IMAGE_FILE_MACHINE_IA64:
                    return true;
                case MachineType.IMAGE_FILE_MACHINE_I386:
                    return false;
                default:
                    return null;
            }
        }
        #endregion

        public static Thread StartInThreadQuiet(Action func, bool isBackground = true)
        {
            Thread thread = new Thread(() => { try { func(); } catch { } })
            {
                IsBackground = isBackground
            };
            thread.Start();
            return thread;
        }

        [DllImportAttribute("user32.dll", EntryPoint = "GetForegroundWindow")]
        public static extern IntPtr GetForegroundWindow();

        [DllImportAttribute("user32.dll", EntryPoint = "IsIconic")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool IsIconic([InAttribute()] IntPtr hWnd);
    }
}
