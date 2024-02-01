using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace contact
{
    public partial class Form2 : Form
    {
        private BindingSource bindingSource1;
        private DataTable dataTable;
        public Form2(DataTable dataTable, Form1 form1)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            bindingSource1 = new BindingSource();
            dataGridView1.DataSource = bindingSource1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                var cs = "Host=localhost;Username=postgres;Password=1234;Database=contact";
                using (NpgsqlConnection con = new NpgsqlConnection(cs))
                {
                    con.Open();
                    var sql = "SELECT * FROM contacts";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);
                            bindingSource1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
