using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SaleSysDIL;
using SaleSysBIL;
using SaleSysEL;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strsql = "select * from Company";
            DataSet ds = new DataSet();
            ds = SqlHelper.ExcuteDataSet(strsql,null,"com");
            this.dataGridView1.DataSource = com.SelectAll();
            //dataGridView1.DataBindings;

            IList<Company> Tempcom = new List<Company>();
            comboBox1.DataSource = com.SelectAll();
            comboBox1.DisplayMember = "cname";
        }

        Companys com = new Companys();
        public IList<Company> GetAll()
        {
            return com.SelectAll();
        }
    }
}