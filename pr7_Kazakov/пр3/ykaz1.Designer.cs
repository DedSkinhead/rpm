namespace пр3
{
    partial class ykaz1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ykaz1));
            this.ykaz = new System.Windows.Forms.Label();
            this.yka = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.otmena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ykaz
            // 
            this.ykaz.AutoSize = true;
            this.ykaz.Location = new System.Drawing.Point(63, 82);
            this.ykaz.Name = "ykaz";
            this.ykaz.Size = new System.Drawing.Size(105, 13);
            this.ykaz.TabIndex = 0;
            this.ykaz.Text = "Укажите Ваше имя";
            // 
            // yka
            // 
            this.yka.Location = new System.Drawing.Point(66, 108);
            this.yka.Name = "yka";
            this.yka.Size = new System.Drawing.Size(188, 20);
            this.yka.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(66, 177);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(131, 42);
            this.ok.TabIndex = 2;
            this.ok.Text = "Ок";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // otmena
            // 
            this.otmena.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.otmena.Location = new System.Drawing.Point(273, 178);
            this.otmena.Name = "otmena";
            this.otmena.Size = new System.Drawing.Size(114, 41);
            this.otmena.TabIndex = 3;
            this.otmena.Text = "Отмена";
            this.otmena.UseVisualStyleBackColor = true;
            this.otmena.Click += new System.EventHandler(this.otmena_Click);
            // 
            // ykaz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 273);
            this.Controls.Add(this.otmena);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.yka);
            this.Controls.Add(this.ykaz);
            this.Name = "ykaz1";
            this.Text = "ykaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ykaz;
        public System.Windows.Forms.TextBox yka;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button otmena;
    }
}