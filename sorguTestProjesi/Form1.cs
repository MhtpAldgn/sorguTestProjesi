using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sorguTestProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B2AV4A5\\SQLDEVELOPER;Initial Catalog=DbNotKayit;Integrated Security=True");

        void listele()
        {
            
            SqlDataAdapter dataadptr = new SqlDataAdapter("select * from TBLDERS", baglanti);
            DataTable dataTable= new DataTable();
            dataadptr.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            
        }
        private void btnCalistir_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;

            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("SQL komutunuzu kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;

            try
            {
                baglanti.Open();
                SqlCommand kmt = new SqlCommand(sorgu, baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("SQL komutunuzu kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSqlHakkinda_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "SQL komutları ipucu: listelemek için select, " +
                " güncellemek için update, " +
                " silmek için delete, " +
                " eklemek için insert into komutlarını kullanınız :)";

        }
    }
}
