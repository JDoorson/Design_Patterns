﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Knight : Character
    {
        public Knight()
        {
            Weapon = new SwordBehaviour();  
        }
    }   
}
