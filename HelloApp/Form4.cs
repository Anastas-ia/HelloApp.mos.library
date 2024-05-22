using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HelloApp
{
    public partial class Form4 : Form
    {
        private object check;

        public Form4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем диалог для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Настраиваем свойства диалога (например, фильтры для типов файлов)
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Открываем диалоговое окно и проверяем результат
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Читаем содержимое выбранного файла
                string fileContent = File.ReadAllText(openFileDialog.FileName);

                // Обрабатываем содержимое файла (например, отображаем его в TextBox)
                textBox1.Text = fileContent;
            }

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string filePath = openFileDialog1.FileName;

                // Дальнейшая обработка файла
                // Например, можно отобразить имя файла в текстовом поле
                textBox1.Text = filePath;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)

        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
