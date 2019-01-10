using System;

namespace Assets.Scripts
{
    interface IScheduler
    {
        void Schedule(float delay, Action action);
    }
}