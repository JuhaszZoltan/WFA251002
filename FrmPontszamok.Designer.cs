namespace WFA251002
{
    partial class FrmPontszamok
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
            lblUI001 = new Label();
            lblUI002 = new Label();
            txtDiakNeve = new TextBox();
            rtbDiakok = new RichTextBox();
            nudDiakPontszama = new NumericUpDown();
            btnAtlag = new Button();
            btnAdatbevitel = new Button();
            lblAtlagPont = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDiakPontszama).BeginInit();
            SuspendLayout();
            // 
            // lblUI001
            // 
            lblUI001.AutoSize = true;
            lblUI001.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUI001.Location = new Point(61, 18);
            lblUI001.Name = "lblUI001";
            lblUI001.Size = new Size(45, 21);
            lblUI001.TabIndex = 0;
            lblUI001.Text = "Név:";
            // 
            // lblUI002
            // 
            lblUI002.AutoSize = true;
            lblUI002.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUI002.Location = new Point(61, 65);
            lblUI002.Name = "lblUI002";
            lblUI002.Size = new Size(89, 21);
            lblUI002.TabIndex = 0;
            lblUI002.Text = "Pontszám:";
            // 
            // txtDiakNeve
            // 
            txtDiakNeve.Location = new Point(169, 12);
            txtDiakNeve.Name = "txtDiakNeve";
            txtDiakNeve.Size = new Size(155, 32);
            txtDiakNeve.TabIndex = 1;
            // 
            // rtbDiakok
            // 
            rtbDiakok.Font = new Font("Courier New", 12F, FontStyle.Bold);
            rtbDiakok.Location = new Point(12, 157);
            rtbDiakok.Name = "rtbDiakok";
            rtbDiakok.ReadOnly = true;
            rtbDiakok.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbDiakok.Size = new Size(360, 204);
            rtbDiakok.TabIndex = 0;
            rtbDiakok.TabStop = false;
            rtbDiakok.Text = "";
            // 
            // nudDiakPontszama
            // 
            nudDiakPontszama.Location = new Point(169, 60);
            nudDiakPontszama.Name = "nudDiakPontszama";
            nudDiakPontszama.Size = new Size(155, 32);
            nudDiakPontszama.TabIndex = 2;
            nudDiakPontszama.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAtlag
            // 
            btnAtlag.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAtlag.Location = new Point(80, 379);
            btnAtlag.Name = "btnAtlag";
            btnAtlag.Size = new Size(225, 41);
            btnAtlag.TabIndex = 4;
            btnAtlag.TabStop = false;
            btnAtlag.Text = "Átlag";
            btnAtlag.UseVisualStyleBackColor = true;
            // 
            // btnAdatbevitel
            // 
            btnAdatbevitel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdatbevitel.Location = new Point(80, 110);
            btnAdatbevitel.Name = "btnAdatbevitel";
            btnAdatbevitel.Size = new Size(225, 41);
            btnAdatbevitel.TabIndex = 3;
            btnAdatbevitel.Text = "Adatbevitel";
            btnAdatbevitel.UseVisualStyleBackColor = true;
            // 
            // lblAtlagPont
            // 
            lblAtlagPont.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAtlagPont.Location = new Point(80, 423);
            lblAtlagPont.Name = "lblAtlagPont";
            lblAtlagPont.Size = new Size(225, 29);
            lblAtlagPont.TabIndex = 0;
            lblAtlagPont.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPontszamok
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(btnAdatbevitel);
            Controls.Add(btnAtlag);
            Controls.Add(nudDiakPontszama);
            Controls.Add(rtbDiakok);
            Controls.Add(txtDiakNeve);
            Controls.Add(lblAtlagPont);
            Controls.Add(lblUI002);
            Controls.Add(lblUI001);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmPontszamok";
            Text = "Dolgozatok";
            ((System.ComponentModel.ISupportInitialize)nudDiakPontszama).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI001;
        private Label lblUI002;
        private TextBox txtDiakNeve;
        private RichTextBox rtbDiakok;
        private NumericUpDown nudDiakPontszama;
        private Button btnAtlag;
        private Button btnAdatbevitel;
        private Label lblAtlagPont;
    }
}
