using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void toolStripButtonFencing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("现在进入击剑环节");
        }

        private void toolStripButtonSwimming_Click(object sender, EventArgs e)
        {
            MessageBox.Show("现在进入游泳环节");
        }

        


    }
}
