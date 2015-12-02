﻿namespace _02.Battleships.Ships
{
    using System;

    public class Warship : BattleShip
    {
        public Warship(string name, double lengthInMeters, double volume)
            : base(name, lengthInMeters, volume)
        {

        }

        public override string Attack(Ship target)
        {
            this.DestroyShip(target);

            return "Victory is ours!";
        }
    }
}
