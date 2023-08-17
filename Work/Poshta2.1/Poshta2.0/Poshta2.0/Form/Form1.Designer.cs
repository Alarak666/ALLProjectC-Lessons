
namespace Poshta2._0
{
    partial class Employer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployerGrid = new System.Windows.Forms.DataGridView();
            this.InfoEmployer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this._Departament = new System.Windows.Forms.TextBox();
            this._Post = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Addresss = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.KPI = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update_Department = new System.Windows.Forms.Button();
            this.Delete_Department = new System.Windows.Forms.Button();
            this.Add_Department = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoadData = new System.Windows.Forms.Button();
            this.DepartmentCheck = new System.Windows.Forms.CheckBox();
            this.PostCheck = new System.Windows.Forms.CheckBox();
            this.Department = new System.Windows.Forms.ComboBox();
            this.Post = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.95441F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.04559F));
            this.tableLayoutPanel1.Controls.Add(this.EmployerGrid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.88312F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.11688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 545);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // EmployerGrid
            // 
            this.EmployerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfoEmployer});
            this.EmployerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployerGrid.Location = new System.Drawing.Point(398, 3);
            this.EmployerGrid.Name = "EmployerGrid";
            this.EmployerGrid.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.EmployerGrid, 2);
            this.EmployerGrid.RowTemplate.Height = 24;
            this.EmployerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployerGrid.Size = new System.Drawing.Size(668, 397);
            this.EmployerGrid.TabIndex = 0;
            this.EmployerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployerGrid_CellContentClick);
            // 
            // InfoEmployer
            // 
            this.InfoEmployer.HeaderText = "Інформація працівника";
            this.InfoEmployer.MinimumWidth = 6;
            this.InfoEmployer.Name = "InfoEmployer";
            this.InfoEmployer.Text = "View";
            this.InfoEmployer.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Salary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LID);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this._Departament);
            this.groupBox1.Controls.Add(this._Post);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Addresss);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.MiddleName);
            this.groupBox1.Controls.Add(this.KPI);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 290);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація працівника";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(148, 177);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(186, 22);
            this.Salary.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(79, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Оклад";
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LID.Location = new System.Drawing.Point(116, 44);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(26, 20);
            this.LID.TabIndex = 1;
            this.LID.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(148, 42);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(186, 22);
            this.ID.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(18, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Департамент";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(148, 69);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(186, 22);
            this.FirstName.TabIndex = 2;
            // 
            // _Departament
            // 
            this._Departament.Location = new System.Drawing.Point(148, 258);
            this._Departament.Name = "_Departament";
            this._Departament.Size = new System.Drawing.Size(186, 22);
            this._Departament.TabIndex = 8;
            // 
            // _Post
            // 
            this._Post.Location = new System.Drawing.Point(148, 231);
            this._Post.Name = "_Post";
            this._Post.Size = new System.Drawing.Size(186, 22);
            this._Post.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "По батькові";
            // 
            // Addresss
            // 
            this.Addresss.AutoSize = true;
            this.Addresss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Addresss.Location = new System.Drawing.Point(80, 154);
            this.Addresss.Name = "Addresss";
            this.Addresss.Size = new System.Drawing.Size(62, 20);
            this.Addresss.TabIndex = 9;
            this.Addresss.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(69, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Посада";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(148, 123);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(186, 22);
            this.LastName.TabIndex = 6;
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(148, 96);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(186, 22);
            this.MiddleName.TabIndex = 4;
            // 
            // KPI
            // 
            this.KPI.Location = new System.Drawing.Point(148, 204);
            this.KPI.Name = "KPI";
            this.KPI.Size = new System.Drawing.Size(186, 22);
            this.KPI.TabIndex = 10;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(148, 150);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(186, 22);
            this.Address.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(103, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ім\'я";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(107, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "КРІ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Update_Department);
            this.panel1.Controls.Add(this.Delete_Department);
            this.panel1.Controls.Add(this.Add_Department);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 136);
            this.panel1.TabIndex = 10;
            // 
            // Update_Department
            // 
            this.Update_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Update_Department.Location = new System.Drawing.Point(121, 18);
            this.Update_Department.Name = "Update_Department";
            this.Update_Department.Size = new System.Drawing.Size(101, 53);
            this.Update_Department.TabIndex = 5;
            this.Update_Department.Text = "Оновити";
            this.Update_Department.UseVisualStyleBackColor = true;
            this.Update_Department.Click += new System.EventHandler(this.Update_Department_Click);
            // 
            // Delete_Department
            // 
            this.Delete_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete_Department.Location = new System.Drawing.Point(14, 74);
            this.Delete_Department.Name = "Delete_Department";
            this.Delete_Department.Size = new System.Drawing.Size(101, 53);
            this.Delete_Department.TabIndex = 4;
            this.Delete_Department.Text = "Видалити";
            this.Delete_Department.UseVisualStyleBackColor = true;
            this.Delete_Department.Click += new System.EventHandler(this.Delete_Department_Click);
            // 
            // Add_Department
            // 
            this.Add_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Add_Department.Location = new System.Drawing.Point(14, 18);
            this.Add_Department.Name = "Add_Department";
            this.Add_Department.Size = new System.Drawing.Size(101, 53);
            this.Add_Department.TabIndex = 3;
            this.Add_Department.Text = "Додати";
            this.Add_Department.UseVisualStyleBackColor = true;
            this.Add_Department.Click += new System.EventHandler(this.Add_Department_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Back.Location = new System.Drawing.Point(235, 74);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(127, 53);
            this.Back.TabIndex = 38;
            this.Back.Text = "Повернутись";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LoadData);
            this.panel2.Controls.Add(this.DepartmentCheck);
            this.panel2.Controls.Add(this.PostCheck);
            this.panel2.Controls.Add(this.Department);
            this.panel2.Controls.Add(this.Post);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Filter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(398, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 136);
            this.panel2.TabIndex = 11;
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(15, 62);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(147, 37);
            this.LoadData.TabIndex = 45;
            this.LoadData.Text = "Скинути фільтр";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // DepartmentCheck
            // 
            this.DepartmentCheck.AutoSize = true;
            this.DepartmentCheck.Location = new System.Drawing.Point(472, 106);
            this.DepartmentCheck.Name = "DepartmentCheck";
            this.DepartmentCheck.Size = new System.Drawing.Size(155, 21);
            this.DepartmentCheck.TabIndex = 44;
            this.DepartmentCheck.Text = "Поле департамент";
            this.DepartmentCheck.UseVisualStyleBackColor = true;
            // 
            // PostCheck
            // 
            this.PostCheck.AutoSize = true;
            this.PostCheck.Location = new System.Drawing.Point(368, 106);
            this.PostCheck.Name = "PostCheck";
            this.PostCheck.Size = new System.Drawing.Size(98, 21);
            this.PostCheck.TabIndex = 44;
            this.PostCheck.Text = "Поле пост";
            this.PostCheck.UseVisualStyleBackColor = true;
            // 
            // Department
            // 
            this.Department.DisplayMember = "Name_Department";
            this.Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Department.FormattingEnabled = true;
            this.Department.Location = new System.Drawing.Point(446, 51);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(196, 33);
            this.Department.TabIndex = 43;
            this.Department.ValueMember = "ID_Department";
            // 
            // Post
            // 
            this.Post.DisplayMember = "Name_Post";
            this.Post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Post.FormattingEnabled = true;
            this.Post.Location = new System.Drawing.Point(446, 9);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(196, 33);
            this.Post.TabIndex = 42;
            this.Post.ValueMember = "ID_Post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(292, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Департамент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(378, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Пост";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Filter.Location = new System.Drawing.Point(15, 18);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(147, 38);
            this.Filter.TabIndex = 39;
            this.Filter.Text = "Фільтр";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Employer";
            this.Text = "Працівник";
            this.Load += new System.EventHandler(this.Emplyer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployerGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView EmployerGrid;
        private System.Windows.Forms.DataGridViewButtonColumn InfoEmployer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox _Departament;
        private System.Windows.Forms.TextBox _Post;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Addresss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox KPI;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Update_Department;
        private System.Windows.Forms.Button Delete_Department;
        private System.Windows.Forms.Button Add_Department;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.CheckBox DepartmentCheck;
        private System.Windows.Forms.CheckBox PostCheck;
        private System.Windows.Forms.ComboBox Department;
        private System.Windows.Forms.ComboBox Post;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Filter;
    }
}

