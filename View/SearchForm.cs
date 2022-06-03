using System;
using System.Windows.Forms;
using Model;


namespace View
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Нажатие на кнопку Найти (Param1).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRunSearchParam1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            // Очистка списка.
            listBoxObj.Items.Clear();

            // Флаг поиска.
            bool flagSearched = false;
            
            // Поиск объектов в списке.
            foreach (Calc obj in mainForm.lst)
                if (obj.Param1.ToString() == textBoxParam1.Text)
                {
                    listBoxObj.Items.Add(obj.Name());
                    flagSearched = true;
                }              
  
            if (!flagSearched)
                MessageBox.Show("Объекты не найдены.", 
                    "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Нажатие на кнопку Найти (Param2).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRunSearchParam2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            // Очистка списка.
            listBoxObj.Items.Clear();

            // Флаг поиска.
            bool flagSearched = false;

            // Поиск объектов в списке.
            foreach (Calc obj in mainForm.lst)
                if (obj.Param2.ToString() == textBoxParam2.Text)
                {
                    listBoxObj.Items.Add(obj.Name());
                    flagSearched = true;
                }

            if (!flagSearched)
                MessageBox.Show("Объекты не найдены.",
                    "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
