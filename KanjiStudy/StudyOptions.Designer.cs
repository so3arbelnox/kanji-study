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
            this.nm_amount = new System.Windows.Forms.NumericUpDown();
            this.nm_end = new System.Windows.Forms.NumericUpDown();
            this.nm_start = new System.Windows.Forms.NumericUpDown();
            this.btn_go = new System.Windows.Forms.Button();
            this.rbtn_range = new System.Windows.Forms.RadioButton();
            this.rbtn_amount = new System.Windows.Forms.RadioButton();
            this.rbtn_all_random = new System.Windows.Forms.RadioButton();
            this.grp_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_start)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_box
            // 
            this.grp_box.Controls.Add(this.nm_amount);
            this.grp_box.Controls.Add(this.nm_end);
            this.grp_box.Controls.Add(this.nm_start);
            this.grp_box.Controls.Add(this.btn_go);
            this.grp_box.Controls.Add(this.rbtn_range);
            this.grp_box.Controls.Add(this.rbtn_amount);
            this.grp_box.Controls.Add(this.rbtn_all_random);
            this.grp_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_box.Location = new System.Drawing.Point(3, 3);
            this.grp_box.Name = "grp_box";
            this.grp_box.Size = new System.Drawing.Size(286, 383);
            this.grp_box.TabIndex = 0;
            this.grp_box.TabStop = false;
            this.grp_box.Text = "Study Options";
            this.grp_box.Enter += new System.EventHandler(this.grp_box_Enter);
            // 
            // nm_amount
            // 
            this.nm_amount.Enabled = false;
            this.nm_amount.Location = new System.Drawing.Point(151, 72);
            this.nm_amount.Maximum = new decimal(new int[] {
            9999999,
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
            this.nm_end.Location = new System.Drawing.Point(19, 166);
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
            this.nm_start.Location = new System.Drawing.Point(19, 134);
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
            // rbtn_range
            // 
            this.rbtn_range.AutoSize = true;
            this.rbtn_range.Location = new System.Drawing.Point(19, 104);
            this.rbtn_range.Name = "rbtn_range";
            this.rbtn_range.Size = new System.Drawing.Size(181, 24);
            this.rbtn_range.TabIndex = 2;
            this.rbtn_range.TabStop = true;
            this.rbtn_range.Text = "Study Range (Card #)";
            this.rbtn_range.UseVisualStyleBackColor = true;
            this.rbtn_range.CheckedChanged += new System.EventHandler(this.rbtn_range_CheckedChanged);
            // 
            // rbtn_amount
            // 
            this.rbtn_amount.AutoSize = true;
            this.rbtn_amount.Location = new System.Drawing.Point(19, 72);
            this.rbtn_amount.Name = "rbtn_amount";
            this.rbtn_amount.Size = new System.Drawing.Size(128, 24);
            this.rbtn_amount.TabIndex = 1;
            this.rbtn_amount.TabStop = true;
            this.rbtn_amount.Text = "Study Amount";
            this.rbtn_amount.UseVisualStyleBackColor = true;
            this.rbtn_amount.CheckedChanged += new System.EventHandler(this.rbtn_amount_CheckedChanged);
            // 
            // rbtn_all_random
            // 
            this.rbtn_all_random.AutoSize = true;
            this.rbtn_all_random.Location = new System.Drawing.Point(19, 40);
            this.rbtn_all_random.Name = "rbtn_all_random";
            this.rbtn_all_random.Size = new System.Drawing.Size(89, 24);
            this.rbtn_all_random.TabIndex = 0;
            this.rbtn_all_random.TabStop = true;
            this.rbtn_all_random.Text = "Study All";
            this.rbtn_all_random.UseVisualStyleBackColor = true;
            this.rbtn_all_random.CheckedChanged += new System.EventHandler(this.rbtn_all_random_CheckedChanged);
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
        private System.Windows.Forms.RadioButton rbtn_range;
        private System.Windows.Forms.RadioButton rbtn_amount;
        private System.Windows.Forms.RadioButton rbtn_all_random;
        private System.Windows.Forms.NumericUpDown nm_end;
        private System.Windows.Forms.NumericUpDown nm_start;
        private System.Windows.Forms.NumericUpDown nm_amount;
    }
}
