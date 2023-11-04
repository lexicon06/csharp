using System.Data;

namespace Note_Taking
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dt = new DataTable();
            dt.Columns.Add("Title", typeof(String));
            dt.Columns.Add("Message", typeof(String));
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Message"].Width = 177;

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMsg.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text.Length > 0 && txtMsg.Text.Length > 0) { 
            dt.Rows.Add(txtTitle.Text, txtMsg.Text);
            txtTitle.Clear();
            txtMsg.Clear();
            }
            else
            {
                // Handle the case when is empty
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            int? index = dataGridView1.CurrentCell?.RowIndex;
            if (index.HasValue)
            {
                txtTitle.Text = dt.Rows[index.Value]["Title"].ToString();
                txtMsg.Text = dt.Rows[index.Value]["Message"].ToString();
            }
            else
            {
                // Handle the case when index is null
                MessageBox.Show("Please add some info in order to read");
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int? index = dataGridView1.CurrentCell?.RowIndex;
            if (index.HasValue)
            {
                dt.Rows[index.Value].Delete();
            }
            else
            {
                // Handle the case when index is null
                MessageBox.Show("Doh, You cannot delete the emptiness.");
            }

        }
    }
}