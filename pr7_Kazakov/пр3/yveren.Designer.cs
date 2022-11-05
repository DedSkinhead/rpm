namespace пр3
{
    partial class yveren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yveren));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Yes2 = new System.Windows.Forms.Button();
            this.otmena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все данные будут потеряны!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вы уверены, что хотите произвести удаление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "данных?";
            // 
            // Yes2
            // 
            this.Yes2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Yes2.Location = new System.Drawing.Point(75, 165);
            this.Yes2.Margin = new System.Windows.Forms.Padding(2);
            this.Yes2.Name = "Yes2";
            this.Yes2.Size = new System.Drawing.Size(105, 48);
            this.Yes2.TabIndex = 3;
            this.Yes2.Text = "Да";
            this.Yes2.UseVisualStyleBackColor = true;
            this.Yes2.Click += new System.EventHandler(this.Yes2_Click);
            // 
            // otmena
            // 
            this.otmena.Location = new System.Drawing.Point(272, 165);
            this.otmena.Margin = new System.Windows.Forms.Padding(2);
            this.otmena.Name = "otmena";
            this.otmena.Size = new System.Drawing.Size(104, 48);
            this.otmena.TabIndex = 4;
            this.otmena.Text = "Отмена";
            this.otmena.UseVisualStyleBackColor = true;
            this.otmena.Click += new System.EventHandler(this.otmena_Click);
            // 
            // yveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 287);
            this.Controls.Add(this.otmena);
            this.Controls.Add(this.Yes2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "yveren";
            this.Text = "yveren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Yes2;
        private System.Windows.Forms.Button otmena;
    }
}