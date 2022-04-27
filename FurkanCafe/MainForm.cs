using System;
using System.Windows.Forms;
using FurkanCafe.Library.Concrete;
using FurkanCafe.Library.Enum;

namespace FurkanCafe
{
    public partial class MainForm : Form
    {
        private readonly Game _game = new Game();
        public MainForm()
        {
            InitializeComponent();
            _game.PassingTimerChanged += Game_PassingTimeChanged;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _game.Start();
                    break;
                case Keys.Left:
                    _game.MoveToRobot(Direction.Left);
                    break;
                case Keys.Right:
                    _game.MoveToRobot(Direction.Right);
                    break;
                case Keys.P:
                    _game.Pause();
                    break;
            }
        }
        private void Game_PassingTimeChanged(object sender, EventArgs e)
        {
            labelClock.Text = _game.PassingTime.ToString(@"m\:ss");
        }
    }
}
