namespace BarlangokGUI
{
    partial class BarlangokForm
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
            lblUi01 = new Label();
            btnKereses = new Button();
            lblUi02 = new Label();
            lblUi03 = new Label();
            lblUi04 = new Label();
            tbAzon = new TextBox();
            tbMely = new TextBox();
            tbHossz = new TextBox();
            lblNev = new Label();
            btnMentes = new Button();
            SuspendLayout();
            // 
            // lblUi01
            // 
            lblUi01.AutoSize = true;
            lblUi01.Location = new Point(19, 29);
            lblUi01.Margin = new Padding(10, 20, 5, 0);
            lblUi01.Name = "lblUi01";
            lblUi01.Size = new Size(100, 25);
            lblUi01.TabIndex = 0;
            lblUi01.Text = "Azonosító:";
            // 
            // btnKereses
            // 
            btnKereses.Location = new Point(363, 29);
            btnKereses.Margin = new Padding(5);
            btnKereses.Name = "btnKereses";
            btnKereses.Size = new Size(207, 38);
            btnKereses.TabIndex = 1;
            btnKereses.Text = "Barlang keresése";
            btnKereses.UseVisualStyleBackColor = true;
            // 
            // lblUi02
            // 
            lblUi02.AutoSize = true;
            lblUi02.Location = new Point(19, 121);
            lblUi02.Margin = new Padding(5, 0, 5, 0);
            lblUi02.Name = "lblUi02";
            lblUi02.Size = new Size(126, 25);
            lblUi02.TabIndex = 0;
            lblUi02.Text = "Barlang neve:";
            // 
            // lblUi03
            // 
            lblUi03.AutoSize = true;
            lblUi03.Location = new Point(19, 213);
            lblUi03.Margin = new Padding(5, 0, 5, 0);
            lblUi03.Name = "lblUi03";
            lblUi03.Size = new Size(105, 25);
            lblUi03.TabIndex = 0;
            lblUi03.Text = "Hosszúság:";
            // 
            // lblUi04
            // 
            lblUi04.AutoSize = true;
            lblUi04.Location = new Point(19, 307);
            lblUi04.Margin = new Padding(10, 0, 5, 20);
            lblUi04.Name = "lblUi04";
            lblUi04.Size = new Size(86, 25);
            lblUi04.TabIndex = 0;
            lblUi04.Text = "Mélység:";
            // 
            // tbAzon
            // 
            tbAzon.Location = new Point(155, 26);
            tbAzon.Margin = new Padding(5);
            tbAzon.Name = "tbAzon";
            tbAzon.Size = new Size(155, 32);
            tbAzon.TabIndex = 0;
            // 
            // tbMely
            // 
            tbMely.Location = new Point(155, 304);
            tbMely.Margin = new Padding(5);
            tbMely.Name = "tbMely";
            tbMely.Size = new Size(155, 32);
            tbMely.TabIndex = 3;
            // 
            // tbHossz
            // 
            tbHossz.Location = new Point(155, 210);
            tbHossz.Margin = new Padding(5);
            tbHossz.Name = "tbHossz";
            tbHossz.Size = new Size(155, 32);
            tbHossz.TabIndex = 2;
            // 
            // lblNev
            // 
            lblNev.AutoSize = true;
            lblNev.Location = new Point(155, 121);
            lblNev.Margin = new Padding(5, 0, 5, 0);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(0, 25);
            lblNev.TabIndex = 0;
            // 
            // btnMentes
            // 
            btnMentes.Enabled = false;
            btnMentes.Location = new Point(363, 213);
            btnMentes.Margin = new Padding(5);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(207, 38);
            btnMentes.TabIndex = 4;
            btnMentes.Text = "Adatok mentése";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // BarlangokForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(btnMentes);
            Controls.Add(btnKereses);
            Controls.Add(tbHossz);
            Controls.Add(tbMely);
            Controls.Add(tbAzon);
            Controls.Add(lblUi04);
            Controls.Add(lblUi03);
            Controls.Add(lblNev);
            Controls.Add(lblUi02);
            Controls.Add(lblUi01);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "BarlangokForm";
            Text = "Barlangok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUi01;
        private Button btnKereses;
        private Label lblUi02;
        private Label lblUi03;
        private Label lblUi04;
        private TextBox tbAzon;
        private TextBox tbMely;
        private TextBox tbHossz;
        private Label lblNev;
        private Button btnMentes;
    }
}
