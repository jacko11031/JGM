﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ADS.Events.KeyboardEvent
{
    public class KeyEventArgs
    {
        public KeyboardState keyState { get; set; }
        public Keys key { get; set; }
    }
}
