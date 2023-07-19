using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safinalprojesi
{
    public partial class Basketball : Form

    {
        public Basketball()
           
        {
            InitializeComponent();
           
            
        
            comboBox1.Text = "THY Euroleague";

            if (comboBox1.Text == "THY Euroleague")
            {

                comboBox2.Items.Add("Fenerbahçe");
                comboBox2.Items.Add("CSKA");
                comboBox2.Items.Add("Kızılyıldız");
                comboBox2.Items.Add("Alba Berlin");
                

            }
          

           

        } 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           if (comboBox1.SelectedText == "THY Euroleauge")
            {
                System.Diagnostics.Process.Start("https://www.euroleague.net/");
            } 
           
            

        }

    }
}
