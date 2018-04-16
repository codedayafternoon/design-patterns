﻿using Factory.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Readers
{
    public class PngImageReader : ImageReader
    {
        public Image GetImage(string name)
        {
            return new PngImage(name);
        }
    }
}
