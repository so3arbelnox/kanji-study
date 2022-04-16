namespace KanjiApp
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_load_deck = new System.Windows.Forms.Button();
            this.btn_study_cards = new System.Windows.Forms.Button();
            this.lw_kanji = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_entry_count = new System.Windows.Forms.Label();
            this.lbl_deck_title = new System.Windows.Forms.Label();
            this.btn_add_card = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lbl_card_count = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_load_deck
            // 
            this.btn_load_deck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_deck.Location = new System.Drawing.Point(25, 73);
            this.btn_load_deck.Name = "btn_load_deck";
            this.btn_load_deck.Size = new System.Drawing.Size(153, 63);
            this.btn_load_deck.TabIndex = 0;
            this.btn_load_deck.Text = "Load Deck";
            this.btn_load_deck.UseVisualStyleBackColor = true;
            this.btn_load_deck.Click += new System.EventHandler(this.btn_load_deck_Click);
            // 
            // btn_study_cards
            // 
            this.btn_study_cards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_study_cards.Location = new System.Drawing.Point(375, 73);
            this.btn_study_cards.Name = "btn_study_cards";
            this.btn_study_cards.Size = new System.Drawing.Size(153, 63);
            this.btn_study_cards.TabIndex = 1;
            this.btn_study_cards.Text = "Study Cards";
            this.btn_study_cards.UseVisualStyleBackColor = true;
            this.btn_study_cards.Click += new System.EventHandler(this.btn_study_cards_Click);
            // 
            // lw_kanji
            // 
            this.lw_kanji.ContextMenuStrip = this.contextMenuStrip1;
            this.lw_kanji.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lw_kanji.HideSelection = false;
            this.lw_kanji.Location = new System.Drawing.Point(25, 171);
            this.lw_kanji.MaximumSize = new System.Drawing.Size(1194, 677);
            this.lw_kanji.MultiSelect = false;
            this.lw_kanji.Name = "lw_kanji";
            this.lw_kanji.ShowItemToolTips = true;
            this.lw_kanji.Size = new System.Drawing.Size(1167, 626);
            this.lw_kanji.TabIndex = 2;
            this.lw_kanji.UseCompatibleStateImageBehavior = false;
            this.lw_kanji.View = System.Windows.Forms.View.Tile;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // editCardToolStripMenuItem
            // 
            this.editCardToolStripMenuItem.Name = "editCardToolStripMenuItem";
            this.editCardToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.editCardToolStripMenuItem.Text = "Edit Card";
            // 
            // lbl_entry_count
            // 
            this.lbl_entry_count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_entry_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entry_count.Location = new System.Drawing.Point(1070, 58);
            this.lbl_entry_count.Name = "lbl_entry_count";
            this.lbl_entry_count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_entry_count.Size = new System.Drawing.Size(122, 24);
            this.lbl_entry_count.TabIndex = 3;
            this.lbl_entry_count.Text = "Entries: 0";
            this.lbl_entry_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_deck_title
            // 
            this.lbl_deck_title.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_deck_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deck_title.Location = new System.Drawing.Point(920, 25);
            this.lbl_deck_title.Name = "lbl_deck_title";
            this.lbl_deck_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_deck_title.Size = new System.Drawing.Size(272, 24);
            this.lbl_deck_title.TabIndex = 4;
            this.lbl_deck_title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_add_card
            // 
            this.btn_add_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_card.Location = new System.Drawing.Point(201, 73);
            this.btn_add_card.Name = "btn_add_card";
            this.btn_add_card.Size = new System.Drawing.Size(153, 63);
            this.btn_add_card.TabIndex = 5;
            this.btn_add_card.Text = "Add Card";
            this.btn_add_card.UseVisualStyleBackColor = true;
            this.btn_add_card.Click += new System.EventHandler(this.btn_add_card_Click);
            // 
            // cbSize
            // 
            this.cbSize.BackColor = System.Drawing.SystemColors.Window;
            this.cbSize.DisplayMember = "Small";
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbSize.Location = new System.Drawing.Point(1053, 123);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(139, 32);
            this.cbSize.TabIndex = 6;
            this.cbSize.ValueMember = "Small";
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // lbl_card_count
            // 
            this.lbl_card_count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_card_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card_count.Location = new System.Drawing.Point(1070, 91);
            this.lbl_card_count.Name = "lbl_card_count";
            this.lbl_card_count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_card_count.Size = new System.Drawing.Size(122, 24);
            this.lbl_card_count.TabIndex = 7;
            this.lbl_card_count.Text = "Cards: 0";
            this.lbl_card_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 809);
            this.Controls.Add(this.lbl_card_count);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.btn_add_card);
            this.Controls.Add(this.lbl_deck_title);
            this.Controls.Add(this.lbl_entry_count);
            this.Controls.Add(this.lw_kanji);
            this.Controls.Add(this.btn_study_cards);
            this.Controls.Add(this.btn_load_deck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Kanji App";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load_deck;
        private System.Windows.Forms.Button btn_study_cards;
        private System.Windows.Forms.ListView lw_kanji;
        private System.Windows.Forms.Label lbl_entry_count;
        private System.Windows.Forms.Label lbl_deck_title;
        private System.Windows.Forms.Button btn_add_card;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editCardToolStripMenuItem;
        private System.Windows.Forms.Label lbl_card_count;
    }
}

