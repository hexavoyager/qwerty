﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Elfe : Hero
    {
        public override int End
        {
            get
            {
                return base.End + 2;
            }
        }

        public Elfe(Coordonee Coordonee) : base(Coordonee)
        {

        }

        public override string Icon
        {
            get { return "N"; }
        }
    }
}
