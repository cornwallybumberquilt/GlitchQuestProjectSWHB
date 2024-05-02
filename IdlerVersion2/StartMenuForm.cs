using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Glitchquest
{
    
    public partial class NavigationMenuForm : Form
    {
        public NavigationMenuForm()
        {
            Text = "Welcome to Glitchquest!";
            Size = new Size(700, 700);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;
            //BackColor = Color.FromArgb(41, 44, 51);
            BackgroundImage = Properties.Resources.StartMenuBackground;
            BackgroundImageLayout = ImageLayout.Stretch;

            InitializeControls();
        }

        private void InitializeControls()
        {
            

            // new game button
            Button btnNewGame = new Button();
            btnNewGame.Text = "New Game";
            btnNewGame.Size = new Size(180, 70);
            btnNewGame.Left = (this.ClientSize.Width - btnNewGame.Width) / 2;
            btnNewGame.Top = 350;
            btnNewGame.BackColor = Color.FromArgb(30, 30, 30);
            btnNewGame.ForeColor = Color.White; 
            btnNewGame.Font = new Font(btnNewGame.Font.FontFamily, 12, FontStyle.Bold); 
            btnNewGame.FlatStyle = FlatStyle.Flat;
            btnNewGame.FlatAppearance.BorderSize = 0;
            btnNewGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60); // Set hover color
            btnNewGame.Click += BtnNewGame_Click;

            // load game button 
            Button btnLoadGame = new Button();
            btnLoadGame.Text = "Load Game";
            btnLoadGame.Size = new Size(180, 70);
            btnLoadGame.Left = (this.ClientSize.Width - btnLoadGame.Width) / 2;
            btnLoadGame.Top = btnNewGame.Top + btnNewGame.Height + 20;
            btnLoadGame.BackColor = Color.FromArgb(139, 0, 0); 
            btnLoadGame.ForeColor = Color.White; 
            btnLoadGame.Font = new Font(btnLoadGame.Font.FontFamily, 12, FontStyle.Bold); 
            btnLoadGame.FlatStyle = FlatStyle.Flat;
            btnLoadGame.FlatAppearance.BorderSize = 0;
            btnLoadGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 0, 0); 
            btnLoadGame.Click += BtnLoadGame_Click;

        
            Controls.Add(btnNewGame);
            Controls.Add(btnLoadGame);
        }

        // new game function 
        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            
            string rowsInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of rows:", "New Game", "10");
            string columnsInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of columns:", "New Game", "10");
            int rows, columns;
            // Check if the input is valid
            if (int.TryParse(rowsInput, out rows) && int.TryParse(columnsInput, out columns))
            {
               
                Blip blip = new Blip();
                World world = new World(100, rows, columns, blip);

                Hide();
                WorldView mainGame = new WorldView(world);
                mainGame.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for rows and columns.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        // load game function
        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {


                        // deserialized json world object
                        World loadedWorld = World.Load(openFileDialog.FileName);
                        WorldView mainGame = new WorldView(loadedWorld);
                        mainGame.Show();

                  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

