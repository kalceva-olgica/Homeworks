﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Inheritancee
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, double salary) : base(firstName, lastName, salary) { }

    }
}
