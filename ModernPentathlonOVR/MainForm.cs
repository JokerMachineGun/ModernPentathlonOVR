using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ModernPentathlonOVR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BasicClass.DbBasic.getConnection();
            if (BasicClass.DbBasic.connection.State == ConnectionState.Open)
            {
                MessageBox.Show("数据库建立连接成功");
            }
            else
                MessageBox.Show("数据库建立连接失败");
            
        }

        private void toolStripButtonSwimming_Click(object sender, EventArgs e)
        {
            MessageBox.Show("进入游泳项目");
            this.tabControlMain.SelectedIndex = 0;
        }

        private void toolStripButtonFencing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("进入击剑项目");
            this.tabControlMain.SelectedIndex = 1;
        }

        private void toolStripButtonHorsemanship_Click(object sender, EventArgs e)
        {
            MessageBox.Show("进入马术项目");
            this.tabControlMain.SelectedIndex = 2;
        }

        private void ImportAthelteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
            openFile.Multiselect = false;
            string excelName = "";
            if (openFile.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            excelName = openFile.FileName;
            string connectionString = "";
            if (excelName.EndsWith(".xls"))
            {
                connectionString = "Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source =" + excelName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
            }
            else if (excelName.EndsWith(".xlsx"))
            {              
                connectionString = "Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =" + excelName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1'";
            }
            else
            {
                MessageBox.Show("不是Excel文件\n" + excelName);
                return;
            }
            OleDbConnection oleConn = null;
            try
            {
                using(oleConn=new OleDbConnection(connectionString))
                {
                    oleConn.Open();
                    string sql = "Select * From [成绩$A:Z]";
                    OleDbCommand cmd = new OleDbCommand(sql, oleConn);
                    OleDbDataReader odr = cmd.ExecuteReader();
                    DataTable dt = new DataTable("dt");
                    //将Excel的数据插入到DataTable
                    dt.Load(odr);
                    MessageBox.Show("是否插入 ！");
                    odr.Close(); 
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
