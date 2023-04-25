﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Entities
{
    internal interface IEntity
    {
        string attack();
        string defend();
        string speak();
    }
}