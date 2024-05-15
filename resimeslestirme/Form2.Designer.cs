namespace resimeslestirme
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
            label1 = new Label();
            tekrarbaslat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(343, 66);
            label1.TabIndex = 1;
            label1.Text = "Kartları Eşleştirin";
            // 
            // tekrarbaslat
            // 
            tekrarbaslat.Location = new Point(481, 136);
            tekrarbaslat.Name = "tekrarbaslat";
            tekrarbaslat.Size = new Size(134, 68);
            tekrarbaslat.TabIndex = 2;
            tekrarbaslat.Text = "Tekrar Başlat";
            tekrarbaslat.UseVisualStyleBackColor = true;
            tekrarbaslat.Click += tekrarbaslat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(646, 678);
            Controls.Add(tekrarbaslat);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Kolay Seviye";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button tekrarbaslat;
    }
}