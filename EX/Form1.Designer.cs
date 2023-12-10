namespace EX
{
    partial class form_plata
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
            this.text_plat_porych = new System.Windows.Forms.Label();
            this.text_data = new System.Windows.Forms.Label();
            this.tex_plat = new System.Windows.Forms.Label();
            this.text_summ = new System.Windows.Forms.Label();
            this.text_bank = new System.Windows.Forms.Label();
            this.text_BIK = new System.Windows.Forms.Label();
            this.text_INN = new System.Windows.Forms.Label();
            this.text_bank_pol = new System.Windows.Forms.Label();
            this.text_chet_pol = new System.Windows.Forms.Label();
            this.vvod_plat = new System.Windows.Forms.TextBox();
            this.vvod_BIK = new System.Windows.Forms.MaskedTextBox();
            this.vvod_bank = new System.Windows.Forms.ComboBox();
            this.vvod_INN = new System.Windows.Forms.MaskedTextBox();
            this.urface_radiob = new System.Windows.Forms.RadioButton();
            this.predprin_radiob = new System.Windows.Forms.RadioButton();
            this.vvod_bank_pol = new System.Windows.Forms.ComboBox();
            this.vvod_chet_pol = new System.Windows.Forms.MaskedTextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.candel_button = new System.Windows.Forms.Button();
            this.X_button = new System.Windows.Forms.Button();
            this.vvod_summ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_plat_porych
            // 
            this.text_plat_porych.AutoSize = true;
            this.text_plat_porych.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_plat_porych.Location = new System.Drawing.Point(41, 32);
            this.text_plat_porych.Name = "text_plat_porych";
            this.text_plat_porych.Size = new System.Drawing.Size(169, 13);
            this.text_plat_porych.TabIndex = 0;
            this.text_plat_porych.Text = "ПЛАТЕЖНОЕ ПОРУЧЕНИЕ";
            // 
            // text_data
            // 
            this.text_data.AutoSize = true;
            this.text_data.Location = new System.Drawing.Point(77, 45);
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(90, 13);
            this.text_data.TabIndex = 1;
            this.text_data.Text = "Введите данные";
            // 
            // tex_plat
            // 
            this.tex_plat.AutoSize = true;
            this.tex_plat.Location = new System.Drawing.Point(12, 88);
            this.tex_plat.Name = "tex_plat";
            this.tex_plat.Size = new System.Drawing.Size(74, 13);
            this.tex_plat.TabIndex = 2;
            this.tex_plat.Text = "Плательщик:";
            // 
            // text_summ
            // 
            this.text_summ.AutoSize = true;
            this.text_summ.Location = new System.Drawing.Point(12, 114);
            this.text_summ.Name = "text_summ";
            this.text_summ.Size = new System.Drawing.Size(44, 13);
            this.text_summ.TabIndex = 3;
            this.text_summ.Text = "Сумма:";
            // 
            // text_bank
            // 
            this.text_bank.AutoSize = true;
            this.text_bank.Location = new System.Drawing.Point(12, 140);
            this.text_bank.Name = "text_bank";
            this.text_bank.Size = new System.Drawing.Size(106, 13);
            this.text_bank.TabIndex = 4;
            this.text_bank.Text = "Банк плательщика:";
            // 
            // text_BIK
            // 
            this.text_BIK.AutoSize = true;
            this.text_BIK.Location = new System.Drawing.Point(12, 167);
            this.text_BIK.Name = "text_BIK";
            this.text_BIK.Size = new System.Drawing.Size(32, 13);
            this.text_BIK.TabIndex = 5;
            this.text_BIK.Text = "БИК:";
            // 
            // text_INN
            // 
            this.text_INN.AutoSize = true;
            this.text_INN.Location = new System.Drawing.Point(12, 194);
            this.text_INN.Name = "text_INN";
            this.text_INN.Size = new System.Drawing.Size(34, 13);
            this.text_INN.TabIndex = 6;
            this.text_INN.Text = "ИНН:";
            // 
            // text_bank_pol
            // 
            this.text_bank_pol.AutoSize = true;
            this.text_bank_pol.Location = new System.Drawing.Point(12, 253);
            this.text_bank_pol.Name = "text_bank_pol";
            this.text_bank_pol.Size = new System.Drawing.Size(95, 13);
            this.text_bank_pol.TabIndex = 7;
            this.text_bank_pol.Text = "Банк получателя:";
            // 
            // text_chet_pol
            // 
            this.text_chet_pol.AutoSize = true;
            this.text_chet_pol.Location = new System.Drawing.Point(14, 280);
            this.text_chet_pol.Name = "text_chet_pol";
            this.text_chet_pol.Size = new System.Drawing.Size(60, 13);
            this.text_chet_pol.TabIndex = 8;
            this.text_chet_pol.Text = "Счет (пол):";
            // 
            // vvod_plat
            // 
            this.vvod_plat.Location = new System.Drawing.Point(92, 85);
            this.vvod_plat.Name = "vvod_plat";
            this.vvod_plat.Size = new System.Drawing.Size(148, 20);
            this.vvod_plat.TabIndex = 9;
            // 
            // vvod_BIK
            // 
            this.vvod_BIK.Location = new System.Drawing.Point(52, 164);
            this.vvod_BIK.Mask = "00-00-00-000";
            this.vvod_BIK.Name = "vvod_BIK";
            this.vvod_BIK.Size = new System.Drawing.Size(188, 20);
            this.vvod_BIK.TabIndex = 11;
            this.vvod_BIK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vvod_bank
            // 
            this.vvod_bank.FormattingEnabled = true;
            this.vvod_bank.Items.AddRange(new object[] {
            "ПАО «Лучший банк»",
            "ПАО «Главный банк»",
            "ПАО «Замечательный банк»"});
            this.vvod_bank.Location = new System.Drawing.Point(124, 137);
            this.vvod_bank.Name = "vvod_bank";
            this.vvod_bank.Size = new System.Drawing.Size(116, 21);
            this.vvod_bank.TabIndex = 12;
            // 
            // vvod_INN
            // 
            this.vvod_INN.Location = new System.Drawing.Point(52, 190);
            this.vvod_INN.Mask = "0000000000";
            this.vvod_INN.Name = "vvod_INN";
            this.vvod_INN.ReadOnly = true;
            this.vvod_INN.Size = new System.Drawing.Size(188, 20);
            this.vvod_INN.TabIndex = 13;
            this.vvod_INN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // urface_radiob
            // 
            this.urface_radiob.AutoSize = true;
            this.urface_radiob.Location = new System.Drawing.Point(15, 223);
            this.urface_radiob.Name = "urface_radiob";
            this.urface_radiob.Size = new System.Drawing.Size(64, 17);
            this.urface_radiob.TabIndex = 14;
            this.urface_radiob.TabStop = true;
            this.urface_radiob.Text = "Юрлицо";
            this.urface_radiob.UseVisualStyleBackColor = true;
            this.urface_radiob.CheckedChanged += new System.EventHandler(this.urface_radiob_CheckedChanged);
            // 
            // predprin_radiob
            // 
            this.predprin_radiob.AutoSize = true;
            this.predprin_radiob.Location = new System.Drawing.Point(80, 223);
            this.predprin_radiob.Name = "predprin_radiob";
            this.predprin_radiob.Size = new System.Drawing.Size(118, 17);
            this.predprin_radiob.TabIndex = 15;
            this.predprin_radiob.TabStop = true;
            this.predprin_radiob.Text = "Предприниматель";
            this.predprin_radiob.UseVisualStyleBackColor = true;
            this.predprin_radiob.CheckedChanged += new System.EventHandler(this.predprin_radiob_CheckedChanged);
            // 
            // vvod_bank_pol
            // 
            this.vvod_bank_pol.FormattingEnabled = true;
            this.vvod_bank_pol.Items.AddRange(new object[] {
            "ПАО «Лучший банк»",
            "ПАО «Главный банк»",
            "ПАО «Замечательный банк»"});
            this.vvod_bank_pol.Location = new System.Drawing.Point(113, 250);
            this.vvod_bank_pol.Name = "vvod_bank_pol";
            this.vvod_bank_pol.Size = new System.Drawing.Size(127, 21);
            this.vvod_bank_pol.TabIndex = 16;
            // 
            // vvod_chet_pol
            // 
            this.vvod_chet_pol.Location = new System.Drawing.Point(80, 277);
            this.vvod_chet_pol.Mask = "0000-0000-0000-0000-0000";
            this.vvod_chet_pol.Name = "vvod_chet_pol";
            this.vvod_chet_pol.Size = new System.Drawing.Size(160, 20);
            this.vvod_chet_pol.TabIndex = 17;
            this.vvod_chet_pol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(15, 314);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(116, 23);
            this.send_button.TabIndex = 18;
            this.send_button.Text = "Отправить";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // candel_button
            // 
            this.candel_button.Location = new System.Drawing.Point(137, 314);
            this.candel_button.Name = "candel_button";
            this.candel_button.Size = new System.Drawing.Size(103, 23);
            this.candel_button.TabIndex = 19;
            this.candel_button.Text = "Отменить";
            this.candel_button.UseVisualStyleBackColor = true;
            this.candel_button.Click += new System.EventHandler(this.candel_button_Click);
            // 
            // X_button
            // 
            this.X_button.Location = new System.Drawing.Point(204, 221);
            this.X_button.Name = "X_button";
            this.X_button.Size = new System.Drawing.Size(36, 23);
            this.X_button.TabIndex = 20;
            this.X_button.Text = "X";
            this.X_button.UseVisualStyleBackColor = true;
            this.X_button.Click += new System.EventHandler(this.X_button_Click);
            // 
            // vvod_summ
            // 
            this.vvod_summ.Location = new System.Drawing.Point(62, 111);
            this.vvod_summ.Name = "vvod_summ";
            this.vvod_summ.Size = new System.Drawing.Size(178, 20);
            this.vvod_summ.TabIndex = 10;
            this.vvod_summ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvod_summ_KeyPress);
            // 
            // form_plata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 349);
            this.Controls.Add(this.X_button);
            this.Controls.Add(this.candel_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.vvod_chet_pol);
            this.Controls.Add(this.vvod_bank_pol);
            this.Controls.Add(this.predprin_radiob);
            this.Controls.Add(this.urface_radiob);
            this.Controls.Add(this.vvod_INN);
            this.Controls.Add(this.vvod_bank);
            this.Controls.Add(this.vvod_BIK);
            this.Controls.Add(this.vvod_summ);
            this.Controls.Add(this.vvod_plat);
            this.Controls.Add(this.text_chet_pol);
            this.Controls.Add(this.text_bank_pol);
            this.Controls.Add(this.text_INN);
            this.Controls.Add(this.text_BIK);
            this.Controls.Add(this.text_bank);
            this.Controls.Add(this.text_summ);
            this.Controls.Add(this.tex_plat);
            this.Controls.Add(this.text_data);
            this.Controls.Add(this.text_plat_porych);
            this.Name = "form_plata";
            this.Text = "ПЛАТЕЖНОЕ ПОРУЧЕНИЕ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_plat_porych;
        private System.Windows.Forms.Label text_data;
        private System.Windows.Forms.Label tex_plat;
        private System.Windows.Forms.Label text_summ;
        private System.Windows.Forms.Label text_bank;
        private System.Windows.Forms.Label text_BIK;
        private System.Windows.Forms.Label text_INN;
        private System.Windows.Forms.Label text_bank_pol;
        private System.Windows.Forms.Label text_chet_pol;
        private System.Windows.Forms.TextBox vvod_plat;
        private System.Windows.Forms.MaskedTextBox vvod_BIK;
        private System.Windows.Forms.ComboBox vvod_bank;
        private System.Windows.Forms.MaskedTextBox vvod_INN;
        private System.Windows.Forms.RadioButton urface_radiob;
        private System.Windows.Forms.RadioButton predprin_radiob;
        private System.Windows.Forms.ComboBox vvod_bank_pol;
        private System.Windows.Forms.MaskedTextBox vvod_chet_pol;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button candel_button;
        private System.Windows.Forms.Button X_button;
        private System.Windows.Forms.TextBox vvod_summ;
    }
}

