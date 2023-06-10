namespace Keranjang
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
            panel1 = new Panel();
            keranjang1 = new Keranjang();
            keranjang2 = new Keranjang();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(keranjang2);
            panel1.Controls.Add(keranjang1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 2357);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // keranjang1
            // 
            keranjang1.Location = new Point(0, 0);
            keranjang1.Name = "keranjang1";
            keranjang1.Size = new Size(0, 0);
            keranjang1.TabIndex = 0;
            // 
            // keranjang2
            // 
            keranjang2.Location = new Point(0, 0);
            keranjang2.Name = "keranjang2";
            keranjang2.Size = new Size(2400, 2946);
            keranjang2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1902, 1055);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Keranjang keranjang1;
        private Keranjang keranjang2;
    }
}