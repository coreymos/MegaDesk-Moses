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
    public partial class AddQuote : Form
    {

        private DateTime quoteDate;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            quoteDate = DateTime.Now;
            dateLabel.Text = quoteDate.ToString("dd MMMM yyyy");
            MaterialComboBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void DeskWidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DeskWidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(DeskWidthTextBox.Text, out int width) || width < Desk.MIN_WIDTH || width > Desk.MAX_WIDTH)
            {
                widthErrorProvider.SetError(DeskWidthTextBox, $"Width must be an integer between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH}.");
                e.Cancel = true;
            }
            else
            {
                widthErrorProvider.SetError(DeskWidthTextBox, string.Empty);
            }
        }

        private void DeskDepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DeskDepthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(DeskDepthTextBox.Text, out int depth) || depth < Desk.MIN_DEPTH || depth > Desk.MAX_DEPTH)
            {
                depthErrorProvider.SetError(DeskDepthTextBox, $"Depth must be an integer between {Desk.MIN_DEPTH} and {Desk.MAX_DEPTH}.");
                e.Cancel = true;
            }
            else
            {
                depthErrorProvider.SetError(DeskDepthTextBox, string.Empty);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather input and create Desk and DeskQuote objects
                Desk desk = new Desk();
                desk.Width = int.Parse(DeskWidthTextBox.Text);
                desk.Depth = int.Parse(DeskDepthTextBox.Text);
                desk.NumberOfDrawers = int.Parse(DrawersComboBox.SelectedItem.ToString());
                desk.Material = (DesktopMaterial)MaterialComboBox.SelectedItem;

                DeskQuote deskQuote = new DeskQuote(desk, CustomerNameTextBox.Text, int.Parse(RushOrderComboBox.SelectedItem.ToString()), quoteDate);

                // Open DisplayQuote form
                DisplayQuote displayQuoteForm = new DisplayQuote(deskQuote);
                displayQuoteForm.Show();
                Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for width, depth, and number of drawers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
