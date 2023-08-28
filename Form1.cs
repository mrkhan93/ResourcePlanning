using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace ResourcePlanning
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GIR3DQR\SQLEXPRESS; Initial Catalog= RepoDB; Integrated security=True;");
        Sql sql = new Sql();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            sql.insert(txtPid.Text, txtPName.Text, txtQty.Text, txtSply.Text);
            txtPid.Text = "";
            txtPName.Text = "";
            txtQty.Text = "";
            txtSply.Text = "";


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            sql.update(txtPid.Text, txtPName.Text, txtQty.Text, txtSply.Text);

            txtPid.Text = "";
            txtPName.Text = "";
            txtQty.Text = "";
            txtSply.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.delete(txtPid.Text);
            txtPid.Text = "";
            txtPName.Text = "";
            txtQty.Text = "";
            txtSply.Text = "";
        }

        private void Dgv()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RMS", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            

        }
        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                txtPid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtPName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtQty.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtSply.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch { }
        }
        private void btnRefresh_Click(object sender, EventArgs e) // Loading Sql Table on Button Click Event
        {
              
            Dgv();
        }


       
    }
}