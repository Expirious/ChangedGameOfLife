using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private GameEngine gameEngine;
        private bool gameIsOn = false;
        private bool hasLife = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return;


            spawnRaceComboBox.Enabled = true;
            resolutionNumericUpDown.Enabled = false;
            densityNumericUpDown.Enabled = false;
            racesNumericUpDown.Enabled = false;
            killNumericUpDown.Enabled = true;

            resolution = (int)resolutionNumericUpDown.Value;

            if (!gameIsOn)
            {
                gameEngine = new GameEngine
               (
                   cols: pictureBox1.Width / resolution,
                   rows: pictureBox1.Height / resolution,
                   density: (int)densityNumericUpDown.Minimum + (int)densityNumericUpDown.Maximum - (int)densityNumericUpDown.Value,
                   races: (int)racesNumericUpDown.Value
               );

                gameIsOn = true;
            }

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            Text = $"Generation {gameEngine.currentGeneration}";

            startButton.Enabled = false;
            stopButton.Enabled = true;
            killPopulationButton.Enabled = true;
            clearButton.Enabled = true;
            resetButton.Enabled = true;

            if (!hasLife)
                generateButton.Enabled = true;

            if (gameEngine.races == 1)
            {
                pattern1Button.Visible = true;
                pattern2Button.Visible = true;
            }


            timer1.Start();
        }

        private Brush PickColor(int value)
        {

            switch (value)
            {
                case 1:
                    return Brushes.Crimson;

                case 2:
                    return Brushes.Magenta;

                case 3:
                    return Brushes.MintCream;

                default:
                    return Brushes.Black;
            }
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            var field = gameEngine.GetCurrentGeneration();

            for (int x = 0;  x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y] > 0)
                    {
                        Brush color = PickColor(field[x, y]);
                        graphics.FillRectangle(color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    }
                }
            }

            pictureBox1.Refresh();
            Text = $"Generation {gameEngine.currentGeneration}";
            gameEngine.NextGeneration();
        }



        private void StopGame()
        {
            if (!timer1.Enabled)
                return;

            timer1.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            killPopulationButton.Enabled = true;
            clearButton.Enabled = true;
            killNumericUpDown.Enabled = true;
        }

        private void GenerateLife()
        {
            if (!hasLife)
            {
                gameEngine.FirstGeneration();
                DrawNextGeneration();

                hasLife = true;
                generateButton.Enabled = false;
            }
        }

        private void KillPopulation()
        {
            gameEngine.KillHalfPopulation((int)killNumericUpDown.Value);
            DrawNextGeneration();

            if (!gameEngine.HasLife())
            {
                hasLife = false;
                generateButton.Enabled = true;
            }
        }

        private void ClearGame()
        {
            gameEngine.ClearField();
            DrawNextGeneration();

            hasLife = false;
            generateButton.Enabled = true;
        }

        private void ResetGame()
        {

            spawnRaceComboBox.Enabled = false;
            resolutionNumericUpDown.Enabled = true;
            densityNumericUpDown.Enabled = true;
            racesNumericUpDown.Enabled = true;
            pattern1Button.Visible = false;
            pattern2Button.Visible = false;

            gameEngine.ResetGeneration();
            gameEngine.ClearField();
            timer1.Stop();
            DrawNextGeneration();

            startButton.Enabled = true;
            stopButton.Enabled = false;
            killPopulationButton.Enabled = false;
            clearButton .Enabled = false;
            resetButton.Enabled = false;
            generateButton.Enabled = false;

            killNumericUpDown.Enabled = false;
            hasLife = false;
            gameIsOn = false;

            spawnRaceComboBox.SelectedIndex = 0;
            Text = $"Generation {gameEngine.currentGeneration}";
        }

        private void DrawPattern(int pattern)
        {
            gameEngine.DrawPatttern(pattern);
            DrawNextGeneration();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateLife();
        }

        private void killPopulation_Click(object sender, EventArgs e)
        {
            KillPopulation();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearGame();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void pattern1Button_Click(object sender, EventArgs e)
        {
            DrawPattern(1);
        }

        private void pattern2Button_Click(object sender, EventArgs e)
        {
            DrawPattern(2);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!gameIsOn)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;

                gameEngine.AddCell(x, y, spawnRaceComboBox.SelectedIndex + 1);

                if (!timer1.Enabled) 
                {
                    Brush color = PickColor(spawnRaceComboBox.SelectedIndex + 1);
                    graphics.FillRectangle(color, x * resolution, y * resolution, resolution - 1, resolution - 1);

                    pictureBox1.Refresh();
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;

                gameEngine.RemoveCell(x, y);

                if (!timer1.Enabled)
                {
                    Brush color = Brushes.Black;
                    graphics.FillRectangle(color, x * resolution, y * resolution, resolution - 1, resolution - 1);

                    pictureBox1.Refresh();
                }
            }

        }

        private void spawnRaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                return;

            if (spawnRaceComboBox.SelectedIndex >= gameEngine.races)
                spawnRaceComboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            spawnRaceComboBox.SelectedIndex = 0;
        }
    }
}
