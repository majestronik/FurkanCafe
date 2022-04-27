using FurkanCafe.Library.Enum;
using FurkanCafe.Library.Interface;
using System;
using System.Windows.Forms;

namespace FurkanCafe.Library.Concrete
{
    public class Game : IGame
    {
        private Timer _passingTimeTimer = new Timer { Interval = 1000 };
        private TimeSpan _passingTime = TimeSpan.FromSeconds(100);

        public event EventHandler PassingTimerChanged;

        public bool IsGameRunning { get; private set; }

        public TimeSpan PassingTime
        {
            get => _passingTime;
            private set
            {
                _passingTime = value;
                PassingTimerChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public Game()
        {
            _passingTimeTimer.Tick += PassingTimeTimer_Tick;
        }
        private void PassingTimeTimer_Tick(object sender, EventArgs e)
        {
            PassingTime -= TimeSpan.FromSeconds(1);
        }

        public void MoveToRobot(Direction direction)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (IsGameRunning) return;
            IsGameRunning = true;
            _passingTimeTimer.Start();
        }

        public void Stop()
        {
            _passingTimeTimer.Stop();
        }
    }
}
