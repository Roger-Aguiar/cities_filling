using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitiesAndStatesFilling
{
    public partial class FormCitiesReader : Form
    {
        public FormCitiesReader()
        {
            InitializeComponent();
        }

        private void buttonInsertCities_Click(object sender, EventArgs e)
        {
            CitiesOperations citiesOperations = new CitiesOperations();
            citiesOperations.Insert();
            MessageBox.Show("All the cities were added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
