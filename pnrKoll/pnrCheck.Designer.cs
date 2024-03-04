namespace pnrKoll
{
    partial class pnrCheck
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnrLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.pnrTxt = new System.Windows.Forms.TextBox();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.resultatBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clBtn = new System.Windows.Forms.Button();
            this.fnnamelabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnummer Verifikation";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // pnrLabel
            // 
            this.pnrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnrLabel.AutoSize = true;
            this.pnrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnrLabel.Location = new System.Drawing.Point(9, 85);
            this.pnrLabel.Name = "pnrLabel";
            this.pnrLabel.Size = new System.Drawing.Size(114, 16);
            this.pnrLabel.TabIndex = 2;
            this.pnrLabel.Text = "Personnummer:";
            // 
            // fnameLabel
            // 
            this.fnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(13, 165);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(80, 16);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "Efternamn:";
            // 
            // lnameLabel
            // 
            this.lnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(13, 118);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(0, 16);
            this.lnameLabel.TabIndex = 4;
            // 
            // pnrTxt
            // 
            this.pnrTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnrTxt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pnrTxt.Location = new System.Drawing.Point(133, 79);
            this.pnrTxt.Name = "pnrTxt";
            this.pnrTxt.Size = new System.Drawing.Size(586, 22);
            this.pnrTxt.TabIndex = 5;
            this.pnrTxt.Text = "(10 siffrig Pnr) XXXXXXXXXX";
            this.pnrTxt.TextChanged += new System.EventHandler(this.pnrTxt_TextChanged);
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameTxt.Location = new System.Drawing.Point(133, 118);
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(586, 22);
            this.firstnameTxt.TabIndex = 6;
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnameTxt.Location = new System.Drawing.Point(133, 159);
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(586, 22);
            this.lastnameTxt.TabIndex = 7;
            // 
            // checkBtn
            // 
            this.checkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBtn.Location = new System.Drawing.Point(3, 3);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(287, 50);
            this.checkBtn.TabIndex = 8;
            this.checkBtn.Text = "Kontrollera";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // resultatBox
            // 
            this.resultatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultatBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultatBox.Location = new System.Drawing.Point(133, 301);
            this.resultatBox.Name = "resultatBox";
            this.resultatBox.Size = new System.Drawing.Size(586, 167);
            this.resultatBox.TabIndex = 10;
            this.resultatBox.TabStop = false;
            this.resultatBox.Text = "Verifikation:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.clBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(133, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 56);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // clBtn
            // 
            this.clBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clBtn.Location = new System.Drawing.Point(296, 3);
            this.clBtn.Name = "clBtn";
            this.clBtn.Size = new System.Drawing.Size(287, 50);
            this.clBtn.TabIndex = 9;
            this.clBtn.Text = "Klar";
            this.clBtn.UseVisualStyleBackColor = true;
            this.clBtn.Click += new System.EventHandler(this.clBtn_Click);
            // 
            // fnnamelabel
            // 
            this.fnnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fnnamelabel.AutoSize = true;
            this.fnnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnnamelabel.Location = new System.Drawing.Point(10, 124);
            this.fnnamelabel.Name = "fnnamelabel";
            this.fnnamelabel.Size = new System.Drawing.Size(67, 16);
            this.fnnamelabel.TabIndex = 12;
            this.fnnamelabel.Text = "Förnamn";
            // 
            // pnrCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 468);
            this.Controls.Add(this.fnnamelabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resultatBox);
            this.Controls.Add(this.lastnameTxt);
            this.Controls.Add(this.firstnameTxt);
            this.Controls.Add(this.pnrTxt);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.pnrLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pnrCheck";
            this.Text = "Pnr Kontroll";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pnrLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.TextBox pnrTxt;
        private System.Windows.Forms.TextBox firstnameTxt;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.GroupBox resultatBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button clBtn;
        private System.Windows.Forms.Label fnnamelabel;
    }
}

