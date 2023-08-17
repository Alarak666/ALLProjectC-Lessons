
namespace Poshta2._0
{
    partial class Department
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Department_Grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Department = new System.Windows.Forms.TextBox();
            this.Name_Department = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Update_Department = new System.Windows.Forms.Button();
            this.Delete_Department = new System.Windows.Forms.Button();
            this.Add_Department = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.94649F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.05351F));
            this.tableLayoutPanel1.Controls.Add(this.Department_Grid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.17786F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.82213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 522);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // Department_Grid
            // 
            this.Department_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Department_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Department_Grid.Location = new System.Drawing.Point(380, 3);
            this.Department_Grid.Name = "Department_Grid";
            this.Department_Grid.ReadOnly = true;
            this.Department_Grid.RowHeadersWidth = 51;
            this.Department_Grid.RowTemplate.Height = 24;
            this.Department_Grid.Size = new System.Drawing.Size(458, 421);
            this.Department_Grid.TabIndex = 14;
            this.Department_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Department_Grid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ID_Department);
            this.panel1.Controls.Add(this.Name_Department);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 421);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пост";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Код";
            // 
            // ID_Department
            // 
            this.ID_Department.Enabled = false;
            this.ID_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Department.Location = new System.Drawing.Point(87, 9);
            this.ID_Department.Multiline = true;
            this.ID_Department.Name = "ID_Department";
            this.ID_Department.Size = new System.Drawing.Size(243, 33);
            this.ID_Department.TabIndex = 9;
            // 
            // Name_Department
            // 
            this.Name_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Department.Location = new System.Drawing.Point(87, 48);
            this.Name_Department.Multiline = true;
            this.Name_Department.Name = "Name_Department";
            this.Name_Department.Size = new System.Drawing.Size(243, 33);
            this.Name_Department.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Update_Department);
            this.panel2.Controls.Add(this.Delete_Department);
            this.panel2.Controls.Add(this.Add_Department);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 68);
            this.panel2.TabIndex = 16;
            // 
            // Update_Department
            // 
            this.Update_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Update_Department.Location = new System.Drawing.Point(246, 13);
            this.Update_Department.Name = "Update_Department";
            this.Update_Department.Size = new System.Drawing.Size(101, 53);
            this.Update_Department.TabIndex = 2;
            this.Update_Department.Text = "Оновити";
            this.Update_Department.UseVisualStyleBackColor = true;
            this.Update_Department.Click += new System.EventHandler(this.Update_Department_Click);
            // 
            // Delete_Department
            // 
            this.Delete_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete_Department.Location = new System.Drawing.Point(128, 13);
            this.Delete_Department.Name = "Delete_Department";
            this.Delete_Department.Size = new System.Drawing.Size(101, 53);
            this.Delete_Department.TabIndex = 1;
            this.Delete_Department.Text = "Видалити";
            this.Delete_Department.UseVisualStyleBackColor = true;
            this.Delete_Department.Click += new System.EventHandler(this.Delete_Department_Click);
            // 
            // Add_Department
            // 
            this.Add_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Add_Department.Location = new System.Drawing.Point(10, 13);
            this.Add_Department.Name = "Add_Department";
            this.Add_Department.Size = new System.Drawing.Size(101, 53);
            this.Add_Department.TabIndex = 0;
            this.Add_Department.Text = "Додати";
            this.Add_Department.UseVisualStyleBackColor = true;
            this.Add_Department.Click += new System.EventHandler(this.Add_Department_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Back);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(380, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 68);
            this.panel3.TabIndex = 17;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Back.Location = new System.Drawing.Point(302, 20);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(147, 38);
            this.Back.TabIndex = 41;
            this.Back.Text = "Повернутись";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Department";
            this.Text = "Department";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Department_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Department_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_Department;
        private System.Windows.Forms.TextBox Name_Department;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Update_Department;
        private System.Windows.Forms.Button Delete_Department;
        private System.Windows.Forms.Button Add_Department;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Back;
    }
}