namespace Quiz_Quest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picQuizQuest = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.butNxt = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.lblSmbl = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.btnShwReslts = new System.Windows.Forms.Button();
            this.lblDispMark = new System.Windows.Forms.Label();
            this.lblQuest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQuizQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // picQuizQuest
            // 
            this.picQuizQuest.BackColor = System.Drawing.Color.Transparent;
            this.picQuizQuest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picQuizQuest.BackgroundImage")));
            this.picQuizQuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQuizQuest.Location = new System.Drawing.Point(294, 12);
            this.picQuizQuest.Name = "picQuizQuest";
            this.picQuizQuest.Size = new System.Drawing.Size(206, 107);
            this.picQuizQuest.TabIndex = 2;
            this.picQuizQuest.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // butNxt
            // 
            this.butNxt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNxt.Location = new System.Drawing.Point(345, 345);
            this.butNxt.Name = "butNxt";
            this.butNxt.Size = new System.Drawing.Size(99, 66);
            this.butNxt.TabIndex = 6;
            this.butNxt.Text = "Next Question";
            this.butNxt.UseVisualStyleBackColor = true;
            this.butNxt.Click += new System.EventHandler(this.butNxt_Click);
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.Location = new System.Drawing.Point(531, 206);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(87, 84);
            this.txtAns.TabIndex = 7;
            // 
            // lblSmbl
            // 
            this.lblSmbl.AutoSize = true;
            this.lblSmbl.BackColor = System.Drawing.Color.Transparent;
            this.lblSmbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmbl.ForeColor = System.Drawing.Color.White;
            this.lblSmbl.Location = new System.Drawing.Point(260, 185);
            this.lblSmbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSmbl.Name = "lblSmbl";
            this.lblSmbl.Size = new System.Drawing.Size(90, 115);
            this.lblSmbl.TabIndex = 8;
            this.lblSmbl.Text = "+";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.White;
            this.lblNum2.Location = new System.Drawing.Point(347, 208);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(94, 77);
            this.lblNum2.TabIndex = 9;
            this.lblNum2.Text = "00";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.White;
            this.lblNum1.Location = new System.Drawing.Point(164, 208);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(94, 77);
            this.lblNum1.TabIndex = 10;
            this.lblNum1.Text = "00";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.BackColor = System.Drawing.Color.Transparent;
            this.lblEqual.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.ForeColor = System.Drawing.Color.White;
            this.lblEqual.Location = new System.Drawing.Point(448, 185);
            this.lblEqual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(84, 115);
            this.lblEqual.TabIndex = 11;
            this.lblEqual.Text = "=";
            // 
            // btnShwReslts
            // 
            this.btnShwReslts.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShwReslts.Location = new System.Drawing.Point(345, 345);
            this.btnShwReslts.Name = "btnShwReslts";
            this.btnShwReslts.Size = new System.Drawing.Size(99, 66);
            this.btnShwReslts.TabIndex = 13;
            this.btnShwReslts.Text = "Show Results";
            this.btnShwReslts.UseVisualStyleBackColor = true;
            this.btnShwReslts.Click += new System.EventHandler(this.btnPrntReslts_Click);
            // 
            // lblDispMark
            // 
            this.lblDispMark.AutoSize = true;
            this.lblDispMark.BackColor = System.Drawing.Color.Transparent;
            this.lblDispMark.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispMark.ForeColor = System.Drawing.Color.White;
            this.lblDispMark.Location = new System.Drawing.Point(502, 158);
            this.lblDispMark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDispMark.Name = "lblDispMark";
            this.lblDispMark.Size = new System.Drawing.Size(0, 25);
            this.lblDispMark.TabIndex = 14;
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.BackColor = System.Drawing.Color.Transparent;
            this.lblQuest.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuest.ForeColor = System.Drawing.Color.White;
            this.lblQuest.Location = new System.Drawing.Point(204, 158);
            this.lblQuest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(95, 25);
            this.lblQuest.TabIndex = 15;
            this.lblQuest.Text = "Question 1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.lblDispMark);
            this.Controls.Add(this.btnShwReslts);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblSmbl);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.butNxt);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picQuizQuest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Quiz Quest";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuizQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQuizQuest;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button butNxt;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label lblSmbl;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Button btnShwReslts;
        private System.Windows.Forms.Label lblDispMark;
        private System.Windows.Forms.Label lblQuest;
    }
}