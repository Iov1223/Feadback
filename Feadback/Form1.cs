using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;

namespace Feadback
{
    public partial class Form1 : Form
    {
        private string nameDB;
        private SQLiteConnection connection;
        private SQLiteCommand command;
        public Form1()
        {
            InitializeComponent();
            command = new SQLiteCommand();
            nameDB = "feadbackDB.sqlite";
            connection = new SQLiteConnection($"Data Source={nameDB};Version=3;");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(nameDB))
            {
                SQLiteConnection.CreateFile(nameDB);
            }

            try
            {
                connection.Open();
                this.Text = "Отзовик. Ссоединение с базой данных: УСТАНОВЛЕННО";
                command.Connection = connection;
                command.CommandText = "CREATE TABLE IF NOT EXISTS Object" +
                    "(" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "name_object VARCHAR (100) NOT NULL," +
                        "link VARCHAR (100) NOT NULL," +
                        "social_network VARCHAR (100) NOT NULL," +
                        "information_system VARCHAR (100) NOT NULL" +
                     ")";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT COUNT(*) FROM Object";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                {
                    command.CommandText = "INSERT INTO Object " +
                    "(name_object, link, social_network, information_system)" +
                    "VALUES" +
                    "('Кинотеатр \"Пассаж Синема\"', 'passage-cinema.ru/', 'vk.com/passage_cinema', 'google.com')," +
                    "('Ресторан \"ХочуПури\"', 'hochupuri.com/ekaterinburg/', 'vk.com/hochu_puri_ekb', 'yandex.ru')," +
                    "('Театр Музкомедии', 'www.muzkom.net/', 'vk.com/muzkom_ekb', 'mail.ru')," +
                    "('Академический театр драмы', 'uraldrama.ru/', 'vk.com/uraldrama', 'yandex.ru')," +
                    "('Музей изобразительных искусств ', 'i-z-o.art/', 'vk.com/muzei_izo', 'mail.ru');";
                    command.ExecuteNonQuery();
                }
                command.CommandText = "CREATE TABLE IF NOT EXISTS Feadbacks" +
                    "(" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "FK_id INTEGER NOT NULL, " +
                        "nickname_or_name VARCHAR (100) NOT NULL," +
                        "email VARCHAR (100) NOT NULL," +
                        "feadback VARCHAR (1000) NOT NULL," +
                        "add_date TIMESTAMP DEFAULT CURRENT_DATE," +
                        "FOREIGN KEY (FK_id) REFERENCES Object(id)" +
                     ")";
                command.ExecuteNonQuery();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Object", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Height = 133;
                dataGridView1.DataSource = table;
            }
            catch
            {
                this.Text = "Отзовик. Ссоединение с базой данных: НЕ УСТАНОВЛЕННО";
                MessageBox.Show("Не удалось подключится к базе данных!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,}$");
            command.CommandText = "SELECT COUNT(*) FROM Object";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (regex.IsMatch(textBoxEmail.Text) && Convert.ToInt32(textBoxNum.Text) <= count)
            {
                if (textBoxNum.Text != "" && textBoxNick.Text != "" && textBoxEmail.Text != "" && richTextBoxFeaddback.Text != "")
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Feadbacks " +
                            "(FK_id, nickname_or_name, email, feadback, add_date)" +
                            "VALUES" +
                            $"({textBoxNum.Text}, '{textBoxNick.Text}', '{textBoxEmail.Text}', '{richTextBoxFeaddback.Text}', datetime('now'));";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Отзыв успешно добален");
                    textBoxEmail.Clear();
                    textBoxNick.Clear();
                    textBoxNum.Clear();
                    richTextBoxFeaddback.Clear();

                }
                else
                {
                    MessageBox.Show("Для добавления отзыва нужно заполнить все поля");
                }
            }
            else
            {
                MessageBox.Show("Неверный адрес почты или номер объекта (номер не должен привышать количество строк)");
            }

        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]");
            if (regex.IsMatch(textBoxNum.Text + e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Только числовой ввод");
            }
        }

        private void buttonShowNewForm_Click(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MaximumSize = new Size(816, 300);
            childForm.MinimumSize = new Size(816, 400);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Feadbacks", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            DataGridView dataGridView = new DataGridView();
            dataGridView.Size = new Size(776, 340);
            dataGridView.Location = new Point(10, 10);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = table;
            childForm.Controls.Add(dataGridView);
            childForm.Show();
           
        }
    }
}
