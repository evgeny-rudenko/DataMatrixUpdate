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
using System.IO;


namespace DataMatrixUpdate
{
    public partial class Form1 : Form
    {
        public static DataTable fillDataTable(string query)
        {

            String conSTR = Properties.Settings.Default.ConnectionString;
            SqlConnection sqlConn = new SqlConnection(conSTR);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //var dataReader = cmd.ExecuteReader(;
            //dt.Load()

            //dt.Load(dataReader);

            //sqlConn.Close();
            //da.Dispose();
            return dt;
            /*
             SqlCommand cmd = new SqlCommand(query, sqlConn);
            cmd.CommandTimeout = 0;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           
            var dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            ///
            sqlConn.Close();
            Console.WriteLine(DateTime.Now.ToString());
            return dt;
            */
        }

        public  string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        

        public  string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }


        public Form1()
        {
            InitializeComponent();
            LoadKiz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDatamatrix.Text.Length <30)
            {
                MessageBox.Show("Некорректная длина кода датаматрикс");
                return;
            }
            

            string DatamatrixBase64 = "";
            string GTIN_SGTIN = "";
            string GTIN = "";
            string SGTIN = "";
            string ID_KIZ_GLOBAL;
            GTIN = tbDatamatrix.Text.Substring(2, 14);
            SGTIN = tbDatamatrix.Text.Substring(18, 13);
            GTIN_SGTIN = GTIN + SGTIN;

            //this.gridKiz.Rows[this.gridKiz.CurrentRow.Index].Cells["ID_KIZ_GLOBAL"].Value
            //if (this.gridKiz.Rows[this.gridKiz.SelectedRows.Count].Cells["ID_KIZ_GLOBAL"].Value != null)
            if (this.gridKiz.Rows[this.gridKiz.CurrentRow.Index].Cells["ID_KIZ_GLOBAL"].Value != null)
            {
                //MessageBox.Show(this.gridKiz.Rows[this.gridKiz.CurrentRow.Index].Cells["ID_KIZ_GLOBAL"].Value.ToString());
                ID_KIZ_GLOBAL = this.gridKiz.Rows[this.gridKiz.CurrentRow.Index].Cells["ID_KIZ_GLOBAL"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Что то пошло не так");
                return;
            }

            DatamatrixBase64 = Base64Encode(tbDatamatrix.Text);
            
            rtbQuery.AppendText(Environment.NewLine);
            rtbQuery.AppendText(DatamatrixBase64);
            rtbQuery.AppendText(Environment.NewLine);
            rtbQuery.AppendText(Base64Decode(DatamatrixBase64));
            rtbQuery.AppendText(Environment.NewLine);
            rtbQuery.AppendText(GTIN);
            rtbQuery.AppendText(Environment.NewLine);
            rtbQuery.AppendText(SGTIN);
            rtbQuery.AppendText(Environment.NewLine);
            rtbQuery.AppendText(GTIN_SGTIN);


            //return; // пока не записываем ничего в бд


            var connetionString = Properties.Settings.Default.ConnectionString;
            var sql = File.ReadAllText("KIZUpdate.SQL"); //"UPDATE Employees SET LastName = @LastName, FirstName = @FirstName, Title = @Title ... ";// repeat for all variables
            try
            {
                using (var connection = new SqlConnection(connetionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        /*
                         BARCODE=@DatamatrixBase64, GTIN_SGTIN = @GTIN_SGTIN , SGTIN = @SGTIN, GTIN = @GTIN
                         */
                        command.Parameters.Add("@DatamatrixBase64", SqlDbType.NVarChar).Value = DatamatrixBase64;
                        command.Parameters.Add("@GTIN_SGTIN", SqlDbType.NVarChar).Value = GTIN_SGTIN;
                        command.Parameters.Add("@GTIN", SqlDbType.NVarChar).Value = GTIN;
                        command.Parameters.Add("@SGTIN", SqlDbType.NVarChar).Value = SGTIN;
                        command.Parameters.Add("@ID_KIZ_GLOBAL", SqlDbType.NVarChar).Value = ID_KIZ_GLOBAL;
                        //command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Titelstring;
                        // repeat for all variables....
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Failed to update. Error message: {ee.Message}");
            }
            finally
            {
                MessageBox.Show("КИЗ обновлен. Попробуйте отсканировать в АРМ кассира");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadKiz();
        }



        public void LoadKiz()
        {
            
            
            string SQLQuery = File.ReadAllText("KIZGoods.SQL");
            SQLQuery =  SQLQuery.Replace("GOODNAMESEARCH", "%"+tbGood.Text+"%");

            rtbQuery.AppendText(SQLQuery);
            DataTable kiz = fillDataTable(SQLQuery);
            this.gridKiz.DataSource = kiz;
            this.gridKiz.Refresh();

        }

        private void tbGood_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char) Keys.Enter)
            {
                LoadKiz();
            }

        }

        private void tbGood_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
