
namespace Poshta2._0
{
    partial class FormEmployeer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Back = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.KPI = new System.Windows.Forms.ComboBox();
            this.ID_Department = new System.Windows.Forms.ComboBox();
            this.ID_Post = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewEmployeer = new System.Windows.Forms.Button();
            this.SaveEmployeer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this.KPI);
            this.groupBox1.Controls.Add(this.ID_Department);
            this.groupBox1.Controls.Add(this.ID_Post);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.MiddleName);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NewEmployeer);
            this.groupBox1.Controls.Add(this.SaveEmployeer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 474);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація працівника";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Back.Location = new System.Drawing.Point(17, 415);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(147, 38);
            this.Back.TabIndex = 36;
            this.Back.Text = "Повернутись";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(153, 66);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(196, 33);
            this.FirstName.TabIndex = 35;
            // 
            // KPI
            // 
            this.KPI.DisplayMember = "Name_KPI";
            this.KPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KPI.FormattingEnabled = true;
            this.KPI.Location = new System.Drawing.Point(153, 226);
            this.KPI.Name = "KPI";
            this.KPI.Size = new System.Drawing.Size(196, 33);
            this.KPI.TabIndex = 34;
            this.KPI.ValueMember = "Percent";
            // 
            // ID_Department
            // 
            this.ID_Department.DisplayMember = "Name_Department";
            this.ID_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Department.FormattingEnabled = true;
            this.ID_Department.Location = new System.Drawing.Point(153, 306);
            this.ID_Department.Name = "ID_Department";
            this.ID_Department.Size = new System.Drawing.Size(196, 33);
            this.ID_Department.TabIndex = 33;
            this.ID_Department.ValueMember = "ID_Department";
            // 
            // ID_Post
            // 
            this.ID_Post.DisplayMember = "Name_Post";
            this.ID_Post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Post.FormattingEnabled = true;
            this.ID_Post.Location = new System.Drawing.Point(153, 266);
            this.ID_Post.Name = "ID_Post";
            this.ID_Post.Size = new System.Drawing.Size(196, 33);
            this.ID_Post.TabIndex = 32;
            this.ID_Post.ValueMember = "ID_Post";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.Location = new System.Drawing.Point(153, 186);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(196, 33);
            this.Address.TabIndex = 31;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(153, 146);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(196, 33);
            this.LastName.TabIndex = 30;
            // 
            // MiddleName
            // 
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleName.Location = new System.Drawing.Point(153, 106);
            this.MiddleName.Multiline = true;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(196, 33);
            this.MiddleName.TabIndex = 29;
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(153, 26);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(196, 33);
            this.ID.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(103, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "КРІ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(75, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(-1, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Департамент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(85, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пост";
            // 
            // NewEmployeer
            // 
            this.NewEmployeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewEmployeer.Location = new System.Drawing.Point(180, 363);
            this.NewEmployeer.Name = "NewEmployeer";
            this.NewEmployeer.Size = new System.Drawing.Size(136, 90);
            this.NewEmployeer.TabIndex = 9;
            this.NewEmployeer.Text = "Створити нового співробітника";
            this.NewEmployeer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewEmployeer.UseVisualStyleBackColor = true;
            this.NewEmployeer.Click += new System.EventHandler(this.NewEmployeer_Click);
            // 
            // SaveEmployeer
            // 
            this.SaveEmployeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveEmployeer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveEmployeer.Location = new System.Drawing.Point(17, 363);
            this.SaveEmployeer.Name = "SaveEmployeer";
            this.SaveEmployeer.Size = new System.Drawing.Size(147, 46);
            this.SaveEmployeer.TabIndex = 8;
            this.SaveEmployeer.Text = "Зберегти";
            this.SaveEmployeer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveEmployeer.UseVisualStyleBackColor = true;
            this.SaveEmployeer.Click += new System.EventHandler(this.SaveEmployeer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "По батькові";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbID.Location = new System.Drawing.Point(113, 34);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 25);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(95, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ім\'я";
            // 
            // FormEmployeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 474);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmployeer";
            this.Text = "FormEmployeer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.ComboBox KPI;
        private System.Windows.Forms.ComboBox ID_Department;
        private System.Windows.Forms.ComboBox ID_Post;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NewEmployeer;
        private System.Windows.Forms.Button SaveEmployeer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}