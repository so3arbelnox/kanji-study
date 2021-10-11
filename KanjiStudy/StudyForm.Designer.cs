namespace KanjiApp
{
    partial class StudyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyForm));
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_fail = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_kanji = new System.Windows.Forms.Label();
            this.lbl_card_progress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(378, 511);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(125, 71);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "OK";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_fail
            // 
            this.btn_fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fail.Location = new System.Drawing.Point(149, 511);
            this.btn_fail.Name = "btn_fail";
            this.btn_fail.Size = new System.Drawing.Size(142, 71);
            this.btn_fail.TabIndex = 1;
            this.btn_fail.Text = "Again";
            this.btn_fail.UseVisualStyleBackColor = true;
            this.btn_fail.Click += new System.EventHandler(this.btn_fail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 462);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_kanji
            // 
            this.lbl_kanji.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kanji.Font = new System.Drawing.Font("Yu Gothic UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kanji.Location = new System.Drawing.Point(45, 168);
            this.lbl_kanji.Name = "lbl_kanji";
            this.lbl_kanji.Size = new System.Drawing.Size(579, 128);
            this.lbl_kanji.TabIndex = 3;
            this.lbl_kanji.Text = "忘れ物";
            this.lbl_kanji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_card_progress
            // 
            this.lbl_card_progress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_card_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card_progress.Location = new System.Drawing.Point(535, 613);
            this.lbl_card_progress.Name = "lbl_card_progress";
            this.lbl_card_progress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_card_progress.Size = new System.Drawing.Size(122, 24);
            this.lbl_card_progress.TabIndex = 4;
            this.lbl_card_progress.Text = "1/1";
            this.lbl_card_progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 646);
            this.Controls.Add(this.lbl_card_progress);
            this.Controls.Add(this.lbl_kanji);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_fail);
            this.Controls.Add(this.btn_next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s Study!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_fail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_kanji;
        private System.Windows.Forms.Label lbl_card_progress;
    }
}