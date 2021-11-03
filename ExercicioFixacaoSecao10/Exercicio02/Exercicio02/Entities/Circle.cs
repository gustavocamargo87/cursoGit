﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercicio02.Entities.Enums;


namespace Exercicio02.Entities
{
    class Circle: Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius    ;
        }
    }
}
