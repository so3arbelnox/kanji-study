namespace KanjiApp
{
    partial class StudyOptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_box = new System.Windows.Forms.GroupBox();
            this.chkBoxReverseCard = new System.Windows.Forms.CheckBox();
            this.chkBoxAmount = new System.Windows.Forms.CheckBox();
            this.chkBoxFromRange = new System.Windows.Forms.CheckBox();
            this.nm_amount = new System.Windows.Forms.NumericUpDown();
            this.nm_end = new System.Windows.Forms.NumericUpDown();
            this.nm_start = new System.Windows.Forms.NumericUpDown();
            this.btn_go = new System.Windows.Forms.Button();
            this.chkBoxHideHiragana = new System.Windows.Forms.CheckBox();
            this.grp_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_start)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_box
            // 
            this.grp_box.Controls.Add(this.chkBoxHideHiragana);
            this.grp_box.Controls.Add(this.chkBoxReverseCard);
            this.grp_box.Controls.Add(this.chkBoxAmount);
            this.grp_box.Controls.Add(this.chkBoxFromRange);
            this.grp_box.Controls.Add(this.nm_amount);
            this.grp_box.Controls.Add(this.nm_end);
            this.grp_box.Controls.Add(this.nm_start);
            this.grp_box.Controls.Add(this.btn_go);
            this.grp_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_box.Location = new System.Drawing.Point(3, 3);
            this.grp_box.Name = "grp_box";
            this.grp_box.Size = new System.Drawing.Size(286, 383);
            this.grp_box.TabIndex = 0;
            this.grp_box.TabStop = false;
            this.grp_box.Text = "Study Options";
            this.grp_box.Enter += new System.EventHandler(this.grp_box_Enter);
            // 
            // chkBoxReverseCard
            // 
            this.chkBoxReverseCard.AutoSize = true;
            this.chkBoxReverseCard.Location = new System.Drawing.Point(19, 133);
            this.chkBoxReverseCard.Name = "chkBoxReverseCard";
            this.chkBoxReverseCard.Size = new System.Drawing.Size(159, 24);
            this.chkBoxReverseCard.TabIndex = 11;
            this.chkBoxReverseCard.Text = "Flip front and back";
            this.chkBoxReverseCard.UseVisualStyleBackColor = true;
            this.chkBoxReverseCard.CheckedChanged += new System.EventHandler(this.chkBoxReverseCard_CheckedChanged);
            // 
            // chkBoxAmount
            // 
            this.chkBoxAmount.AutoSize = true;
            this.chkBoxAmount.Location = new System.Drawing.Point(19, 35);
            this.chkBoxAmount.Name = "chkBoxAmount";
            this.chkBoxAmount.Size = new System.Drawing.Size(119, 24);
            this.chkBoxAmount.TabIndex = 10;
            this.chkBoxAmount.Text = "Limit amount";
            this.chkBoxAmount.UseVisualStyleBackColor = true;
            this.chkBoxAmount.CheckedChanged += new System.EventHandler(this.chkBoxAmount_CheckedChanged);
            // 
            // chkBoxFromRange
            // 
            this.chkBoxFromRange.AutoSize = true;
            this.chkBoxFromRange.Location = new System.Drawing.Point(19, 65);
            this.chkBoxFromRange.Name = "chkBoxFromRange";
            this.chkBoxFromRange.Size = new System.Drawing.Size(171, 24);
            this.chkBoxFromRange.TabIndex = 9;
            this.chkBoxFromRange.Text = "From range (Card #)";
            this.chkBoxFromRange.UseVisualStyleBackColor = true;
            this.chkBoxFromRange.CheckedChanged += new System.EventHandler(this.chkBoxFromRange_CheckedChanged);
            // 
            // nm_amount
            // 
            this.nm_amount.Enabled = false;
            this.nm_amount.Location = new System.Drawing.Point(146, 33);
            this.nm_amount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nm_amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_amount.Name = "nm_amount";
            this.nm_amount.Size = new System.Drawing.Size(120, 26);
            this.nm_amount.TabIndex = 8;
            this.nm_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nm_end
            // 
            this.nm_end.Enabled = false;
            this.nm_end.Location = new System.Drawing.Point(146, 95);
            this.nm_end.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nm_end.Name = "nm_end";
            this.nm_end.Size = new System.Drawing.Size(120, 26);
            this.nm_end.TabIndex = 7;
            // 
            // nm_start
            // 
            this.nm_start.Enabled = false;
            this.nm_start.Location = new System.Drawing.Point(19, 95);
            this.nm_start.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nm_start.Name = "nm_start";
            this.nm_start.Size = new System.Drawing.Size(120, 26);
            this.nm_start.TabIndex = 6;
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(49, 308);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(165, 49);
            this.btn_go.TabIndex = 5;
            this.btn_go.Text = "GO!";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // chkBoxHideHiragana
            // 
            this.chkBoxHideHiragana.AutoSize = true;
            this.chkBoxHideHiragana.Location = new System.Drawing.Point(19, 163);
            this.chkBoxHideHiragana.Name = "chkBoxHideHiragana";
            this.chkBoxHideHiragana.Size = new System.Drawing.Size(127, 24);
            this.chkBoxHideHiragana.TabIndex = 12;
            this.chkBoxHideHiragana.Text = "Hide hiragana";
            this.chkBoxHideHiragana.UseVisualStyleBackColor = true;
            // 
            // StudyOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp_box);
            this.Name = "StudyOptions";
            this.Size = new System.Drawing.Size(298, 394);
            this.grp_box.ResumeLayout(false);
            this.grp_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_box;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.NumericUpDown nm_end;
        private System.Windows.Forms.NumericUpDown nm_start;
        private System.Windows.Forms.NumericUpDown nm_amount;
        private System.Windows.Forms.CheckBox chkBoxFromRange;
        private System.Windows.Forms.CheckBox chkBoxAmount;
        private System.Windows.Forms.CheckBox chkBoxReverseCard;
        private System.Windows.Forms.CheckBox chkBoxHideHiragana;
    }
}
