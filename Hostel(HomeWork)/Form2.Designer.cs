namespace Hostel_HomeWork_
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCardFIO = new System.Windows.Forms.TextBox();
            this.txtBoxCardDateBirth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCardPayment = new System.Windows.Forms.TextBox();
            this.txtBoxCardDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCardPets = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Карточка Гостя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxCardFIO
            // 
            this.txtBoxCardFIO.Location = new System.Drawing.Point(16, 68);
            this.txtBoxCardFIO.Name = "txtBoxCardFIO";
            this.txtBoxCardFIO.Size = new System.Drawing.Size(419, 22);
            this.txtBoxCardFIO.TabIndex = 1;
            this.txtBoxCardFIO.Text = "ФИО";
            // 
            // txtBoxCardDateBirth
            // 
            this.txtBoxCardDateBirth.Location = new System.Drawing.Point(16, 119);
            this.txtBoxCardDateBirth.Name = "txtBoxCardDateBirth";
            this.txtBoxCardDateBirth.Size = new System.Drawing.Size(419, 22);
            this.txtBoxCardDateBirth.TabIndex = 2;
            this.txtBoxCardDateBirth.Text = "Дата Рождения";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(169, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество дней";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxCardPayment
            // 
            this.txtBoxCardPayment.Location = new System.Drawing.Point(16, 173);
            this.txtBoxCardPayment.Name = "txtBoxCardPayment";
            this.txtBoxCardPayment.Size = new System.Drawing.Size(419, 22);
            this.txtBoxCardPayment.TabIndex = 7;
            this.txtBoxCardPayment.Text = "Оплата";
            // 
            // txtBoxCardDays
            // 
            this.txtBoxCardDays.Location = new System.Drawing.Point(38, 250);
            this.txtBoxCardDays.Name = "txtBoxCardDays";
            this.txtBoxCardDays.Size = new System.Drawing.Size(125, 22);
            this.txtBoxCardDays.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "С вами будет питомец?";
            // 
            // txtBoxCardPets
            // 
            this.txtBoxCardPets.Location = new System.Drawing.Point(42, 340);
            this.txtBoxCardPets.Name = "txtBoxCardPets";
            this.txtBoxCardPets.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCardPets.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.txtBoxCardPets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCardDays);
            this.Controls.Add(this.txtBoxCardPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxCardDateBirth);
            this.Controls.Add(this.txtBoxCardFIO);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Постоялец";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBoxCardFIO;
        public System.Windows.Forms.TextBox txtBoxCardDateBirth;
        public System.Windows.Forms.TextBox txtBoxCardPayment;
        public System.Windows.Forms.TextBox txtBoxCardDays;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtBoxCardPets;
    }
}