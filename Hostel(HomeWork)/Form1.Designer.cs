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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(465, 387);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(723, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Статус";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(694, 313);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(223, 22);
            this.txtBoxFIO.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(726, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ФИО";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxDateIn
            // 
            this.txtBoxDateIn.Location = new System.Drawing.Point(694, 364);
            this.txtBoxDateIn.Name = "txtBoxDateIn";
            this.txtBoxDateIn.Size = new System.Drawing.Size(223, 22);
            this.txtBoxDateIn.TabIndex = 13;
            // 
            // txtBoxDateOut
            // 
            this.txtBoxDateOut.Location = new System.Drawing.Point(694, 415);
            this.txtBoxDateOut.Name = "txtBoxDateOut";
            this.txtBoxDateOut.Size = new System.Drawing.Size(223, 22);
            this.txtBoxDateOut.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(726, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата Заезда";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(729, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата Выезда";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(13, 2);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 17);
            this.Time.TabIndex = 17;
            this.Time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Просмотр Карточки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(726, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hostel_HomeWork_.Properties.Resources.изображение_2024_03_25_184038870;
            this.pictureBox3.Location = new System.Drawing.Point(694, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hostel_HomeWork_.Properties.Resources.изображение_2024_03_25_183921148;
            this.pictureBox2.Location = new System.Drawing.Point(192, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hostel_HomeWork_.Properties.Resources.изображение_2024_03_25_183719709;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Location = new System.Drawing.Point(694, 268);
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.Size = new System.Drawing.Size(223, 22);
            this.txtBoxStatus.TabIndex = 19;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxNumber.Location = new System.Drawing.Point(865, 40);
            this.txtBoxNumber.Multiline = true;
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(52, 35);
            this.txtBoxNumber.TabIndex = 20;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(503, 3);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(333, 22);
            this.txtBoxSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(842, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // Hostel_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxDateOut);
            this.Controls.Add(this.txtBoxDateIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdBtnLeave);
            this.Controls.Add(this.rdBtnOccupied);
            this.Controls.Add(this.rdBtnFree);
            this.Controls.Add(this.rdBtnReserved);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Hostel_List";
            this.Text = "Список Постояльцев";
            this.Load += new System.EventHandler(this.Hostel_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdBtnReserved;
        private System.Windows.Forms.RadioButton rdBtnFree;
        private System.Windows.Forms.RadioButton rdBtnOccupied;
        private System.Windows.Forms.RadioButton rdBtnLeave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxStatus;
        private System.Windows.Forms.TextBox txtBoxNumber;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
    }
}

