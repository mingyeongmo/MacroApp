using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data.SqlClient;
using System.OracleDBManager;

namespace MacroApp
{
    public partial class Form2 : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public Form2()
        {
            InitializeComponent();
        }

        private static void ConnectToDB()
        {
            while (OracleDBManager.Instance.GetConnection() == false)
            {
                MessageBox.Show("Database Connected Fail...");

                return;
            }

            MessageBox.Show("Database Connected Success!!");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Data_View_Load();
                Data_View_Design();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Data_View_Design()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dataGridView1.DefaultCellStyle.Font = new Font("굴림", 11, FontStyle.Bold);

                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dataGridView1.BackgroundColor = Color.White;

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 11, FontStyle.Bold);

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 50, 72);

                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 50, 72);
                dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("굴림", 11, FontStyle.Bold);
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Data_View_Load()
        {
            try
            {
                string query = @"SELECT * FROM VALUE";

                DataSet ds = new System.Data.DataSet();
                OracleDBManager.Instance.ExecuteDsQuery(ds, query);

                if (ds = null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return;

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
