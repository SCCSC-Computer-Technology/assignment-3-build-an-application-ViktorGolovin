using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Viktor Golovin
//CPT 206 A01S
//Lab 3
// 2/7/24
//Unfinished program but heres my database
namespace testtttt

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

       
        //fill data grid
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDataSet.States);

        }
        //sort states in ascending order by letter
        private void sortAsc_Click(object sender, EventArgs e)
        {
            this.statesTableAdapter.SortAsc(this.statesDataSet.States);
        }
        //sort states in descending order by letter
        private void button1_Click(object sender, EventArgs e)
        {
            this.statesTableAdapter.SortDesc(this.statesDataSet.States);
        }
        //medians <=65,000
        private void button2_Click(object sender, EventArgs e)
        {
            this.statesTableAdapter.higherMedian(this.statesDataSet.States);
        }
        //average median of all states
        private void avgMedian_Click(object sender, EventArgs e)
        {
            decimal ScalarQuery;
            ScalarQuery = (decimal)
            this.statesTableAdapter.ScalarQuery();
            MessageBox.Show("Average Median of all States is: " + ScalarQuery.ToString("c"));
        }
        //exit button
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfinished, I know, sorry. I severely" +
                " underestimated the amount of time this would take and was working but I didn't want to waste " +
                "the database I spent so much time making so here's a overly simplified version of the program" +
                " with some filter options ;(" 
                );
            this.Close();
        }
    }
}
