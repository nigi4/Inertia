﻿using System;
namespace Inertia
{
    class Treasure : Element
    {
        public Treasure(int x, int y)
        {
            X = x;
            Y = y;
            Gist = Gists.Treasure;
        }

        public override System.Drawing.Bitmap GetShape()
        {
            return Properties.Resources.Treasure;
        }
    }
}