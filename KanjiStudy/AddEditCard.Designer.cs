namespace KanjiApp
{
    partial class frm_addeditcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addeditcard));
            this.txtCardFront = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardBack = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_card = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.nm_id = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nm_id)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCardFront
            // 
            this.txtCardFront.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardFront.Location = new System.Drawing.Point(12, 58);
            this.txtCardFront.Name = "txtCardFront";
            this.txtCardFront.Size = new System.Drawing.Size(615, 114);
            this.txtCardFront.TabIndex = 0;
            this.txtCardFront.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Front";
            // 
            // txtCardBack
            // 
            this.txtCardBack.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardBack.Location = new System.Drawing.Point(12, 232);
            this.txtCardBack.Name = "txtCardBack";
            this.txtCardBack.Size = new System.Drawing.Size(615, 114);
            this.txtCardBack.TabIndex = 2;
            this.txtCardBack.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card Back";
            // 
            // btn_add_card
            // 
            this.btn_add_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_card.Location = new System.Drawing.Point(221, 375);
            this.btn_add_card.Name = "btn_add_card";
            this.btn_add_card.Size = new System.Drawing.Size(153, 63);
            this.btn_add_card.TabIndex = 6;
            this.btn_add_card.Text = "Add New Card";
            this.btn_add_card.UseVisualStyleBackColor = true;
            this.btn_add_card.Click += new System.EventHandler(this.btn_add_card_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(513, 351);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 20);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "ID";
            // 
            // nm_id
            // 
            this.nm_id.Location = new System.Drawing.Point(546, 352);
            this.nm_id.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nm_id.Name = "nm_id";
            this.nm_id.Size = new System.Drawing.Size(81, 20);
            this.nm_id.TabIndex = 9;
            // 
            // frm_addeditcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.nm_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_add_card);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardFront);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_addeditcard";
            this.ShowIcon = false;
            this.Text = "Deck Management - Add";
            ((System.ComponentModel.ISupportInitialize)(this.nm_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCardFront;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtCardBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_card;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.NumericUpDown nm_id;
    }
}