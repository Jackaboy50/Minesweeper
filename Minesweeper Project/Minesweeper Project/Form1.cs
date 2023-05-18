using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_Project
{
    public partial class Form1 : Form
    {
        public bool begin = false;
        public bool flagged = false;
        public bool firstpress = true;
        public int flagNumber = 0;
        public int flaggedMines = 0;
        public int mines = 0;
        public int difficulty = 0;

        public Bitmap mineImage = new Bitmap("mine2.png");
        public Bitmap flagImage = new Bitmap("flag.png");
        List<Button> buttonList = new List<Button>();
        List<Tile> gameBoard = new List<Tile>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BuildGame()
        {
            int offsetX = 100;
            int initialOffsetX = 0;
            int offsetY = -1;
            int number = 1;
            int setter = 0;
            int tileX = 0;
            int tileY = 0;
            int divisor = 0;
            int boardSize = 0;
            switch (difficulty)
            {
                case 1:
                    divisor = 7;
                    boardSize = 49;
                    offsetX = 125;
                    break;

                case 2:
                    divisor = 8;
                    boardSize = 64;
                    offsetX = 100;
                    break;

                case 3:
                    divisor = 9;
                    boardSize = 81;
                    offsetX = 80;
                    
                    break;

                case 4:
                    divisor = 10;
                    boardSize = 100;
                    offsetX = 50;
                    offsetY = -20;
                    break;
            }
            initialOffsetX = offsetX;

            for (int i = 0; i < boardSize; i++)
            {
                buttonList.Add(new Button());
            }

            Random random = new Random();
            foreach (Button button in buttonList)
            {
                if (setter % divisor == 0)
                {
                    offsetY += 50;
                    offsetX = initialOffsetX;
                    tileY++;
                    tileX = 1;
                }
                button.Size = new Size(40, 40);
                button.Location = new Point(offsetX, offsetY);
                Controls.Add(button);
                button.MouseDown += new MouseEventHandler(Click);
                button.Name = number.ToString();
                button.ForeColor = Color.Orange;
                button.BackColor = Color.White;
                Console.WriteLine(number.ToString());
                int mineCount = random.Next(0, 100);

                if (mineCount < 25)
                {
                    gameBoard.Add(new Tile(tileX, tileY, number.ToString(), number, true, false));
                    flagNumber++;
                    mines++;
                }
                else
                {
                    gameBoard.Add(new Tile(tileX, tileY, number.ToString(), number, false, false));
                }

                offsetX += 50;
                number++;
                setter++;
                tileX++;
            }
        }

        private void Click(object sender, MouseEventArgs @event)
        {
            Button button = (sender as Button);
            Tile tile = FindTile(button);
            if(firstpress == true)
            {
                tile.ismine = false;
                RemoveMines(tile);
                flagnum.Text = flagNumber.ToString();
                firstpress = false;
            }
            Console.WriteLine(tile.xcoord.ToString());
            Console.WriteLine(tile.ycoord.ToString());

            if (@event.Button == MouseButtons.Right)
            {
                if (button.BackColor == Color.White && flagNumber != 0)
                {
                    button.BackgroundImage = flagImage;
                    button.BackColor = Color.Black;
                    flagNumber = flagNumber - 1;
                    flagnum.Text = flagNumber.ToString();
                    if(tile.ismine == true)
                    {
                        flaggedMines++;
                    }
                    if (flaggedMines == mines)
                    {
                        title.Text = "You Win!";
                        EndGame();
                    }
                }
                else if (button.BackColor == Color.Black && button.BackgroundImage == flagImage)
                {
                    button.Text = " ";
                    button.BackgroundImage = null;
                    button.BackColor = Color.White;
                    flagNumber = flagNumber + 1;
                    if(tile.ismine == true)
                    {
                        flaggedMines++;
                    }
                    flagnum.Text = flagNumber.ToString();
                }
            }
            
            if (@event.Button == MouseButtons.Left)
            {
                if (button.BackgroundImage != flagImage && button.BackColor != Color.Black)
                {
                    if(flaggedMines == mines)
                    {
                        title.Text = "You Win";
                        EndGame();
                    }
                    if (tile.ismine == false)
                    {
                        int mineNumber = MineCheck(tile);
                        if (mineNumber == 0)
                        {
                            button.Text = " ";
                            TileClear(button);
                        }
                        else
                        {
                            button.Text = mineNumber.ToString();
                        }
                        button.BackColor = Color.Black;
                    }

                    if (tile.ismine == true)
                    {
                        button.Text = " ";
                        title.Text = "Game Over";
                        EndGame();
                    }
                }
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        #region Find Functions
        private Tile FindTile(Button b)
        {
            foreach(Tile a in gameBoard)
            {
                if(b.Name == a.name)
                {
                    return a;
                }
            }
            return null;  
        }

        private Button FindButton(Tile b)
        {
            foreach(Button a in buttonList)
            {
                if(b.name == a.Name)
                {
                    return a;
                }
            }
            return null;
        }
        private Tile FindTileXY(int xnum, int ynum)
        {
            foreach (Tile a in gameBoard)
            {
                if (xnum == a.xcoord && ynum == a.ycoord)
                {
                    return a;
                }
            }
            return null;
        }
        #endregion

        private int MineCheck(Tile tile)
        {
            int mineCount = 0;
            int xCoord = tile.xcoord;
            int yCoord = tile.ycoord;
            for(int x = -1; x < 2; x++)
            {
                for(int y = 1; y > -2; y--)
                {
                    if (FindTileXY(xCoord + x, yCoord + y) != null && FindTileXY(xCoord + x, yCoord + y).ismine == true)
                    {
                        mineCount++;
                    }
                }
            }
            return mineCount;
        }

        private void RemoveMines(Tile tile)
        {
            int xCoord = tile.xcoord;
            int yCoord = tile.ycoord;
            for (int x = -1; x < 2; x++)
            {
                for (int y = 1; y > -2; y--)
                {
                    if (FindTileXY(xCoord + x, yCoord + y) != null && FindTileXY(xCoord + x, yCoord + y).ismine == true)
                    {
                        FindTileXY(xCoord + x, yCoord + y).ismine = false;
                        flagNumber--;
                    }
                }
            }
        }

        private void TileClear(Button button)
        {
            Tile tile = FindTile(button);
            int xCoord = tile.xcoord;
            int yCoord = tile.ycoord;
            for (int x = -1; x < 2; x++)
            {
                for (int y = 1; y > -2; y--)
                {
                    if(FindTileXY(xCoord + x, yCoord + y) == null)
                    {
                        continue;
                    }
                    Button tempButton = FindButton(FindTileXY(xCoord + x, yCoord + y));
                    if (tempButton.BackgroundImage != flagImage && tempButton.BackColor != Color.Black)
                    {
                        if (tile.ismine == false)
                        {
                            int mineNumber = MineCheck(FindTile(tempButton));
                            if (mineNumber == 0)
                            {
                                tempButton.Text = " ";
                                tempButton.BackColor = Color.Black;
                                TileClear(tempButton);
                            }
                            else
                            {
                                tempButton.Text = mineNumber.ToString();
                                tempButton.BackColor = Color.Black;
                            }
                        }
                    }
                }
            }
        }

        private void EndGame()
        {
            foreach (Button end in buttonList)
            {
                Tile endt = FindTile(end);
                if (endt.ismine == false)
                {
                    int mineno = MineCheck(endt);
                    if (mineno == 0)
                    {
                        end.Text = " ";
                    }
                    else
                    {
                        end.Text = mineno.ToString();
                    }

                    end.BackColor = Color.Black;
                }
                if (endt.ismine == true)
                {
                    end.Text = " ";
                    end.BackgroundImage = mineImage;
                    end.BackColor = Color.Black;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            Dispose(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region Difficulty Buttons
        private void Difficulty49Button(object sender, EventArgs e)
        {
            difficulty = 1;
            BuildGame();
            difficultyp.Hide();
        }

        private void Difficulty64Button(object sender, EventArgs e)
        {
            difficulty = 2;
            BuildGame();
            difficultyp.Hide();
        }

        private void Difficulty81Button(object sender, EventArgs e)
        {
            difficulty = 3;
            BuildGame();
            difficultyp.Hide();
        }

        private void Difficulty100Button(object sender, EventArgs e)
        {
            difficulty = 4;
            BuildGame();
            difficultyp.Hide();
        }
        #endregion
    }
}
