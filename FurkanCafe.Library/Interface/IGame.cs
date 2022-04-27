using FurkanCafe.Library.Enum;
using System;

namespace FurkanCafe.Library.Interface
{
    internal interface IGame
    {
        event EventHandler PassingTimerChanged;
        bool IsGameRunning { get; }
        TimeSpan PassingTime { get; }
        void Start();
        void Stop();
        void Pause();
        void MoveToRobot(Direction direction);
    }
}
