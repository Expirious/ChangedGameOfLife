using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace GameOfLife
{
    internal class GameEngine
    {
        public uint currentGeneration { get; private set; }
        public int races { get; private set; }
        private int[,] field;
        private readonly int cols;
        private readonly int rows;
        private readonly int density;

        public GameEngine(int cols, int rows, int density, int races)
        {
            this.cols = cols;
            this.rows = rows;
            field = new int[cols, rows];

            this.races = races;
            this.density = density;
        }

        public void FirstGeneration()
        {
            Random random = new Random();

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int value = random.Next(density + races);

                    if (value > races)
                        field[x, y] = 0;

                    else
                        field[x, y] = value;
                }
            }
        }

        public void NextGeneration()
        {
            var newField = new int[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighbours = CountNeighbours(x, y);
                    newField[x, y] = RulesForNextGeneration(field[x, y], neighbours);
                }
            }

            field = newField;
            currentGeneration++;
        }

        private int RulesForNextGeneration(int value, int[] neighbours)
        {
            switch (races)
            {
                case 1:

                    if (value == 0 && neighbours[0] == 2)
                        return 1;

                    else if (value == 1 && (neighbours[0] < 4 || neighbours[0] > 3))
                        return 0;

                    else
                        return value;


                case 2:

                    if (value > 0 && ((neighbours[0] + neighbours[1]) > 3
                        || (neighbours[0] + neighbours[1]) < 2))
                        return 0;

                    else if (value == 1 && (neighbours[0] < 2 || neighbours[0] > 3))
                        return 1;

                    else if (value == 2 && (neighbours[1] < 2 || neighbours[1] > 3))
                        return 2;

                    else if (value == 0 && neighbours[0] == 3)
                        return 1;

                    else if (value == 0 && neighbours[1] == 3)
                        return 2;
                    else
                        return value;

                case 3:

                    if (value > 0 && (((neighbours[0] + neighbours[1] + neighbours[2]) > 3)
                      || ((neighbours[0] + neighbours[1] + neighbours[2]) < 2)))
                        return 0;

                    else if (value == 1 && (neighbours[0] < 2 || neighbours[0] > 3))
                        return 1;

                    else if (value == 2 && (neighbours[1] > 2 || neighbours[1] > 3))
                        return 2;

                    else if (value == 2 && (neighbours[2] > 2 || neighbours[2] > 3))
                        return 3;

                    else if (value == 0 && neighbours[0] == 3)
                        return 1;

                    else if (value == 0 && neighbours[1] == 3)
                        return 2;

                    else if (value == 0 && neighbours[2] == 3)
                        return 3;
                    
                    else
                        return value;

                default:
                    return 0;
            }
        }

        public int[,] GetCurrentGeneration()
        {
            var result = new int[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = field[x, y];
                }
            }

            return result;
        }

        private int[] CountNeighbours(int x, int y)
        {
            int[] counter = new int[3];

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife == 1 && !isSelfChecking)
                        counter[0]++;

                    else if (hasLife == 2 && !isSelfChecking)
                        counter[1]++;

                    else if (hasLife == 3 && !isSelfChecking)
                        counter[2]++;
                }
            }

            return counter;
        }

        public void KillHalfPopulation(int percent)
        {
            Random random = new Random();
            int countLife = (int)(CountLife() * percent * 0.01);
            int randomX, randomY;

            while (countLife > 0)
            {
                randomX = random.Next(0, cols);
                randomY = random.Next(0, rows);

                if (field[randomX, randomY] > 0)
                {
                    field[randomX, randomY] = 0;
                    countLife--;
                }
            }
        }

        public int CountLife()
        {
            int lifeCount = 0;

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (field[x, y] != 0)
                        lifeCount++;
                }
            }

            return lifeCount;
        }
        
        public bool HasLife()
        {
            return CountLife() > 0;
        }

        public void ResetGeneration()
        {
            currentGeneration = 0;
        }

        public void ClearField()
        {
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = 0;
                }
            }

            ResetGeneration();
        }

        public void DrawPatttern(int pattern)
        {
            ClearField();

            switch (pattern)
            {
                case 1:

                    for (int x = cols / 2 - 2; x < cols / 2 + 3; x++)
                        field[x, rows / 2] = 1;

                    break;

                case 2:

                    for (int x = cols / 2 - 1; x < cols / 2 + 1; x++)
                    {
                        for (int y = rows / 2 - 1; y < rows / 2 + 1; y++)
                        {
                            field[x, y] = 1;
                        }
                    }

                    break;

                default:
                    break;
            }
        }

        private bool ValidateCellPosition(int x, int y)
        {
            return x > 0 && x < cols && y > 0 && y < rows;
        }

        private void UpdateCell(int x, int y, int state)
        {
            if (ValidateCellPosition(x, y))
                field[x, y] = state;
        }

        public void AddCell(int x, int y, int race = 1)
        {
            UpdateCell(x, y, race);
        }

        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, 0);
        }
    }
}
