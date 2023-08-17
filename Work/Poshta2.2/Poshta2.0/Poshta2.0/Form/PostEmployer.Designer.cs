
namespace Poshta2._0
{
    partial class PostEmployer
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
            this.Post_Grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.ID_Post = new System.Windows.Forms.TextBox();
            this.Name_Post = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Update_Department = new System.Windows.Forms.Button();
            this.Delete_Department = new System.Windows.Forms.Button();
            this.Add_Department = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Post_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Post_Grid, 1, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 542);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // Post_Grid
            // 
            this.Post_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Post_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Post_Grid.Location = new System.Drawing.Point(501, 3);
            this.Post_Grid.Name = "Post_Grid";
            this.Post_Grid.ReadOnly = true;
            this.Post_Grid.RowHeadersWidth = 51;
            this.Post_Grid.RowTemplate.Height = 24;
            this.Post_Grid.Size = new System.Drawing.Size(492, 438);
            this.Post_Grid.TabIndex = 14;
            this.Post_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Post_Grid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Salary);
            this.panel1.Controls.Add(this.ID_Post);
            this.panel1.Controls.Add(this.Name_Post);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 438);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(115, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Оклад";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(115, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Пост";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Код";
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary.Location = new System.Drawing.Point(180, 102);
            this.Salary.Multiline = true;
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(196, 33);
            this.Salary.TabIndex = 13;
            this.Salary.Text = "Оклад";
            // 
            // ID_Post
            // 
            this.ID_Post.Enabled = false;
            this.ID_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Post.Location = new System.Drawing.Point(180, 24);
            this.ID_Post.Multiline = true;
            this.ID_Post.Name = "ID_Post";
            this.ID_Post.Size = new System.Drawing.Size(196, 33);
            this.ID_Post.TabIndex = 9;
            // 
            // Name_Post
            // 
            this.Name_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Post.Location = new System.Drawing.Point(180, 63);
            this.Name_Post.Multiline = true;
            this.Name_Post.Name = "Name_Post";
            this.Name_Post.Size = new System.Drawing.Size(196, 33);
            this.Name_Post.TabIndex = 12;
            this.Name_Post.Text = "Назва";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Update_Department);
            this.panel2.Controls.Add(this.Delete_Department);
            this.panel2.Controls.Add(this.Add_Department);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 71);
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
            this.panel3.Location = new System.Drawing.Point(501, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 71);
            this.panel3.TabIndex = 17;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Back.Location = new System.Drawing.Point(336, 28);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(147, 38);
            this.Back.TabIndex = 42;
            this.Back.Text = "Повернутись";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PostEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PostEmployer";
            this.Text = "PostEmployer";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Post_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Post_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ID_Post;
        private System.Windows.Forms.TextBox Name_Post;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Update_Department;
        private System.Windows.Forms.Button Delete_Department;
        private System.Windows.Forms.Button Add_Department;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}