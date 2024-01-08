
namespace proje1
{
    partial class Form_senecekler
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
            this.button_akademisyen = new System.Windows.Forms.Button();
            this.button_ogr = new System.Windows.Forms.Button();
            this.button_ders = new System.Windows.Forms.Button();
            this.button_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_akademisyen
            // 
            this.button_akademisyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_akademisyen.Location = new System.Drawing.Point(142, 199);
            this.button_akademisyen.Name = "button_akademisyen";
            this.button_akademisyen.Size = new System.Drawing.Size(230, 205);
            this.button_akademisyen.TabIndex = 0;
            this.button_akademisyen.Text = "Akademisyen";
            this.button_akademisyen.UseVisualStyleBackColor = true;
            this.button_akademisyen.Click += new System.EventHandler(this.button_akademisyen_Click);
            // 
            // button_ogr
            // 
            this.button_ogr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ogr.Location = new System.Drawing.Point(437, 199);
            this.button_ogr.Name = "button_ogr";
            this.button_ogr.Size = new System.Drawing.Size(230, 205);
            this.button_ogr.TabIndex = 0;
            this.button_ogr.Text = "Öğrenci";
            this.button_ogr.UseVisualStyleBackColor = true;
            this.button_ogr.Click += new System.EventHandler(this.button_ogr_Click);
            // 
            // button_ders
            // 
            this.button_ders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ders.Location = new System.Drawing.Point(717, 199);
            this.button_ders.Name = "button_ders";
            this.button_ders.Size = new System.Drawing.Size(230, 205);
            this.button_ders.TabIndex = 0;
            this.button_ders.Text = "Dersler";
            this.button_ders.UseVisualStyleBackColor = true;
            this.button_ders.Click += new System.EventHandler(this.button_ders_Click);
            // 
            // button_cikis
            // 
            this.button_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cikis.Location = new System.Drawing.Point(907, 45);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(211, 44);
            this.button_cikis.TabIndex = 0;
            this.button_cikis.Text = "Çıkış yap";
            this.button_cikis.UseVisualStyleBackColor = true;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // Form_senecekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 714);
            this.Controls.Add(this.button_ders);
            this.Controls.Add(this.button_cikis);
            this.Controls.Add(this.button_ogr);
            this.Controls.Add(this.button_akademisyen);
            this.Name = "Form_senecekler";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_akademisyen;
        private System.Windows.Forms.Button button_ogr;
        private System.Windows.Forms.Button button_ders;
        private System.Windows.Forms.Button button_cikis;
    }
}