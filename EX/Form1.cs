using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EX
{
    public partial class form_plata : Form
    {
        public form_plata()
        {
            InitializeComponent();

            //Изменение стиля ComboBox, что бы пользователь не мог редактировать текст
            vvod_bank.DropDownStyle = ComboBoxStyle.DropDownList;
            vvod_bank_pol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void urface_radiob_CheckedChanged(object sender, EventArgs e)
        {
           //Ввод маски для ИНН юр.лица
            vvod_INN.ReadOnly = false;
            vvod_INN.Mask = "0000000000";
        }

        private void predprin_radiob_CheckedChanged(object sender, EventArgs e)
        {
            //Ввод маски для ИНН пердпрен.
            vvod_INN.ReadOnly = false;
            vvod_INN.Mask = "000000000000";
        }

        private void X_button_Click(object sender, EventArgs e)
        {
            //Сброс выбора маски для ИНН (пердпрен\юр.лица)
            urface_radiob.Checked = false;
            predprin_radiob.Checked = false;
            vvod_INN.ReadOnly = true;
            vvod_INN.Text = null;
        }

        private void vvod_summ_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Контроль ввода числа суммы (_,__)
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            //Только одна запятая и не 0-ое положение курсора
            if ((e.KeyChar == ',') && (vvod_summ.SelectionStart != 0))
            {
                if ((vvod_summ.Text.IndexOf(',') != -1))
                    e.Handled = true;
                return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void candel_button_Click(object sender, EventArgs e)
        {
            //Нажатие кнопки Отмена, и отчистка всех полей ввода
             DialogResult Candel = MessageBox.Show("Вы точно хотите отчистить все поля?", "Предупреждение!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Candel == DialogResult.Yes)
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Text = null;
                    if (c is MaskedTextBox)
                        ((MaskedTextBox)c).Text = null;
                    if (c is ComboBox)
                        ((ComboBox)c).Text = null;
                }
                urface_radiob.Checked = false;
                predprin_radiob.Checked = false;
                vvod_INN.ReadOnly = true;
            }
        }

        // Нажатие кнопки отправить и последующий вывод информации.
        private void send_button_Click(object sender, EventArgs e)
        {
            DialogResult Send = MessageBox.Show("Вы точно хотите сохранить результат?", "Предупреждение!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Send == DialogResult.Yes)
            {
                People_plata people = new People_plata();

                List<string> text = new List<string> { vvod_plat.Text, vvod_summ.Text,
                    vvod_bank.Text, vvod_BIK.Text, vvod_INN.Text, vvod_bank_pol.Text, vvod_chet_pol.Text};

                if (people.Proverka(text))
                {
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox) ((TextBox)c).Enabled = false;
                        if (c is MaskedTextBox) ((MaskedTextBox)c).Enabled = false;
                        if (c is ComboBox) ((ComboBox)c).Enabled = false;
                        if (c is RadioButton) ((RadioButton)c).Enabled = false;
                        X_button.Enabled = false;
                    }
                    people.Info(text);
                }
                else MessageBox.Show("Введите все поля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    class People_plata
    {
    /// <summary>
    /// Класс проверки строк и вывода информации.
    /// </summary>

        string bik = (@"\d{2}-\d{2}-\d{2}-\d{3}");
        string inn1 = (@"\d{10}");
        string inn2 = (@"\d{12}");
        string chet = (@"\d{4}-\d{4}-\d{4}-\d{4}-\d{4}");

        public bool Proverka(List<string> text)
        {
            if ((!string.IsNullOrWhiteSpace(text[0])) && 
                (!string.IsNullOrWhiteSpace(text[1])) &&
                (!string.IsNullOrWhiteSpace(text[2])) &&
                (Regex.IsMatch(text[3], bik)) &&
                ((Regex.IsMatch(text[4], inn1)) || (Regex.IsMatch(text[4], inn2))) &&
                (!string.IsNullOrWhiteSpace(text[5])) &&
                (Regex.IsMatch(text[6], chet)))
                return true;
            else
                return false;
        }

        public void Info(List<string> text)
        {
            DialogResult pow = MessageBox.Show($"Плательщик: {text[0]}\n" +
                $"Сумма: {text[1]}\n" +
                $"Банк плательщика: {text[2]}\n" +
                $"БИК: {text[3]}\n" +
                $"ИНН: {text[4]}\n" +
                $"Банк получателя: {text[5]}\n" +
                $"Счет (пол): {text[6]}", "Итог", MessageBoxButtons.RetryCancel);
        }
    }
}
