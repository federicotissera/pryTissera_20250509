using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTissera_20250509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHeroes.Items.Add("Superman");
            cmbHeroes.Items.Add("Batman");
            cmbHeroes.Items.Add("Goku");
        }

        private void cmbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string heroe = cmbHeroes.SelectedItem.ToString();

            switch(heroe)
            {
                case "Superman":


                    return;
                case "Batman":



                    return;
                case "Goku":



                    return;
                default:
                    return;
            }
        }
    }
}
