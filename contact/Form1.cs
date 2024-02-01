using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace contact
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2 = new Form2(dataTable, this);
            form2.ShowDialog();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phnumber = txtPhoneNumber.Text;
            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=contact";

            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO contacts (имя_контакта, номер_телефона) VALUES (@имя_контакта, @номер_телефона)";

                    using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@имя_контакта", name);
                        command.Parameters.AddWithValue("@номер_телефона", phnumber);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Запись успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtName.Text = "";
                            txtPhoneNumber.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Запись не добавлена!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=contact";
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT номер_телефона FROM contacts WHERE имя_контакта = @имя_контакта";

                    using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@имя_контакта", name);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            txtPhoneNumber.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Такого номера не существует.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPhoneNumber.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phnumber = txtPhoneNumber.Text;
            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=contact";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT имя_контакта FROM contacts WHERE номер_телефона = @номер_телефона";

                    using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@номер_телефона", phnumber);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            txtName.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Такого номера нет.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtName.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void editname_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phnumber = txtPhoneNumber.Text;
            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=contact";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE contacts SET имя_контакта = @имя_контакта WHERE номер_телефона = @номер_телефона";

                    using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@номер_телефона", phnumber);
                        command.Parameters.AddWithValue("@имя_контакта", name);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Записи с таким именем не существует!!!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phnumber = txtPhoneNumber.Text;
            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=contact";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();


                    string deleteQuery = "DELETE FROM contacts WHERE имя_контакта = @имя_контакта OR номер_телефона = @номер_телефона";


                    using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@имя_контакта", name);
                        command.Parameters.AddWithValue("@номер_телефона", phnumber);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            MessageBox.Show("Записи успешно удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Удалять нечего, таких данных не существует.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
    }

    

