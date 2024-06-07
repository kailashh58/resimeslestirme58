namespace resimeslestirme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            kolayseviye = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Bookman Old Style", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 74);
            label1.Name = "label1";
            label1.Size = new Size(409, 76);
            label1.TabIndex = 0;
            label1.Text = "Kart eşleştirme ";
            label1.Click += label1_Click;
            // 
            // kolayseviye
            // 
            kolayseviye.BackColor = Color.PaleTurquoise;
            kolayseviye.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kolayseviye.Location = new Point(217, 173);
            kolayseviye.Name = "kolayseviye";
            kolayseviye.Size = new Size(130, 48);
            kolayseviye.TabIndex = 1;
            kolayseviye.Text = "Oyna";
            kolayseviye.UseVisualStyleBackColor = false;
            kolayseviye.Click += kolayseviye_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(586, 524);
            Controls.Add(kolayseviye);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BG";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button kolayseviye;
    }
}
