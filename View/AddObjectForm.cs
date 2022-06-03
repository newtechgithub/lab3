using System;
using System.Windows.Forms;

using Model;


namespace View
{
    public partial class AddObjectForm : Form
    {
        public AddObjectForm()
        {
            InitializeComponent();

            #if !DEBUG
                buttonCRD.Visible = false;
            #endif
        }


        /// <summary>
        /// Нажатие на кнопку Заполнить. 
        /// Генерация псевдослучайных значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCRD_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            textBoxParam1.Text = Math.Round(rnd.NextDouble() * 55 + 1, 1).ToString();            
            textBoxParam2.Text = Math.Round(rnd.NextDouble() * 75 + 1, 1).ToString();
        }


        /// <summary>
        /// Нажатие на кнопку Добавить.
        /// Добавить объект в список объектов с отображением в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            if (!Double.TryParse(textBoxParam1.Text, out double buf_param1))
            {
                MessageBox.Show("[Param1 (U | ω)] Невозможно преобразовать строку в действительное число.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Double.TryParse(textBoxParam2.Text, out double buf_param2))
            {
                MessageBox.Show("[Param2 (I | C | L)] Невозможно преобразовать строку в действительное число.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked)
            {
                try
                {
                    // Создание объекта класса РЕЗИСТОР.
                    Resistor obj = new Resistor
                    {
                        // 
                        Param1 = buf_param1,
                        Param2 = buf_param2
                    };
                
                    mainForm.lst.Add(obj);
                    mainForm.dataGridView.Rows.Add(obj.Name(), 
                        obj.Param1.ToString(), obj.Param2.ToString());
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое значение\nДолжно быть: U > 0, I > 0.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButton2.Checked)
            {
                try
                {               
                    Capacitor obj = new Capacitor
                    {
                        Param1 = buf_param1,
                        Param2 = buf_param2
                    };

                    mainForm.lst.Add(obj);
                    mainForm.dataGridView.Rows.Add(obj.Name(), 
                        obj.Param1.ToString(), obj.Param2.ToString());
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое значение.\nДолжно быть: ω > 0, C > 0.", 
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Inductor obj = new Inductor
                    {
                        Param1 = buf_param1,
                        Param2 = buf_param2
                    };

                    mainForm.lst.Add(obj);
                    mainForm.dataGridView.Rows.Add(obj.Name(), 
                        obj.Param1.ToString(), obj.Param2.ToString());
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое значение.\nДолжно быть: ω > 0, L > 0.",
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Close();
        }


        /// <summary>
        /// Нажатие на кнопку Отмена.
        /// Закрытие формы [Добавить элемент].
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Нажатие на переключатель Резистор.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelParam1.Text = "U:";
            labelParam2.Text = "I:";
        }


        /// <summary>
        /// Нажатие на переключатель Конденсатор.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelParam1.Text = "  ω:";
            labelParam2.Text = "C:";
        }


        /// <summary>
        /// Нажатие на переключатель Индуктивность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            labelParam1.Text = "  ω:";
            labelParam2.Text = "L:";
        }
    }
}
