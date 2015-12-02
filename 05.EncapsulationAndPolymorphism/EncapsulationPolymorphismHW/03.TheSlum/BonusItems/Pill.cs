namespace _03.TheSlum.BonusItems
{
    public class Pill : Bonus
    {
        private const int DefaultHealthEffect = 0;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultAttackEffect = 100;
        private const int DefaultTimeout = 1;

        public Pill(string id)
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            base.Timeout = DefaultTimeout;
            base.Countdown = DefaultTimeout;
            base.HasTimedOut = false;
        }
    }
}
