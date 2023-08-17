
namespace Poshta2._0
{
    partial class KPI
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
            this.KPI_Grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Percent = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Update_KPI = new System.Windows.Forms.Button();
            this.Delete_KPI = new System.Windows.Forms.Button();
            this.Add_KPI = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KPI_Grid)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.KPI_Grid, 1, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // KPI_Grid
            // 
            this.KPI_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KPI_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KPI_Grid.Location = new System.Drawing.Point(362, 3);
            this.KPI_Grid.Name = "KPI_Grid";
            this.KPI_Grid.ReadOnly = true;
            this.KPI_Grid.RowHeadersWidth = 51;
            this.KPI_Grid.RowTemplate.Height = 24;
            this.KPI_Grid.Size = new System.Drawing.Size(435, 360);
            this.KPI_Grid.TabIndex = 14;
            this.KPI_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KPI_Grid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.Percent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 360);
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
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(87, 9);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(243, 33);
            this.Name.TabIndex = 9;
            // 
            // Percent
            // 
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Percent.Location = new System.Drawing.Point(87, 48);
            this.Percent.Multiline = true;
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(243, 33);
            this.Percent.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Update_KPI);
            this.panel2.Controls.Add(this.Delete_KPI);
            this.panel2.Controls.Add(this.Add_KPI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 57);
            this.panel2.TabIndex = 16;
            // 
            // Update_KPI
            // 
            this.Update_KPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Update_KPI.Location = new System.Drawing.Point(246, 13);
            this.Update_KPI.Name = "Update_KPI";
            this.Update_KPI.Size = new System.Drawing.Size(101, 53);
            this.Update_KPI.TabIndex = 2;
            this.Update_KPI.Text = "Оновити";
            this.Update_KPI.UseVisualStyleBackColor = true;
            this.Update_KPI.Click += new System.EventHandler(this.Update_KPI_Click);
            // 
            // Delete_KPI
            // 
            this.Delete_KPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete_KPI.Location = new System.Drawing.Point(128, 13);
            this.Delete_KPI.Name = "Delete_KPI";
            this.Delete_KPI.Size = new System.Drawing.Size(101, 53);
            this.Delete_KPI.TabIndex = 1;
            this.Delete_KPI.Text = "Видалити";
            this.Delete_KPI.UseVisualStyleBackColor = true;
            this.Delete_KPI.Click += new System.EventHandler(this.Delete_KPI_Click);
            // 
            // Add_KPI
            // 
            this.Add_KPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Add_KPI.Location = new System.Drawing.Point(10, 13);
            this.Add_KPI.Name = "Add_KPI";
            this.Add_KPI.Size = new System.Drawing.Size(101, 53);
            this.Add_KPI.TabIndex = 0;
            this.Add_KPI.Text = "Додати";
            this.Add_KPI.UseVisualStyleBackColor = true;
            this.Add_KPI.Click += new System.EventHandler(this.Add_KPI_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Back);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(362, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 57);
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
            // KPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
  
            this.Text = "KPI";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KPI_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView KPI_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Percent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Update_KPI;
        private System.Windows.Forms.Button Delete_KPI;
        private System.Windows.Forms.Button Add_KPI;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Back;
    }
}