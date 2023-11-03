using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFrenzy
{
    public partial class SelectDeck : Form
    {

        public static SelectDeck selectDeckInstance = new SelectDeck();

        public SelectDeck()
        {
            //To be implemented in the next sprint.
            InitializeComponent();
            this.Text = "Select Deck";
            dataGridView1.Rows.Add(AddCard.addedTerm);
            dataGridView1.Rows.Add(AddCard.addedDefinition);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //THIS WILL BE CHANGED!!! AS OF NOW, IT REDIRECTS TO DEFAULT DECK.
            Card nextForm = new Card();
            this.Hide();
            nextForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home nextForm = new Home();
            this.Hide();
            nextForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files Only | *.xlsx; *.xls";
                ofd.Title = "Choose the file";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //FileName_LBL.Text = ofd.FileName;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*Microsoft.Office.Interop.Excel.Application xlapp;
            Microsoft.Office.Interop.Excel.Workbook xlworkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
            Microsoft.Office.Interop.Excel.Range xlrange;
            try
            {
                xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(FileName_LBL.Text);
                xlworksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlworkbook.Worksheets["Sheet1"];
                xlrange = xlworksheet.UsedRange;

                for (int xlrow = 1; xlrow <= xlrange.Rows.Count; xlrow++)
                {
                    dataGridView1.Rows.Add
                        (
                            xlrange.Cells[xlrow, 1].ToString
                            );
                }
                xlworkbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCard nextForm = new AddCard();
            nextForm.Show();
            this.Hide();
        }
    }
}
