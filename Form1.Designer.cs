namespace _2020_07_21_Robot
{
    partial class Form1
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
            this.DataDGV = new System.Windows.Forms.DataGridView();
            this.PagalUžsakymaRB = new System.Windows.Forms.RadioButton();
            this.PagalGaminioRB = new System.Windows.Forms.RadioButton();
            this.Paieska1LB = new System.Windows.Forms.Label();
            this.DataNuoLB = new System.Windows.Forms.Label();
            this.Paieska1TB = new System.Windows.Forms.TextBox();
            this.DataNuoTB = new System.Windows.Forms.TextBox();
            this.IeskotiB = new System.Windows.Forms.Button();
            this.DataIkiTB = new System.Windows.Forms.TextBox();
            this.DataIkiLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DataDGV
            // 
            this.DataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDGV.Location = new System.Drawing.Point(39, 78);
            this.DataDGV.Name = "DataDGV";
            this.DataDGV.RowHeadersWidth = 51;
            this.DataDGV.RowTemplate.Height = 24;
            this.DataDGV.Size = new System.Drawing.Size(693, 305);
            this.DataDGV.TabIndex = 0;
            // 
            // PagalUžsakymaRB
            // 
            this.PagalUžsakymaRB.AutoSize = true;
            this.PagalUžsakymaRB.Location = new System.Drawing.Point(808, 95);
            this.PagalUžsakymaRB.Name = "PagalUžsakymaRB";
            this.PagalUžsakymaRB.Size = new System.Drawing.Size(220, 21);
            this.PagalUžsakymaRB.TabIndex = 1;
            this.PagalUžsakymaRB.TabStop = true;
            this.PagalUžsakymaRB.Text = "Paieška pagal užsakymo koda";
            this.PagalUžsakymaRB.UseVisualStyleBackColor = true;
            this.PagalUžsakymaRB.CheckedChanged += new System.EventHandler(this.PagalUžsakymaRB_CheckedChanged);
            // 
            // PagalGaminioRB
            // 
            this.PagalGaminioRB.AutoSize = true;
            this.PagalGaminioRB.Location = new System.Drawing.Point(808, 122);
            this.PagalGaminioRB.Name = "PagalGaminioRB";
            this.PagalGaminioRB.Size = new System.Drawing.Size(206, 21);
            this.PagalGaminioRB.TabIndex = 2;
            this.PagalGaminioRB.TabStop = true;
            this.PagalGaminioRB.Text = "Peieška pagal gaminio koda";
            this.PagalGaminioRB.UseVisualStyleBackColor = true;
            this.PagalGaminioRB.CheckedChanged += new System.EventHandler(this.PagalGaminioRB_CheckedChanged);
            // 
            // Paieska1LB
            // 
            this.Paieska1LB.AutoSize = true;
            this.Paieska1LB.Location = new System.Drawing.Point(805, 190);
            this.Paieska1LB.Name = "Paieska1LB";
            this.Paieska1LB.Size = new System.Drawing.Size(58, 17);
            this.Paieska1LB.TabIndex = 4;
            this.Paieska1LB.Text = "Peieška";
            // 
            // DataNuoLB
            // 
            this.DataNuoLB.AutoSize = true;
            this.DataNuoLB.Location = new System.Drawing.Point(805, 225);
            this.DataNuoLB.Name = "DataNuoLB";
            this.DataNuoLB.Size = new System.Drawing.Size(70, 17);
            this.DataNuoLB.TabIndex = 5;
            this.DataNuoLB.Text = "Data nuo:";
            // 
            // Paieska1TB
            // 
            this.Paieska1TB.Location = new System.Drawing.Point(932, 187);
            this.Paieska1TB.Name = "Paieska1TB";
            this.Paieska1TB.Size = new System.Drawing.Size(156, 22);
            this.Paieska1TB.TabIndex = 6;
            // 
            // DataNuoTB
            // 
            this.DataNuoTB.Location = new System.Drawing.Point(932, 222);
            this.DataNuoTB.Name = "DataNuoTB";
            this.DataNuoTB.Size = new System.Drawing.Size(156, 22);
            this.DataNuoTB.TabIndex = 7;
            // 
            // IeskotiB
            // 
            this.IeskotiB.Location = new System.Drawing.Point(974, 346);
            this.IeskotiB.Name = "IeskotiB";
            this.IeskotiB.Size = new System.Drawing.Size(75, 23);
            this.IeskotiB.TabIndex = 8;
            this.IeskotiB.Text = "Ieškoti";
            this.IeskotiB.UseVisualStyleBackColor = true;
            this.IeskotiB.Click += new System.EventHandler(this.IeskotiB_Click);
            // 
            // DataIkiTB
            // 
            this.DataIkiTB.Location = new System.Drawing.Point(932, 256);
            this.DataIkiTB.Name = "DataIkiTB";
            this.DataIkiTB.Size = new System.Drawing.Size(156, 22);
            this.DataIkiTB.TabIndex = 9;
            // 
            // DataIkiLB
            // 
            this.DataIkiLB.AutoSize = true;
            this.DataIkiLB.Location = new System.Drawing.Point(808, 256);
            this.DataIkiLB.Name = "DataIkiLB";
            this.DataIkiLB.Size = new System.Drawing.Size(59, 17);
            this.DataIkiLB.TabIndex = 10;
            this.DataIkiLB.Text = "Data iki:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 450);
            this.Controls.Add(this.DataIkiLB);
            this.Controls.Add(this.DataIkiTB);
            this.Controls.Add(this.IeskotiB);
            this.Controls.Add(this.DataNuoTB);
            this.Controls.Add(this.Paieska1TB);
            this.Controls.Add(this.DataNuoLB);
            this.Controls.Add(this.Paieska1LB);
            this.Controls.Add(this.PagalGaminioRB);
            this.Controls.Add(this.PagalUžsakymaRB);
            this.Controls.Add(this.DataDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataDGV;
        private System.Windows.Forms.RadioButton PagalUžsakymaRB;
        private System.Windows.Forms.RadioButton PagalGaminioRB;
        private System.Windows.Forms.Label Paieska1LB;
        private System.Windows.Forms.Label DataNuoLB;
        private System.Windows.Forms.TextBox Paieska1TB;
        private System.Windows.Forms.TextBox DataNuoTB;
        private System.Windows.Forms.Button IeskotiB;
        private System.Windows.Forms.TextBox DataIkiTB;
        private System.Windows.Forms.Label DataIkiLB;
    }
}

