namespace TestWFA
{
    partial class LibForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.genres = new System.Windows.Forms.CheckedListBox();
            this.card = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblReader = new System.Windows.Forms.Label();
            this.inLibrary = new System.Windows.Forms.CheckBox();
            this.dateout = new System.Windows.Forms.MaskedTextBox();
            this.datein = new System.Windows.Forms.MaskedTextBox();
            this.lblDateout = new System.Windows.Forms.Label();
            this.lblDatein = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewCard = new System.Windows.Forms.Button();
            this.PrevNextFindContainer = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.srchbtn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ratingLB = new System.Windows.Forms.CheckedListBox();
            this.readmen = new System.Windows.Forms.TextBox();
            this.ratLabel = new System.Windows.Forms.Label();
            this.PrevNextFindContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // genres
            // 
            this.genres.CheckOnClick = true;
            this.genres.FormattingEnabled = true;
            this.genres.Items.AddRange(new object[] {
            "детектив",
            "исторический роман",
            "современные роман/повесть/семейная сага",
            "сборник рассказов/собрание сочинений",
            "приключения",
            "фантастика",
            "классический роман",
            "фэнтези",
            "естественно-научный нонфикшн",
            "детская литература",
            "гуманитарный нонфикшн",
            "биография/автобиография",
            "триллер/хоррор",
            "путевые заметки",
            "мистика/магический реализм"});
            this.genres.Location = new System.Drawing.Point(289, 221);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(411, 229);
            this.genres.TabIndex = 9;
            // 
            // card
            // 
            this.card.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card.Location = new System.Drawing.Point(72, 26);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(66, 20);
            this.card.TabIndex = 1;
            this.card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.card_KeyPress);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(12, 33);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(54, 13);
            this.lblCard.TabIndex = 3;
            this.lblCard.Text = "Карточка";
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(289, 26);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(417, 20);
            this.author.TabIndex = 2;
            this.author.Tag = "Автор";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(246, 33);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(37, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Автор";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(226, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Название";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(289, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(417, 20);
            this.title.TabIndex = 3;
            this.title.Tag = "Название";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(289, 79);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(184, 20);
            this.ISBN.TabIndex = 4;
            this.ISBN.Tag = "ISBN";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(226, 86);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(54, 13);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "Код ISBN";
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Location = new System.Drawing.Point(225, 114);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(55, 13);
            this.lblReader.TabIndex = 10;
            this.lblReader.Text = "Читатель";
            // 
            // inLibrary
            // 
            this.inLibrary.AutoSize = true;
            this.inLibrary.Location = new System.Drawing.Point(289, 133);
            this.inLibrary.Name = "inLibrary";
            this.inLibrary.Size = new System.Drawing.Size(95, 17);
            this.inLibrary.TabIndex = 6;
            this.inLibrary.Text = "В библиотеке";
            this.inLibrary.UseVisualStyleBackColor = true;
            // 
            // dateout
            // 
            this.dateout.Location = new System.Drawing.Point(289, 156);
            this.dateout.Mask = "00/00/0000";
            this.dateout.Name = "dateout";
            this.dateout.Size = new System.Drawing.Size(67, 20);
            this.dateout.TabIndex = 7;
            this.dateout.ValidatingType = typeof(System.DateTime);
            // 
            // datein
            // 
            this.datein.Location = new System.Drawing.Point(479, 156);
            this.datein.Mask = "00/00/0000";
            this.datein.Name = "datein";
            this.datein.Size = new System.Drawing.Size(65, 20);
            this.datein.TabIndex = 8;
            this.datein.ValidatingType = typeof(System.DateTime);
            // 
            // lblDateout
            // 
            this.lblDateout.AutoSize = true;
            this.lblDateout.Location = new System.Drawing.Point(206, 162);
            this.lblDateout.Name = "lblDateout";
            this.lblDateout.Size = new System.Drawing.Size(73, 13);
            this.lblDateout.TabIndex = 15;
            this.lblDateout.Text = "Дата выдачи";
            // 
            // lblDatein
            // 
            this.lblDatein.AutoSize = true;
            this.lblDatein.Location = new System.Drawing.Point(390, 163);
            this.lblDatein.Name = "lblDatein";
            this.lblDatein.Size = new System.Drawing.Size(83, 13);
            this.lblDatein.TabIndex = 16;
            this.lblDatein.Text = "Дата возврата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Жанры";
            // 
            // NewCard
            // 
            this.NewCard.Location = new System.Drawing.Point(12, 467);
            this.NewCard.Name = "NewCard";
            this.NewCard.Size = new System.Drawing.Size(75, 42);
            this.NewCard.TabIndex = 20;
            this.NewCard.Text = "Новая карточка";
            this.NewCard.UseVisualStyleBackColor = true;
            this.NewCard.Click += new System.EventHandler(this.elementClear);
            // 
            // PrevNextFindContainer
            // 
            this.PrevNextFindContainer.Controls.Add(this.Save);
            this.PrevNextFindContainer.Controls.Add(this.srchbtn);
            this.PrevNextFindContainer.Controls.Add(this.search);
            this.PrevNextFindContainer.Controls.Add(this.Next);
            this.PrevNextFindContainer.Controls.Add(this.Prev);
            this.PrevNextFindContainer.Location = new System.Drawing.Point(249, 456);
            this.PrevNextFindContainer.Name = "PrevNextFindContainer";
            this.PrevNextFindContainer.Size = new System.Drawing.Size(457, 53);
            this.PrevNextFindContainer.TabIndex = 10;
            this.PrevNextFindContainer.TabStop = false;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(6, 22);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(83, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.saveCard);
            // 
            // srchbtn
            // 
            this.srchbtn.Location = new System.Drawing.Point(376, 21);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(75, 23);
            this.srchbtn.TabIndex = 3;
            this.srchbtn.Text = "Поиск";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.searchCard);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(310, 23);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(60, 20);
            this.search.TabIndex = 2;
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(208, 22);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = ">>>";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Prev
            // 
            this.Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prev.Location = new System.Drawing.Point(127, 22);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(75, 23);
            this.Prev.TabIndex = 0;
            this.Prev.Text = "<<<";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 22);
            this.statusStrip1.TabIndex = 22;
            // 
            // TSSLabel1
            // 
            this.TSSLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSSLabel1.Name = "TSSLabel1";
            this.TSSLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ratingLB
            // 
            this.ratingLB.FormattingEnabled = true;
            this.ratingLB.Items.AddRange(new object[] {
            "Очень плохой",
            "Плохой",
            "Средний",
            "Хороший",
            "Отличный"});
            this.ratingLB.Location = new System.Drawing.Point(15, 79);
            this.ratingLB.Name = "ratingLB";
            this.ratingLB.Size = new System.Drawing.Size(155, 94);
            this.ratingLB.TabIndex = 25;
            this.ratingLB.SelectedIndexChanged += new System.EventHandler(this.ratingLB_SelectedIndexChanged);
            // 
            // readmen
            // 
            this.readmen.Location = new System.Drawing.Point(289, 106);
            this.readmen.Name = "readmen";
            this.readmen.Size = new System.Drawing.Size(344, 20);
            this.readmen.TabIndex = 26;
            // 
            // ratLabel
            // 
            this.ratLabel.AutoSize = true;
            this.ratLabel.Location = new System.Drawing.Point(13, 63);
            this.ratLabel.Name = "ratLabel";
            this.ratLabel.Size = new System.Drawing.Size(125, 13);
            this.ratLabel.TabIndex = 27;
            this.ratLabel.Text = "Рейтинг (один вариант)";
            // 
            // LibForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 536);
            this.Controls.Add(this.ratLabel);
            this.Controls.Add(this.readmen);
            this.Controls.Add(this.ratingLB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PrevNextFindContainer);
            this.Controls.Add(this.NewCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatein);
            this.Controls.Add(this.lblDateout);
            this.Controls.Add(this.datein);
            this.Controls.Add(this.dateout);
            this.Controls.Add(this.inLibrary);
            this.Controls.Add(this.lblReader);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.author);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.card);
            this.Controls.Add(this.genres);
            this.Name = "LibForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа \"БИБЛИОТЕКА\"";
            this.Load += new System.EventHandler(this.LibForm_Load);
            this.Click += new System.EventHandler(this.searchCard);
            this.PrevNextFindContainer.ResumeLayout(false);
            this.PrevNextFindContainer.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox genres;
        private System.Windows.Forms.TextBox card;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblReader;
        private System.Windows.Forms.CheckBox inLibrary;
        private System.Windows.Forms.MaskedTextBox dateout;
        private System.Windows.Forms.MaskedTextBox datein;
        private System.Windows.Forms.Label lblDateout;
        private System.Windows.Forms.Label lblDatein;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewCard;
        private System.Windows.Forms.GroupBox PrevNextFindContainer;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox ratingLB;
        private System.Windows.Forms.TextBox readmen;
        private System.Windows.Forms.Label ratLabel;
    }
}

