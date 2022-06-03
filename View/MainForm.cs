using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список объектов.
        /// </summary>
        public List<Calc> lst = new List<Calc>();

        public MainForm()
        {
            InitializeComponent();

            // Текущие рабочие каталоги.
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Вывод названий столбцов в таблице.
            dataGridView.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    Name = "Object",
                    HeaderText = "Объект",
                    DataPropertyName = "Object"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Param1",
                    HeaderText = "U | ω",
                    DataPropertyName = "Param1"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Param2",
                    HeaderText = "I | C | L",
                    DataPropertyName = "Param2"
                }
                                         );
        }


        /// <summary>
        /// Нажатие на кнопку Добавить.
        /// Открытие формы AddObjectForm для добавления нового объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddObjectForm addObjectForm = new AddObjectForm();
            addObjectForm.Show(this);
        }


        /// <summary>
        /// Нажатие на кнопку Удалить.
        /// Удаление объекта из таблицы и списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Если количество строк в таблице больше 0.
            if (dataGridView.Rows.Count > 0)
            {
                // Индекс элемента.
                int ind = dataGridView.CurrentRow.Index;

                // Удалить элемент из списка.
                lst.RemoveAt(ind);

                // Удалить элемент из таблицы.
                dataGridView.Rows.RemoveAt(ind);
                // Обновление таблицы.
                dataGridView.Refresh();
            }
        }


        /// <summary>
        /// Нажатие на кнопку Сохранить.
        /// Сериализация.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Serializator.Serializer(saveFileDialog.FileName, lst);
                    MessageBox.Show("Данные были успешно сохранены в файл: " +
                        saveFileDialog.FileName.ToString(), "Сохранение данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Нажатие на кнопку Загрузить.
        /// Десериализация.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    lst = Serializator.Deserializer(openFileDialog.FileName);

                    // Если непустой список.
                    if (lst != null)
                    {
                        // Очистка таблицы.
                        dataGridView.Rows.Clear();

                        // Загрзука каждого объекта в список.
                        foreach (Calc obj in lst)
                            dataGridView.Rows.Add(obj.Name(),
                                obj.Param1.ToString(), obj.Param2.ToString());
                    }
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }


        /// <summary>
        /// Нажатие на кнопку Поиск.
        /// Открытие формы SearchForm для поиска объекта в списке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show(this);
        }
    }
}
