using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //Dllimport
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Threading;
using System.Data.SqlClient;

namespace MacroApp
{
    public partial class Form1 : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        //Tick을 1씩 늘리며 작업
        int Tick = 0;       

        
        
      
        [DllImport("user32.dll")]

        //외부 메서드(마우스 클릭에 이용)
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtralnfo);
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        OracleCommand cmd = new OracleCommand();
        string sql2 = "";
        string sql = "";

        //이 클래스의 기본적인 생성자
        public Form1()
        {
            InitializeComponent();

            cmd.Connection = con;
            
            con.Open();


        }


        private void Timer_Tick(object sender, EventArgs e) 
        {

            Tick++;


            int wantX = 0;
            int wantY = 0;
            int wantT = 0;
            Int32.TryParse(want_x.Text, out wantX);
            Int32.TryParse(want_y.Text, out wantY);
            Int32.TryParse(want_time.Text, out wantT);
            if (wantT == 0)
            {
                wantT = 1;

            }
            
            
            if(Tick <= wantT)
            {
                Cursor.Position = new Point(wantX, wantY);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);

            }



        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            //현재 마우스 커서 좌표값 
            label_x.Text = Cursor.Position.X.ToString();
            label_y.Text = Cursor.Position.Y.ToString();
        }

        //폼 로딩
        private void Form1_Load_1(object sender, EventArgs e)
        {
   
        }

        //timer_tick실행
        private void start_Click_1(object sender, EventArgs e)
        {
             this.KeyPreview=true;
            timer1.Enabled = true;
            //string sql = $"insert into location value({want_x.Text},{want_y.Text},{want_time.Text})";
            sql2 = $"UPDATE value SET XVALUE = {want_x.Text}, YVALUE = {want_y.Text}, TVALUE = {want_time.Text}";
            //int i = Convert.ToInt32(want_time.Text);


            cmd.CommandText = sql2;
            cmd.ExecuteNonQuery();


        
            //timer1.Enabled = false;
        }

        //timer_tick중지
        private void stop_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Tick = 0;

        }

        //탐색 중지 클릭
        private void see_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;


        }

        //탐색 시작 클릭
        private void see_yes_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;

        }



        private void key_down(object sender, KeyEventArgs e)
        {
           
            timer1.Enabled = false;
            Tick = 0;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void want_x_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.ShowDialog();
            //sql = $"SELECT * FROM VALUE where id = 1";
            //OracleCommand cmd2 = new OracleCommand();
            //cmd2.CommandText = sql;
            ////cmd2.ExecuteNonQuery();
            //MessageBox.Show(sql);
            //string sql = $"UPDATE location SET XVALUE = " + want_x.Text + ", YVALUE =" + want_y.Text + ", TVALUE = " + want_time.Text + ")";

            //cmd.CommandText = "select * from value";

            //SqlDataReader reader = cmd.ExecuteReader();

            //while(reader.Read())
            //{

            //}
            //reader.Close();

            //string text = $"Select * from value where = 1";
            //string constr = @"Data Source=XE;Initial Catalog=Macro'Integrated Security=True;Pooling=False;";

            //SqlConnection scon = new SqlConnection(constr);
            //SqlCommand command = new SqlCommand(text, scon);
            //scon.Open();
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    ("이것은 {x}", reader["XVALUE"]);
            //}
            //reader.Close();
            //scon.Close();

            //string sql = $"UPDATE location SET XVALUE = "+want_x.Text+", YVALUE ="+ want_y.Text +", TVALUE = "+ want_time.Text+")";
            //string sql = "SELECT * FROM value WHERE ID = 1;";
            //try
            //{
            //    using(OracleConnection conn = new OracleConnection("......"))
            //    using(OracleCommand cmd = new OracleCommand("select * from value",conn))
            //    {
            //        con.Open();
            //        using(OracleDataReader reader = cmd.ExecuteReader())
            //        {
            //            DataTable dataTable = new DataTable();
            //            dataTable.Load(reader);
            //            
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("hihi");
            //}
            ////OracleCommand cmd = new OracleCommand(sql, con);

            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        private void winform_close_Click(object sender, EventArgs e)
        {
            con.Close();
            Application.ExitThread();

            Environment.Exit(0);
        }

        private void stop_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }
    }
}
