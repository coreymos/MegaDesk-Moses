using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Moses
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            _deskQuote = deskQuote;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            // Display _deskQuote details on the form
            lblCustomerName.Text = _deskQuote.GetName();
            lblDrawers.Text = _deskQuote.GetDesk().NumberOfDrawers.ToString();
            lblMaterial.Text = _deskQuote.GetDesk().Material.ToString();
            lblRushDays.Text = _deskQuote.GetRushDays().ToString(); 

            // Display Dates
            lblStartDate.Text = _deskQuote.GetQuoteDate().ToString("dd MMMM yyyy");
            lblEndDate.Text = _deskQuote.GetEstimatedCompletionDate().ToString("dd MMMM yyyy");

            // Calculate Surface Area
            double surfaceArea = _deskQuote.GetDesk().GetSurfaceArea();

            // Display Surface Area
            lblSurfaceArea.Text = $"{surfaceArea.ToString("N2")} in\u00B2";

            // Calculate Quote Total Amount
            lblQuoteAmount.Text = $"${_deskQuote.GetQuote().ToString("N2")}";
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
