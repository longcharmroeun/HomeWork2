﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Data
    {
        public string[] data { get; set; }
        public string[] name { get; set; }
        public Data(int size)
        {
            data = new string[size];
            name = new string[size];
        }
        public Data()
        {
            data = new string[20];
            name = new string[20];
        }
    }
}
