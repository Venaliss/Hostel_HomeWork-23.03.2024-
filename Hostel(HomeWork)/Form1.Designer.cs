namespace Hostel_HomeWork_
{
    partial class Hostel_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hostel_List));
            this.rdBtnReserved = new System.Windows.Forms.RadioButton();
            this.rdBtnFree = new System.Windows.Forms.RadioButton();
            this.rdBtnOccupied = new System.Windows.Forms.RadioButton();
            this.rdBtnLeave = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDateIn = new System.Windows.Forms.TextBox();
            this.txtBoxDateOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGuestCard = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // rdBtnReserved
            // 
            this.rdBtnReserved.AutoSize = true;
            this.rdBtnReserved.Location = new System.Drawing.Point(12, 91);
            this.rdBtnReserved.Name = "rdBtnReserved";
            this.rdBtnReserved.Size = new System.Drawing.Size(147, 21);
            this.rdBtnReserved.TabIndex = 1;
            this.rdBtnReserved.TabStop = true;
            this.rdBtnReserved.Text = "Зарезервировано";
            this.rdBtnReserved.UseVisualStyleBackColor = true;
            this.rdBtnReserved.CheckedChanged += new System.EventHandler(this.rdBtnReserved_CheckedChanged);
            // 
            // rdBtnFree
            // 
            this.rdBtnFree.AutoSize = true;
            this.rdBtnFree.Location = new System.Drawing.Point(12, 118);
            this.rdBtnFree.Name = "rdBtnFree";
            this.rdBtnFree.Size = new System.Drawing.Size(93, 21);
            this.rdBtnFree.TabIndex = 2;
            this.rdBtnFree.TabStop = true;
            this.rdBtnFree.Text = "Свободно";
            this.rdBtnFree.UseVisualStyleBackColor = true;
            this.rdBtnFree.CheckedChanged += new System.EventHandler(this.rdBtnFree_CheckedChanged);
            // 
            // rdBtnOccupied
            // 
            this.rdBtnOccupied.AutoSize = true;
            this.rdBtnOccupied.Location = new System.Drawing.Point(12, 145);
            this.rdBtnOccupied.Name = "rdBtnOccupied";
            this.rdBtnOccupied.Size = new System.Drawing.Size(77, 21);
            this.rdBtnOccupied.TabIndex = 3;
            this.rdBtnOccupied.TabStop = true;
            this.rdBtnOccupied.Text = "Занято";
            this.rdBtnOccupied.UseVisualStyleBackColor = true;
            this.rdBtnOccupied.CheckedChanged += new System.EventHandler(this.rdBtnOccupied_CheckedChanged);
            // 
            // rdBtnLeave
            // 
            this.rdBtnLeave.AutoSize = true;
            this.rdBtnLeave.Location = new System.Drawing.Point(12, 172);
            this.rdBtnLeave.Name = "rdBtnLeave";
            this.rdBtnLeave.Size = new System.Drawing.Size(128, 21);
            this.rdBtnLeave.TabIndex = 4;
            this.rdBtnLeave.TabStop = true;
            this.rdBtnLeave.Text = "Выписываются";
            this.rdBtnLeave.UseVisualStyleBackColor = true;
            this.rdBtnLeave.CheckedChanged += new System.EventHandler(this.rdBtnLeave_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(465, 415);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(723, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Статус";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFIO.Location = new System.Drawing.Point(694, 328);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(223, 22);
            this.txtBoxFIO.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(726, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ФИО";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxDateIn
            // 
            this.txtBoxDateIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDateIn.Location = new System.Drawing.Point(694, 379);
            this.txtBoxDateIn.Name = "txtBoxDateIn";
            this.txtBoxDateIn.Size = new System.Drawing.Size(223, 22);
            this.txtBoxDateIn.TabIndex = 13;
            // 
            // txtBoxDateOut
            // 
            this.txtBoxDateOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDateOut.Location = new System.Drawing.Point(694, 430);
            this.txtBoxDateOut.Name = "txtBoxDateOut";
            this.txtBoxDateOut.Size = new System.Drawing.Size(223, 22);
            this.txtBoxDateOut.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(726, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата Заезда";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(729, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата Выезда";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(13, 2);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(43, 17);
            this.Time.TabIndex = 17;
            this.Time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGuestCard
            // 
            this.btnGuestCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuestCard.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuestCard.Location = new System.Drawing.Point(732, 467);
            this.btnGuestCard.Name = "btnGuestCard";
            this.btnGuestCard.Size = new System.Drawing.Size(185, 23);
            this.btnGuestCard.TabIndex = 18;
            this.btnGuestCard.Text = "Просмотр Карточки";
            this.btnGuestCard.UseVisualStyleBackColor = false;
            this.btnGuestCard.Click += new System.EventHandler(this.btnGuestCard_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Location = new System.Drawing.Point(715, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStatus.Location = new System.Drawing.Point(694, 283);
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.Size = new System.Drawing.Size(223, 22);
            this.txtBoxStatus.TabIndex = 19;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.Location = new System.Drawing.Point(503, 3);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(333, 22);
            this.txtBoxSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Location = new System.Drawing.Point(842, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Введите номер:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(12, 56);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(132, 32);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Статусы";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblList.Location = new System.Drawing.Point(192, 57);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(217, 32);
            this.lblList.TabIndex = 25;
            this.lblList.Text = "Список гостей";
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(726, 56);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(117, 32);
            this.lblNumber.TabIndex = 26;
            this.lblNumber.Text = "Номер:";
            // 
            // Hostel_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(975, 536);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.btnGuestCard);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxDateOut);
            this.Controls.Add(this.txtBoxDateIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdBtnLeave);
            this.Controls.Add(this.rdBtnOccupied);
            this.Controls.Add(this.rdBtnFree);
            this.Controls.Add(this.rdBtnReserved);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hostel_List";
            this.Text = "Список Постояльцев";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hostel_List_FormClosing);
            this.Load += new System.EventHandler(this.Hostel_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdBtnReserved;
        private System.Windows.Forms.RadioButton rdBtnFree;
        private System.Windows.Forms.RadioButton rdBtnOccupied;
        private System.Windows.Forms.RadioButton rdBtnLeave;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDateIn;
        private System.Windows.Forms.TextBox txtBoxDateOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGuestCard;
        private System.Windows.Forms.TextBox txtBoxStatus;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblNumber;
    }
}

