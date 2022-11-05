using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace пр3
{
    public partial class glavnoe : Form
    {
        string image;
        string[] mas = new string[8];
        public glavnoe()
        {
            InitializeComponent();
            kateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

       
        private void vixod_Click(object sender, EventArgs e)
        {
            vixod g = new vixod();
            DialogResult result = g.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    {

                        Close();
                        break;
                    }
                case DialogResult.Cancel:
                    {

                        return;
                    }
            }
        }

        private void osistka_Click(object sender, EventArgs e)
        {
            yveren yver = new yveren();
            yver.ShowDialog();
            if (yver.DialogResult == DialogResult.OK)
            {
                nasvanie.ResetText();
                kolvo.ResetText();
                cena.ResetText();
                kateg.SelectedItem = null;
                comboBox2.SelectedItem = null;
                ckidkaa.ResetText();
                xovo.ResetText();
                dowload.Enabled = false;
                dowloadpuchere.Enabled = false;
                pictureBox1.Visible = false;
                saved.Enabled = false;
                ckidka.Checked = false;
            }
            
        }

        private void info_Click(object sender, EventArgs e)
        {
            try
            {
                if (nasvanie.Text == "" || kateg.Text == "" || Convert.ToDouble(kolvo.Text) < 0 || Convert.ToDouble(cena.Text) < 0 || comboBox2.Text == "")
                {
                    MessageBox.Show("Заполните поля или проверьте значения", "проверка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    int cenaa = Convert.ToInt32(cena.Text);
                    int colvo = Convert.ToInt32(kolvo.Text);
                    int skidka = Convert.ToInt32(ckidkaa.Text);
                    double itog = (cenaa * colvo) / 100 * skidka;
                    double itogcockidkoy = (cenaa * colvo) - itog;
                    mas[0] = "Название: " + nasvanie.Text;
                    mas[1] = "Категория: " + kateg.Text;
                    mas[2] = "Дата выпуска: " + dateTimePicker1.Text;
                    mas[3] = "Цена за 1: " + comboBox2.Text + " " + cena.Text;
                    mas[4] = "Скидка: " + ckidkaa.Text;
                    mas[5] = "Количество: " + kolvo.Text;
                    mas[6] = "Скидка: " + itog;
                    mas[7] = "Итоговая цена со скидкой: " + itogcockidkoy;
                    xovo.Lines = mas;
                    dowload.Enabled = true;
                    dowloadpuchere.Enabled = true;
                    pictureBox1.Visible = true;
                    saved.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }


        private void visil_Click(object sender, EventArgs e)
        {
            try
            {
                if (nasvanie.Text == "" || kateg.Text == "" || Convert.ToDouble(kolvo.Text) < 0 || Convert.ToDouble(cena.Text) < 0 || comboBox2.Text == "")
                {
                    MessageBox.Show("Заполните поля или проверьте значения", "проверка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    int cenaa = Convert.ToInt32(cena.Text);
                    int colvo = Convert.ToInt32(kolvo.Text);
                    int skidka = Convert.ToInt32(ckidkaa.Text);
                    double itog = cenaa * colvo / 100 * skidka;
                    double itogcockidkoy = (cenaa * colvo) - itog;
                    if (Convert.ToDouble(cena.Text) < 0 || Convert.ToDouble(kolvo.Text) < 0 || itogcockidkoy < 0)
                    {
                        MessageBox.Show("Ошибка, или сумма отрицательная", "проверка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        label8.Text = "Итог к оплате: " + itogcockidkoy;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void ckidkaa_ValueChanged(object sender, EventArgs e)
        {
            if (ckidka.Checked == false)

            {
                ckidkaa.Value = 0;
            }
        }

        private void dowloadpuchere_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog(); //Создание переменной и вызов диалога выбора файла
            f.Filter = "(*.jpg, *.png)|*.jpg;*.png";
            Image File;			//Создание переменной картинки
            if (f.ShowDialog() == DialogResult.OK) //При нажатии на ОК выполняется код
            {
                File = Image.FromFile(f.FileName); //Загружаем картинку в переменную
                pictureBox1.Image = File;	//Присваиваем картинку к форме
                image = f.FileName;		//Записываем путь к картинке в переменную
            }
        }

        private void dowload_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog(); //Создание переменной и вызов диалога сохранения файла
            f.Filter = "(*.rpm,)|*.rpm;";
            if (nasvanie.Text != "" && kateg.Text != "" && cena.Text != "" && kolvo.Text != "" && comboBox2.Text != "") //Проверка на пустые поля
            {
                if (f.ShowDialog() == DialogResult.OK) //При нажатии на ОК выполняется код
                {
                    System.IO.File.WriteAllLines(f.FileName.ToString(),mas, Encoding.GetEncoding(1251)); //Записывает массив myArr в файл с путем f.FileName.ToString()
                    System.IO.File.AppendAllText(f.FileName.ToString(), "Фото товара:" + " " + image, Encoding.GetEncoding(1251)); //Дописываем в файл данные о фотографии
                    MessageBox.Show("Файл сохранен"); //Сообщение о сохранении файла
                }
            }
            else
            {
                MessageBox.Show("Требуется заполнить все поля!"); //Сообщение ошибки
            }
        }

        private void saved_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog(); //Создание переменной и вызов диалога сохранения файла
            f.Filter = "(*.rpm,)|*.rpm;";
            if (nasvanie.Text != "" && kateg.Text != "" && cena.Text != "" && kolvo.Text != "" && comboBox2.Text != "")                 // Проверка на пустые поля
            {
                if (f.ShowDialog() == DialogResult.OK)  //При нажатии на ОК выполняется код
                {
                    string[] saveArray = new string[9]; //Создаём массив
                    saveArray[0] = nasvanie.Text;   //Вносим в массив данные из полей
                    saveArray[1] = kateg.Text;
                    saveArray[2] = cena.Text;
                    saveArray[3] = kolvo.Text;
                    saveArray[4] = comboBox2.Text;
                    saveArray[5] = dateTimePicker1.Text;
                    if (ckidka.Checked == true)     //Проверка на скидку
                    {                   //Если скидка включена, то в файл записывается 
                        saveArray[6] = ckidka.Checked.ToString(); //Значение true
                        saveArray[7] = ckidkaa.Text; //Значение скидки
                    };
                    if (ckidka.Checked == false)    //Если нет 
                    {
                        saveArray[6] = ckidka.Checked.ToString();//Значение false
                    };
                    saveArray[8] = image;       //Путь к картинке
                    System.IO.File.WriteAllLines(f.FileName.ToString(), saveArray, Encoding.GetEncoding(1251));     //Запись в файл
                    MessageBox.Show("Файл сохранен");   //Сообщение о сохранении
                }
            }
            else
            {
                MessageBox.Show("Требуется заполнить все поля!"); //Если поля пустые
            }
        }

        private void dowl_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();//Создание переменной и вызов диалога сохранения файла
            f.Filter = "(*.rpm,)|*.rpm;";
            string[] saveArray = new string[9];     //Создаём массив
            if (f.ShowDialog() == DialogResult.OK)  //При нажатии на ОК выполняется код
            {
                saveArray = System.IO.File.ReadAllLines(f.FileName.ToString(), Encoding.GetEncoding(1251));     //Считываем данный из файла в массив saveArray
                nasvanie.Text = saveArray[0];   //Присваиваем данные из массива в поля
                kateg.Text = saveArray[1];
                cena.Text = saveArray[2];
                kolvo.Text = saveArray[3];
                comboBox2.Text = saveArray[4];
                dateTimePicker1.Text = saveArray[5]; //Изменяем тип данных и присваиваем к дате
                if (saveArray[6] == "True")         //Проверка на скидку
                {                       //Если скидка была включена, то
                    ckidka.Checked = true;      //Включаем её
                    ckidkaa.Text = saveArray[7];    //Присваиваем её значение
                    ckidkaa.Enabled = true;     //Включаем переключатель
                }
                if (saveArray[6] == "False")        //Если скидка была выключена, то
                {
                   ckidka.Checked = false;     //Выключаем её

                }
                image = saveArray[8];           //Вносим значение пути до картинки в переменную
                if (image != "")                //Если путь есть, то
                {
                    pictureBox1.Image = Image.FromFile(image);//Присваиваем путь
                    pictureBox1.Visible = true;     //Включаем картинку
                }
            }
        }

        private void wottb_Click(object sender, EventArgs e)
        {
            try
            {
                if (nasvanie.Text == "" || kateg.Text == "" || Convert.ToDouble(kolvo.Text) < 0 || Convert.ToDouble(cena.Text) < 0 || comboBox2.Text == "")
                {
                    MessageBox.Show("Заполните поля или проверьте значения", "проверка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    int cenaa = Convert.ToInt32(cena.Text);
                    int colvo = Convert.ToInt32(kolvo.Text);
                    int skidka = Convert.ToInt32(ckidkaa.Text);
                    double itog = cenaa * colvo / 100 * skidka;
                    double itogcockidkoy = (cenaa * colvo) - itog;
                    dataGridView1.Rows.Add(nasvanie.Text, kateg.Text, dateTimePicker1.Text, cena.Text, kolvo.Text, ckidka.Checked, ckidkaa.Text, comboBox2.Text, itogcockidkoy);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
                
        }

        private void ckidka_CheckedChanged(object sender, EventArgs e)
        {
            if (ckidka.Checked == true)
            {
                ckidkaa.Enabled = true;
            }
            else
            {
                ckidkaa.Enabled = false;
                ckidkaa.Value = 0;
            }
        }

        private void ckidkaa_ValueChanged_1(object sender, EventArgs e)
        {
            if (ckidka.Checked == false)
            {
                ckidkaa.Value = 0;
            }
        }

        private void delettb_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Нет строки");
            }
            else
            {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
                //ind = dataGridView1.SelectedCells[1].RowIndex;
                //dataGridView1.Rows.RemoveAt(ind);
                //ind = dataGridView1.SelectedCells[2].RowIndex;
                //dataGridView1.Rows.RemoveAt(ind);
                //ind = dataGridView1.SelectedCells[3].RowIndex;
                //dataGridView1.Rows.RemoveAt(ind);
                //ind = dataGridView1.SelectedCells[4].RowIndex;
                //dataGridView1.Rows.RemoveAt(ind);
                //ind = dataGridView1.SelectedCells[5].RowIndex;
                //dataGridView1.Rows.RemoveAt(ind);
                //ind = dataGridView1.SelectedCells[6].RowIndex;
                //dataGridView1.Rows.RemoveAt(ind);
                //ind = dataGridView1.SelectedCells[7].RowIndex;
                //dataGridView1.Rows.RemoveAt(ind);
                //ind = dataGridView1.SelectedCells[8].RowIndex;
                //dataGridView1.Rows.RemoveAt(ind);
            }

        }

        private void izmentb_CheckedChanged(object sender, EventArgs e)
        {
            if (nasvanie.Text == "" || kateg.Text == "" || Convert.ToDouble(kolvo.Text) < 0 || Convert.ToDouble(cena.Text) < 0 || comboBox2.Text == "")
            {
                MessageBox.Show("Заполните поля или проверьте значения", "проверка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (izmentb.Checked == true)
                {
                    dataGridView1.ReadOnly = false;
                }
                else
                {
                    dataGridView1.ReadOnly = true;
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    int ind = dataGridView1.SelectedCells[0].RowIndex;
                    nasvanie.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                    kateg.Text = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.Rows[ind].Cells[2].Value.ToString();
                    cena.Text = dataGridView1.Rows[ind].Cells[3].Value.ToString();
                    kolvo.Text = dataGridView1.Rows[ind].Cells[4].Value.ToString();
                    ckidka.Checked = (bool)dataGridView1.Rows[ind].Cells[5].Value;
                    ckidkaa.Text = dataGridView1.Rows[ind].Cells[6].Value.ToString();
                    comboBox2.Text = dataGridView1.Rows[ind].Cells[7].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("ошибОЧКА");
            }
        }

        private void obnovtb_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Заполните поля или проверьте значения", "проверка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    int cenaa = Convert.ToInt32(cena.Text);
                    int colvo = Convert.ToInt32(kolvo.Text);
                    int skidka = Convert.ToInt32(ckidkaa.Text);
                    double itog = cenaa * colvo / 100 * skidka;
                    double itogcockidkoy = (cenaa * colvo) - itog;
                    int ind = dataGridView1.SelectedCells[0].RowIndex; //Внесение в переменную индекс выделенной строки
                    dataGridView1.Rows[ind].SetValues(nasvanie.Text, kateg.Text, dateTimePicker1.Text, cena.Text, kolvo.Text, ckidka.Checked, ckidkaa.Text, comboBox2.Text, itogcockidkoy);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void cleartb_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

       

        private void cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)&&number !=8)
            {
                e.Handled = true;
            }
        }

        private void kolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void row_click(object sender, EventArgs e)
        {
            //int ind = dataGridView1.SelectedCells[0].RowIndex;
            //dataGridView1.Text = dataGridView1.Rows[ind].Cells[0].Value.ToString();
            //dataGridView1.Columns[2].ReadOnly = true;
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
        }

        private void buttonpoisk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Visible = dataGridView1[poisknaz.SelectedIndex, i].Value.ToString() == textpoisk.Text;
            }
        }

        private void diagram_Click(object sender, EventArgs e)
        {
            Diagram form = new Diagram();
            form.Show();
            string[] name = new string[dataGridView1.Rows.Count]; 	
            string[] price = new string[dataGridView1.Rows.Count];	
            for (int i = 0; i < dataGridView1.Rows.Count; i++)    	
            {
                name[i] = dataGridView1[0, i].Value.ToString(); 	
                price[i] = dataGridView1[8, i].Value.ToString();	
            }
            Transfer.callbackEventHandler(name, price);
        }

        private void zagtab_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "(*.rpm,)|*.rpm;";
            if (f.ShowDialog() == DialogResult.OK)
            {
                yveren f2 = new yveren(); //Диалог очисти таблицы
                DialogResult result = f2.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            dataGridView1.Rows.Clear();
                            try
                            {
                                int g = 0, h = 0; //Объявление двух переменных для циклов
                                dataGridView1.Rows.Add(); //Добавляем пустую строку в таблицу
                                foreach (string line in File.ReadLines(f.FileName.ToString())) //Цикл
                                {
                                    if (g < 9) //Внесение данных в строки по 10 столбец
                                    {
                                        dataGridView1.Rows[h].Cells[g].Value = line; //Внесение значения
                                        g++; //+1 В счетчик столбцов
                                    }
                                    else
                                    {
                                        g = 0; 	//Обнуление переменной
                                        h++;	//+1 В счетчик строк
                                        dataGridView1.Rows.Add(); //Добавление строки
                                        dataGridView1.Rows[h].Cells[g].Value = line; //Внесение значения
                                        g++; //+1 В счетчик столбцов
                                    }
                                }
                                MessageBox.Show("Файл загружен");
                            }
                            catch
                            {
                                MessageBox.Show("Не подходящий файл");
                                dataGridView1.Rows.Clear();
                            }
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            return;
                        }
                }
            }
        }

        private void savetab_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "(*.rpm,)|*.rpm;";
            if (dataGridView1.Rows.Count != 0) //Проверка на пустоту таблицы
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string[,] saveArray = new string[dataGridView1.Rows.Count, 10]; //Объявление двумерного массива
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) //Два цикла для заполнения массива данными
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            saveArray[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString(); //Внесение данных
                        }
                    }
                    StreamWriter sw = new StreamWriter(f.FileName.ToString()); //Создаем процесс записи в файл
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) //Два цикла для записи в файл данных из массива
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            sw.WriteLine(saveArray[i, j]); //Запись данных в файл
                        }
                    }
                    MessageBox.Show("Файл сохранен");
                    sw.Close(); //Закрытие файла
                }
            }
            else
            {
                MessageBox.Show("Таблица не должна быть пуста!");
            }
        }

        private void cena_TextChanged(object sender, EventArgs e)
        {

        }
    } 
    
}
