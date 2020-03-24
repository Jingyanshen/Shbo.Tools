using System;
using System.Data;
using System.Windows.Forms;
using Shbo.Tools.Hardware;
using Shbo.Tools.Security;

namespace ComEnvInf
{
    public partial class ComEnvInf : Form
    {
        public ComEnvInf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = (SystemInfo.MemoryAvailable / 1024.00 / 1024.00 /1024.00).ToString("0.00");//获取内容信息
            //string inputdata = textBox1.Text;
            //DataSet dt = new DataSet() ;
            //string error = "";
            //bool state = DataOper.Decompress(inputdata,ref dt,ref error);
            //MessageBox.Show(state ? "success":error);
        }
    }
}
