using System.Data.SQLite;

namespace Menage_Shop_Window
{
    public partial class Form1 : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:"+Application.StartupPath+"\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
            }
            cmd.ExecuteNonQuery();
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                  
                    sqlite.Open();
                    string sql = "create table test(name varchar(30), describe varchar(30), category varchar(30), amount varchar(30), price varchar(30))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                } 
            }
            else
            {
                Console.WriteLine("Database cannot create");
                return;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO test(name, describe, category, amount, price) VALUES (@name, @describe, @category, @amount, @price)";

                string NAME = name_txt.Text;
                string DESCRIBE = desc_txt.Text;
                string CATEGORY = cat_txt.Text;
                string AMOUNT = amount_txt.Text;
                string PRICE = price_txt.Text;

                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@describe", DESCRIBE);
                cmd.Parameters.AddWithValue("@category", CATEGORY);
                cmd.Parameters.AddWithValue("@amount", AMOUNT);
                cmd.Parameters.AddWithValue("@price", PRICE);

                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Name";
                dataGridView1.Columns[1].Name = "Describe";
                dataGridView1.Columns[2].Name = "Category";
                dataGridView1.Columns[3].Name = "Amount";
                dataGridView1.Columns[4].Name = "Price";

                string[] row = new string[] { NAME, DESCRIBE, CATEGORY, AMOUNT, PRICE };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                Console.WriteLine("cannot insert data");
            }


        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE test SET describe=@Describe, category=@Category, amount=@Amount, price=@Price WHERE name=@Name";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Name", name_txt.Text);
            cmd.Parameters.AddWithValue("@Describe", desc_txt.Text);
            cmd.Parameters.AddWithValue("@Category", cat_txt.Text);
            cmd.Parameters.AddWithValue("@Amount", amount_txt.Text);
            cmd.Parameters.AddWithValue("@Price", price_txt.Text);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM test WHERE name=@Name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", name_txt.Text);
                cmd.ExecuteNonQuery ();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                Console.WriteLine("cannot delet data");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "SELECT * FROM test WHERE category=@Category";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Category", cat_txt.Text);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                name_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                desc_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Describe"].FormattedValue.ToString();
                cat_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
                amount_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
                price_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            }
        }
    }
}