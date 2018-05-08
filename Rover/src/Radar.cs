﻿using System;
namespace Rover
{
    public abstract class Radar : Device
    {
        private const double USES_CHARGE = .4;
        protected const int RADAR_RANGE = 5;


        public Radar(string name, Environment env) : base (name, USES_CHARGE)
        {
        }

		public override void Use()
		{
            base.Use();

		}
	}
}