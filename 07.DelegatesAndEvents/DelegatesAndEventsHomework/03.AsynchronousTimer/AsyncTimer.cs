namespace _03.AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsyncTimer
    {
        public event Action<string> Tick;

        private int ticks;
        private int t;

        public AsyncTimer(Action<string> action, int ticks, int t)
        {
            Tick += action;
            this.Ticks = ticks;
            this.T = t;
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ticks cannot be negative");
                }

                this.ticks = value;
            }
        }

        public int T
        {
            get
            {
                return this.t;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Time cannot be negative");
                }

                this.t = value;
            }
        }

        public void Run()
        {
            Thread thread = new Thread(this.OnTick);
            thread.Start();
        }

        private void OnTick()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.T);
                this.Tick("TIME! TIME! TIME!");
            }
        }
    }
}
