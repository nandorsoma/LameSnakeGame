using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaSnake
{
    public partial class Form1 : Form
    {

        Snake snake;
        Food food;
        Enviroment enviroment;
        GameControl gamecontrol;
        

        public Form1()
        {
            InitializeComponent();
            snake = new Snake();
            food = new Food();
            gamecontrol = new GameControl();
            enviroment = new Enviroment();
            food.CreateFood();  // hogy a legelején legyen kaja

            // dupla bufferelés
            SetStyle(ControlStyles.DoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint,
                true);
            UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //snakecontrol.DrawAll(e);
            snake.Draw(e);
            food.Draw(e);
            enviroment.Draw(e);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            snake.Move();
            if (gamecontrol.CheckCollision(snake, food))           //ez a megoldás nekem még annyira nem tetszik, mert objektumot ad át. nem lehetne megondani enélkül, vagy jó így?
            {
                levelLabel.Text = snake.SIZE.ToString();            // ez se szép szerintem, hogy innen akarom növelni.
                // mainTimer.Interval -= 20;
            }
                
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            levelLabel.Text = snake.SIZE.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    snake.DirectionUp();
                    break;
                case Keys.A:
                    snake.DirectionLeft();
                    break;
                case Keys.D:
                    snake.DirectionRight();
                    break;
                case Keys.S:
                    snake.DirectionDown();
                    break;
                case Keys.G:
                    mainTimer.Start();
                    foodTimer.Start();
                    break;
                case Keys.H:
                    mainTimer.Stop();
                    foodTimer.Stop();
                    break;
            }
        }

        private void foodTimer_Tick(object sender, EventArgs e)
        {
            food.CreateFood();
            //snake.Eat();          
        }

    }
}
