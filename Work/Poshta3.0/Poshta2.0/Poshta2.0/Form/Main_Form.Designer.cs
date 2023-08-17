
namespace Poshta2._0
{
    partial class Main_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployerPrice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BDepartment = new System.Windows.Forms.Button();
            this.BEmployee = new System.Windows.Forms.Button();
            this.BPost = new System.Windows.Forms.Button();
            this.KPI = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(132, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.EmployerPrice);
            this.panel2.Location = new System.Drawing.Point(416, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 433);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(93, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Звіти";
            // 
            // EmployerPrice
            // 
            this.EmployerPrice.BackColor = System.Drawing.Color.White;
            this.EmployerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployerPrice.Location = new System.Drawing.Point(27, 65);
            this.EmployerPrice.Name = "EmployerPrice";
            this.EmployerPrice.Size = new System.Drawing.Size(211, 74);
            this.EmployerPrice.TabIndex = 0;
            this.EmployerPrice.Text = "Виплати працівникам";
            this.EmployerPrice.UseVisualStyleBackColor = false;
            this.EmployerPrice.Click += new System.EventHandler(this.EmployerPrice_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.KPI);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BDepartment);
            this.panel1.Controls.Add(this.BEmployee);
            this.panel1.Controls.Add(this.BPost);
            this.panel1.Location = new System.Drawing.Point(110, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 433);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(80, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Форми";
            // 
            // BDepartment
            // 
            this.BDepartment.BackColor = System.Drawing.Color.White;
            this.BDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDepartment.Location = new System.Drawing.Point(27, 157);
            this.BDepartment.Name = "BDepartment";
            this.BDepartment.Size = new System.Drawing.Size(211, 74);
            this.BDepartment.TabIndex = 1;
            this.BDepartment.Text = "Департамент";
            this.BDepartment.UseVisualStyleBackColor = false;
            this.BDepartment.Click += new System.EventHandler(this.BDepartment_Click);
            // 
            // BEmployee
            // 
            this.BEmployee.BackColor = System.Drawing.Color.White;
            this.BEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEmployee.Location = new System.Drawing.Point(27, 65);
            this.BEmployee.Name = "BEmployee";
            this.BEmployee.Size = new System.Drawing.Size(211, 74);
            this.BEmployee.TabIndex = 0;
            this.BEmployee.Text = "Працівники";
            this.BEmployee.UseVisualStyleBackColor = false;
            this.BEmployee.Click += new System.EventHandler(this.BEmployee_Click);
            // 
            // BPost
            // 
            this.BPost.BackColor = System.Drawing.Color.White;
            this.BPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPost.Location = new System.Drawing.Point(27, 245);
            this.BPost.Name = "BPost";
            this.BPost.Size = new System.Drawing.Size(211, 74);
            this.BPost.TabIndex = 1;
            this.BPost.Text = "Пости";
            this.BPost.UseVisualStyleBackColor = false;
            this.BPost.Click += new System.EventHandler(this.BPost_Click);
            // 
            // KPI
            // 
            this.KPI.BackColor = System.Drawing.Color.White;
            this.KPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KPI.Location = new System.Drawing.Point(27, 325);
            this.KPI.Name = "KPI";
            this.KPI.Size = new System.Drawing.Size(211, 74);
            this.KPI.TabIndex = 3;
            this.KPI.Text = "KPI";
            this.KPI.UseVisualStyleBackColor = false;
            this.KPI.Click += new System.EventHandler(this.KPI_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EmployerPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BDepartment;
        private System.Windows.Forms.Button BEmployee;
        private System.Windows.Forms.Button BPost;
        private System.Windows.Forms.Button KPI;
    }
}