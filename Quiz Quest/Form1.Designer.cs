namespace Quiz_Quest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.picQuizQuest = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.butCont = new System.Windows.Forms.Button();
            this.txtNumOfQuest = new System.Windows.Forms.TextBox();
            this.lblQuest = new System.Windows.Forms.Label();
            this.cmbLvlOfQuest = new System.Windows.Forms.ComboBox();
            this.lbllvl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQuizQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(428, 229);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 22);
            this.txtName.TabIndex = 0;
            // 
            // picQuizQuest
            // 
            this.picQuizQuest.BackColor = System.Drawing.Color.Transparent;
            this.picQuizQuest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picQuizQuest.BackgroundImage")));
            this.picQuizQuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQuizQuest.Location = new System.Drawing.Point(401, 15);
            this.picQuizQuest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picQuizQuest.Name = "picQuizQuest";
            this.picQuizQuest.Size = new System.Drawing.Size(275, 132);
            this.picQuizQuest.TabIndex = 1;
            this.picQuizQuest.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(484, 190);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 36);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // butCont
            // 
            this.butCont.BackColor = System.Drawing.Color.White;
            this.butCont.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCont.Location = new System.Drawing.Point(473, 460);
            this.butCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCont.Name = "butCont";
            this.butCont.Size = new System.Drawing.Size(137, 62);
            this.butCont.TabIndex = 3;
            this.butCont.Text = "Continue to quiz";
            this.butCont.UseVisualStyleBackColor = false;
            this.butCont.Click += new System.EventHandler(this.butCont_Click);
            // 
            // txtNumOfQuest
            // 
            this.txtNumOfQuest.Location = new System.Drawing.Point(428, 313);
            this.txtNumOfQuest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumOfQuest.Name = "txtNumOfQuest";
            this.txtNumOfQuest.Size = new System.Drawing.Size(220, 22);
            this.txtNumOfQuest.TabIndex = 4;
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.BackColor = System.Drawing.Color.Transparent;
            this.lblQuest.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuest.ForeColor = System.Drawing.Color.White;
            this.lblQuest.Location = new System.Drawing.Point(381, 272);
            this.lblQuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(309, 36);
            this.lblQuest.TabIndex = 7;
            this.lblQuest.Text = "Number of Questions:";
            // 
            // cmbLvlOfQuest
            // 
            this.cmbLvlOfQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLvlOfQuest.FormattingEnabled = true;
            this.cmbLvlOfQuest.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbLvlOfQuest.Location = new System.Drawing.Point(428, 399);
            this.cmbLvlOfQuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLvlOfQuest.Name = "cmbLvlOfQuest";
            this.cmbLvlOfQuest.Size = new System.Drawing.Size(220, 24);
            this.cmbLvlOfQuest.TabIndex = 9;
            // 
            // lbllvl
            // 
            this.lbllvl.AutoSize = true;
            this.lbllvl.BackColor = System.Drawing.Color.Transparent;
            this.lbllvl.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllvl.ForeColor = System.Drawing.Color.White;
            this.lbllvl.Location = new System.Drawing.Point(395, 359);
            this.lbllvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllvl.Name = "lbllvl";
            this.lbllvl.Size = new System.Drawing.Size(272, 36);
            this.lbllvl.TabIndex = 10;
            this.lbllvl.Text = "Level of Questions:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbllvl);
            this.Controls.Add(this.cmbLvlOfQuest);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.txtNumOfQuest);
            this.Controls.Add(this.butCont);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picQuizQuest);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Quiz Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuizQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picQuizQuest;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button butCont;
        private System.Windows.Forms.TextBox txtNumOfQuest;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.ComboBox cmbLvlOfQuest;
        private System.Windows.Forms.Label lbllvl;
    }
}

