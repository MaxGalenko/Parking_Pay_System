using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stellar_Parking
{
    public partial class LanguagesSelectionPage : Form
    {
        public LanguagesSelectionPage()
        {
            InitializeComponent();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            
            switch (languageComboBox.SelectedIndex)
            {
                case 0: changeLanguage.UpdateConfig("language", "en");
                        Application.Restart();
                        break;

                case 1: changeLanguage.UpdateConfig("language", "fr-Ca");
                        Application.Restart();
                        break;
                case 2: changeLanguage.UpdateConfig("language", "es");
                        Application.Restart();
                        break;
            }
        }
    }
}
