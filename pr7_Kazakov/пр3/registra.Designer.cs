namespace пр3
{
    partial class registra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registra));
            this.Yes = new System.Windows.Forms.Button();
            this.Cancellection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(38, 236);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(123, 33);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Да";
            this.Yes.UseVisualStyleBackColor = true;
            // 
            // Cancellection
            // 
            this.Cancellection.Location = new System.Drawing.Point(303, 236);
            this.Cancellection.Name = "Cancellection";
            this.Cancellection.Size = new System.Drawing.Size(128, 34);
            this.Cancellection.TabIndex = 1;
            this.Cancellection.Text = "Отмена";
            this.Cancellection.UseVisualStyleBackColor = true;
            // 
            // registra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 406);
            this.Controls.Add(this.Cancellection);
            this.Controls.Add(this.Yes);
            this.Name = "registra";
            this.Text = "registra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button Cancellection;
    }
}