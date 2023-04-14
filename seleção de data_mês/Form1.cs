using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seleção_de_data_mês
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicial.Text = monthCalendar.SelectionStart.ToShortDateString();
            final.Text = monthCalendar.SelectionEnd.ToShortDateString();
            atual.Text = monthCalendar.TodayDate.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           inicial.Clear(); 
            final.Clear();
            atual.Clear();
            datainicial.Clear();
            datafinal.Clear();
            dataatual.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            datainicial.Text = monthCalendar.SelectionStart.ToShortDateString();
            datafinal.Text = monthCalendar.SelectionEnd.ToString();
            dataatual.Text = monthCalendar.TodayDate.ToString();    
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "Restaurar") 
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString()== "Mensagem")
            {
                MessageBox.Show("Você está lendo essa mensagem");
            }
        }
    }
}
