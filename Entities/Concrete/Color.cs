﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Color()
        {

        }

        public Color(string _Name)
        {
            Name = _Name;
        }

    }
}
