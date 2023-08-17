
namespace Poshta2._0
{
    partial class EmployerSalaryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.PrintFile = new System.Windows.Forms.Button();
            this.GridEmployer = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TSumaIKP = new System.Windows.Forms.TextBox();
            this.TSuma = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployer)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.1452F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.8548F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GridEmployer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.61199F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.38801F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 548);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OpenFile);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.PrintFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(356, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 216);
            this.panel1.TabIndex = 10;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(31, 87);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(147, 39);
            this.OpenFile.TabIndex = 41;
            this.OpenFile.Text = "Відкрити Файл";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Back.Location = new System.Drawing.Point(31, 177);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(147, 38);
            this.Back.TabIndex = 40;
            this.Back.Text = "Повернутись";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PrintFile
            // 
            this.PrintFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PrintFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintFile.Location = new System.Drawing.Point(31, 17);
            this.PrintFile.Name = "PrintFile";
            this.PrintFile.Size = new System.Drawing.Size(147, 64);
            this.PrintFile.TabIndex = 37;
            this.PrintFile.Text = "Друкувати файл";
            this.PrintFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PrintFile.UseVisualStyleBackColor = true;
            this.PrintFile.Click += new System.EventHandler(this.PrintFile_Click);
            // 
            // GridEmployer
            // 
            this.GridEmployer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.GridEmployer, 2);
            this.GridEmployer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEmployer.Location = new System.Drawing.Point(3, 3);
            this.GridEmployer.Name = "GridEmployer";
            this.GridEmployer.RowHeadersWidth = 51;
            this.GridEmployer.RowTemplate.Height = 24;
            this.GridEmployer.Size = new System.Drawing.Size(794, 320);
            this.GridEmployer.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TSumaIKP);
            this.panel2.Controls.Add(this.TSuma);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 216);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Сумма ЗП + ІКР";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Сумма ЗП";
            // 
            // TSumaIKP
            // 
            this.TSumaIKP.Enabled = false;
            this.TSumaIKP.Location = new System.Drawing.Point(200, 61);
            this.TSumaIKP.Multiline = true;
            this.TSumaIKP.Name = "TSumaIKP";
            this.TSumaIKP.Size = new System.Drawing.Size(131, 38);
            this.TSumaIKP.TabIndex = 14;
            // 
            // TSuma
            // 
            this.TSuma.Enabled = false;
            this.TSuma.Location = new System.Drawing.Point(200, 17);
            this.TSuma.Multiline = true;
            this.TSuma.Name = "TSuma";
            this.TSuma.Size = new System.Drawing.Size(131, 38);
            this.TSuma.TabIndex = 13;
            // 
            // EmployerSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployerSalaryForm";
            this.Text = "EmployerSalaryForm";
            this.Load += new System.EventHandler(this.EmployerSalaryForm_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button PrintFile;
        private System.Windows.Forms.DataGridView GridEmployer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TSumaIKP;
        private System.Windows.Forms.TextBox TSuma;
        private System.Windows.Forms.Button OpenFile;
    }
}