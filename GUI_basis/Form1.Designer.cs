namespace GUI_basis
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
            this.personenLb = new System.Windows.Forms.ListBox();
            this.naamTb = new System.Windows.Forms.TextBox();
            this.idTb = new System.Windows.Forms.TextBox();
            this.leeftijdTb = new System.Windows.Forms.TextBox();
            this.invoerGb = new System.Windows.Forms.GroupBox();
            this.wisVeldenBtn = new System.Windows.Forms.Button();
            this.voegToeBtn = new System.Windows.Forms.Button();
            this.leeftijdLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.naamLbl = new System.Windows.Forms.Label();
            this.invoerGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // personenLb
            // 
            this.personenLb.FormattingEnabled = true;
            this.personenLb.ItemHeight = 22;
            this.personenLb.Location = new System.Drawing.Point(17, 35);
            this.personenLb.Margin = new System.Windows.Forms.Padding(4);
            this.personenLb.Name = "personenLb";
            this.personenLb.ScrollAlwaysVisible = true;
            this.personenLb.Size = new System.Drawing.Size(643, 334);
            this.personenLb.TabIndex = 0;
            // 
            // naamTb
            // 
            this.naamTb.Location = new System.Drawing.Point(127, 45);
            this.naamTb.Margin = new System.Windows.Forms.Padding(4);
            this.naamTb.Name = "naamTb";
            this.naamTb.Size = new System.Drawing.Size(492, 29);
            this.naamTb.TabIndex = 1;
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(127, 91);
            this.idTb.Margin = new System.Windows.Forms.Padding(4);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(492, 29);
            this.idTb.TabIndex = 2;
            this.idTb.TextChanged += new System.EventHandler(this.idTb_TextChanged);
            // 
            // leeftijdTb
            // 
            this.leeftijdTb.Location = new System.Drawing.Point(127, 137);
            this.leeftijdTb.Margin = new System.Windows.Forms.Padding(4);
            this.leeftijdTb.Name = "leeftijdTb";
            this.leeftijdTb.Size = new System.Drawing.Size(492, 29);
            this.leeftijdTb.TabIndex = 3;
            this.leeftijdTb.TextChanged += new System.EventHandler(this.leeftijdTb_TextChanged);
            // 
            // invoerGb
            // 
            this.invoerGb.Controls.Add(this.wisVeldenBtn);
            this.invoerGb.Controls.Add(this.voegToeBtn);
            this.invoerGb.Controls.Add(this.leeftijdLbl);
            this.invoerGb.Controls.Add(this.idLbl);
            this.invoerGb.Controls.Add(this.naamLbl);
            this.invoerGb.Controls.Add(this.leeftijdTb);
            this.invoerGb.Controls.Add(this.naamTb);
            this.invoerGb.Controls.Add(this.idTb);
            this.invoerGb.Location = new System.Drawing.Point(17, 387);
            this.invoerGb.Margin = new System.Windows.Forms.Padding(4);
            this.invoerGb.Name = "invoerGb";
            this.invoerGb.Padding = new System.Windows.Forms.Padding(4);
            this.invoerGb.Size = new System.Drawing.Size(643, 262);
            this.invoerGb.TabIndex = 4;
            this.invoerGb.TabStop = false;
            this.invoerGb.Text = "Invoer persoonsgegevens";
            // 
            // wisVeldenBtn
            // 
            this.wisVeldenBtn.Location = new System.Drawing.Point(455, 203);
            this.wisVeldenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.wisVeldenBtn.Name = "wisVeldenBtn";
            this.wisVeldenBtn.Size = new System.Drawing.Size(180, 32);
            this.wisVeldenBtn.TabIndex = 8;
            this.wisVeldenBtn.Text = "Wis velden";
            this.wisVeldenBtn.UseVisualStyleBackColor = true;
            // 
            // voegToeBtn
            // 
            this.voegToeBtn.Location = new System.Drawing.Point(79, 203);
            this.voegToeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.voegToeBtn.Name = "voegToeBtn";
            this.voegToeBtn.Size = new System.Drawing.Size(180, 32);
            this.voegToeBtn.TabIndex = 7;
            this.voegToeBtn.Text = "Voeg record toe";
            this.voegToeBtn.UseVisualStyleBackColor = true;
            this.voegToeBtn.Click += new System.EventHandler(this.voegToeBtn_Click);
            // 
            // leeftijdLbl
            // 
            this.leeftijdLbl.AutoSize = true;
            this.leeftijdLbl.Location = new System.Drawing.Point(29, 141);
            this.leeftijdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leeftijdLbl.Name = "leeftijdLbl";
            this.leeftijdLbl.Size = new System.Drawing.Size(77, 22);
            this.leeftijdLbl.TabIndex = 6;
            this.leeftijdLbl.Text = "Leeftijd";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(29, 94);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(32, 22);
            this.idLbl.TabIndex = 5;
            this.idLbl.Text = "ID";
            // 
            // naamLbl
            // 
            this.naamLbl.AutoSize = true;
            this.naamLbl.Location = new System.Drawing.Point(29, 49);
            this.naamLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.naamLbl.Name = "naamLbl";
            this.naamLbl.Size = new System.Drawing.Size(63, 22);
            this.naamLbl.TabIndex = 4;
            this.naamLbl.Text = "Naam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 662);
            this.Controls.Add(this.invoerGb);
            this.Controls.Add(this.personenLb);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Persoonsbeheer";
            this.invoerGb.ResumeLayout(false);
            this.invoerGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox personenLb;
        private TextBox naamTb;
        private TextBox idTb;
        private TextBox leeftijdTb;
        private GroupBox invoerGb;
        private Label leeftijdLbl;
        private Label idLbl;
        private Label naamLbl;
        private Button wisVeldenBtn;
        private Button voegToeBtn;
    }
}