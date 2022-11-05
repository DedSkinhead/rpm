
namespace пр3
{
    partial class vixod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vixod));
            this.label1 = new System.Windows.Forms.Label();
            this.zaverhenie = new System.Windows.Forms.Button();
            this.otmena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подвердите завершение работы с программой.";
            // 
            // zaverhenie
            // 
            this.zaverhenie.Location = new System.Drawing.Point(60, 208);
            this.zaverhenie.Margin = new System.Windows.Forms.Padding(2);
            this.zaverhenie.Name = "zaverhenie";
            this.zaverhenie.Size = new System.Drawing.Size(120, 46);
            this.zaverhenie.TabIndex = 1;
            this.zaverhenie.Text = "Завершение";
            this.zaverhenie.UseVisualStyleBackColor = true;
            this.zaverhenie.Click += new System.EventHandler(this.zaverhenie_Click);
            // 
            // otmena
            // 
            this.otmena.Location = new System.Drawing.Point(400, 208);
            this.otmena.Margin = new System.Windows.Forms.Padding(2);
            this.otmena.Name = "otmena";
            this.otmena.Size = new System.Drawing.Size(112, 45);
            this.otmena.TabIndex = 2;
            this.otmena.Text = "Отмена";
            this.otmena.UseVisualStyleBackColor = true;
            this.otmena.Click += new System.EventHandler(this.otmena_Click);
            // 
            // vixod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.otmena);
            this.Controls.Add(this.zaverhenie);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "vixod";
            this.Text = "vixod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zaverhenie;
        private System.Windows.Forms.Button otmena;
    }
}