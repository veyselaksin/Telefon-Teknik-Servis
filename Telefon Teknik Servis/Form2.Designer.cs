namespace Telefon_Teknik_Servis
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mstbutton = new System.Windows.Forms.Button();
            this.UrunButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // Mstbutton
            // 
            this.Mstbutton.Image = ((System.Drawing.Image)(resources.GetObject("Mstbutton.Image")));
            this.Mstbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Mstbutton.Location = new System.Drawing.Point(61, 39);
            this.Mstbutton.Name = "Mstbutton";
            this.Mstbutton.Size = new System.Drawing.Size(127, 81);
            this.Mstbutton.TabIndex = 4;
            this.Mstbutton.Text = "Müşteriler";
            this.Mstbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Mstbutton.UseVisualStyleBackColor = true;
            this.Mstbutton.Click += new System.EventHandler(this.Mstbutton_Click);
            // 
            // UrunButton
            // 
            this.UrunButton.Image = ((System.Drawing.Image)(resources.GetObject("UrunButton.Image")));
            this.UrunButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UrunButton.Location = new System.Drawing.Point(344, 39);
            this.UrunButton.Name = "UrunButton";
            this.UrunButton.Size = new System.Drawing.Size(127, 81);
            this.UrunButton.TabIndex = 5;
            this.UrunButton.Text = "Ürün İşlemleri";
            this.UrunButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UrunButton.UseVisualStyleBackColor = true;
            this.UrunButton.Click += new System.EventHandler(this.UrunButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowButton.Image")));
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowButton.Location = new System.Drawing.Point(610, 39);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(127, 81);
            this.ShowButton.TabIndex = 6;
            this.ShowButton.Text = "Göster";
            this.ShowButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.ShowButton);
            this.panel1.Controls.Add(this.UrunButton);
            this.panel1.Controls.Add(this.Mstbutton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 141);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(844, 39);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 81);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Çıkış";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teslim Listesi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Teknik Servis";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Mstbutton;
        private System.Windows.Forms.Button UrunButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}