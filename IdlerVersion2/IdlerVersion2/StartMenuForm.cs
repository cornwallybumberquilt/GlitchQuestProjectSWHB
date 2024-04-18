using System;
using System.Drawing;
using System.Windows.Forms;

namespace IdlerVersion2
{
    public partial class NavigationMenuForm : Form
    {
        public NavigationMenuForm()
        {
            Text = "Idler Game Menu";
            Size = new Size(500, 350);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(41, 44, 51);

            InitializeControls();
        }

        private void InitializeControls()
        {
            // Heading label
            Label lblHeading = new Label();
            lblHeading.Text = "Welcome to Idler!";
            lblHeading.ForeColor = Color.White; // Set text color
            lblHeading.Font = new Font(lblHeading.Font.FontFamily, 18, FontStyle.Bold);
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            lblHeading.Size = new Size(400, 50);
            lblHeading.Location = new Point((ClientSize.Width - lblHeading.Width) / 2, 20);

            // new game button
            Button btnNewGame = new Button();
            btnNewGame.Text = "New Game";
            btnNewGame.Size = new Size(150, 40);
            btnNewGame.Location = new Point(175, 100);
            btnNewGame.BackColor = Color.FromArgb(46, 204, 113); // Set button color
            btnNewGame.ForeColor = Color.White; // Set text color
            btnNewGame.Font = new Font(btnNewGame.Font.FontFamily, 12, FontStyle.Bold); // Set font
            btnNewGame.FlatStyle = FlatStyle.Flat;
            btnNewGame.FlatAppearance.BorderSize = 0;
            btnNewGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96); // Set hover color
            btnNewGame.Click += BtnNewGame_Click;

            // load game button 
            Button btnLoadGame = new Button();
            btnLoadGame.Text = "Load Game";
            btnLoadGame.Size = new Size(150, 40);
            btnLoadGame.Location = new Point(175, 160);
            btnLoadGame.BackColor = Color.FromArgb(52, 152, 219); // Set button color
            btnLoadGame.ForeColor = Color.White; // Set text color
            btnLoadGame.Font = new Font(btnLoadGame.Font.FontFamily, 12, FontStyle.Bold); // Set font
            btnLoadGame.FlatStyle = FlatStyle.Flat;
            btnLoadGame.FlatAppearance.BorderSize = 0;
            btnLoadGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185); // Set hover color
            btnLoadGame.Click += BtnLoadGame_Click;

            // continue game button
            Button btnContinueGame = new Button();
            btnContinueGame.Text = "Continue Game";
            btnContinueGame.Size = new Size(150, 40);
            btnContinueGame.Location = new Point(175, 220);
            btnContinueGame.BackColor = Color.FromArgb(231, 76, 60); // Set button color
            btnContinueGame.ForeColor = Color.White; // Set text color
            btnContinueGame.Font = new Font(btnContinueGame.Font.FontFamily, 12, FontStyle.Bold); // Set font
            btnContinueGame.FlatStyle = FlatStyle.Flat;
            btnContinueGame.FlatAppearance.BorderSize = 0;
            btnContinueGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43); // Set hover color
            btnContinueGame.Click += BtnContinueGame_Click;

            // Add controls to form controls collection
            Controls.Add(lblHeading);
            Controls.Add(btnNewGame);
            Controls.Add(btnLoadGame);
            Controls.Add(btnContinueGame);
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            Blip blip = new Blip(5, 1);
            World world = new World(100, 10, 10, blip);
            WorldView mainGame = new WorldView(world);

            // Close the current form
            this.Close();

            mainGame.Show();
        }

        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading a saved game...");
        }

        private void BtnContinueGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continuing the game...");
        }
    }
}
