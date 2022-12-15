using InvestME.DAL;
using InvestME.DAL.Models;
using InvestME.Manager.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestME.Manager.Forms
{
    public partial class FormImportData : Form
    {
        List<Acoes> Acoes = new List<Acoes> { };
        public FormImportData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable excel = default(DataTable);
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    excel = Excel.GetInvestiments(openFileDialog1.FileName);
                                      
                    for(int i =0; i <= excel.Rows.Count; i++)
                    {
                        object cellValue = excel.Rows[i].ItemArray[1];
                        MessageBox.Show(cellValue.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
