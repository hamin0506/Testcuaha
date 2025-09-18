namespace Testcuaha
{
    partial class Thomdemo
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
            lblend = new Label();
            SuspendLayout();
            // 
            // lblend
            // 
            lblend.AutoSize = true;
            lblend.Location = new Point(177, 76);
            lblend.Name = "lblend";
            lblend.Size = new Size(57, 25);
            lblend.TabIndex = 0;
            lblend.Text = "Thoát";
            // 
            // Thomdemo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblend);
            Name = "Thomdemo";
            Text = "Thomdemo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblend;
    }
}