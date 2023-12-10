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

        private void send_button_Click(object sender, EventArgs e)
        {
            //Нажатие кнопки отправить и последующий вывод информации
            DialogResult Send = MessageBox.Show("Вы точно хотите сохранить результат?", "Предупреждение!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Send == DialogResult.Yes)
            {
                //Рег.Выражения для обработки строк с масками
                string bik = (@"\d{2}-\d{2}-\d{2}-\d{3}");
                string inn1 = (@"\d{10}");
                string inn2 = (@"\d{12}");
                string chet = (@"\d{4}-\d{4}-\d{4}-\d{4}-\d{4}");

                bool vvod = false;
                //Проверка на наличие пустых строк
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                        if (((TextBox)c).Text != "")
                            ((TextBox)c).ReadOnly = true;
                        else
                        {
                            MessCaan(); break;
                        }
                    if (c is ComboBox)
                        if (((ComboBox)c).Text != "")
                            ((ComboBox)c).Enabled = false;
                        else
                        {
                            MessCaan(); break;
                        }
                    if (Regex.IsMatch(vvod_BIK.Text,bik)) 
                        vvod_BIK.ReadOnly = true;
                    else
                    {
                        MessCaan(); break;
                    }
                    if (Regex.IsMatch(vvod_INN.Text, inn1) || Regex.IsMatch(vvod_INN.Text, inn2))
                    {
                        vvod_INN.ReadOnly = true;
                        urface_radiob.Enabled = false;
                        predprin_radiob.Enabled = false;
                        X_button.Enabled = false;
                    }
                    else
                    {
                        MessCaan(); break;
                    }
                    if (Regex.IsMatch(vvod_chet_pol.Text, chet)) 
                        vvod_chet_pol.ReadOnly = true;
                    else
                    {
                        MessCaan();
                        break;
                    }
                    vvod = true;
                }
                //Вывод ошибки
                void MessCaan()
                {
                    MessageBox.Show("Введите все поля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Вывод информации
                if (vvod == true)
                {
                    candel_button.Enabled = false;
                    MessageBox.Show($"Плательщик: {vvod_plat.Text}\n" +
                        $"Сумма: {vvod_summ.Text} руб\n" +
                        $"Банк плательщика: {vvod_bank.Text}\n" +
                        $"БИК: {vvod_BIK.Text}\n" +
                        $"ИНН: {vvod_INN}\n" +
                        $"Банк получателя: {vvod_bank_pol.Text}\n" +
                        $"Счет (пол): {vvod_chet_pol.Text}", "Итог");
                }
            }
        }

    }
}
