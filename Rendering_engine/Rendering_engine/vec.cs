using System;
using System.Collections.Generic;
using System.Text;

namespace Rendering_engine
{
    class vec
    {
        double[] vector = new double[3];
        public vec(double x, double y, double z)
        {
            vector[0] = x;
            vector[1] = y;
            vector[2] = z;
        }




        public static vec operator +(vec a, vec b)
        {
            double x = a.vector[0] + b.vector[0];
            double y = a.vector[1] + b.vector[1];
            double z = a.vector[2] + b.vector[2];
            return new vec(x, y, z);
        }

        public static vec operator -(vec a, vec b)
        {
            double x = a.vector[0] - b.vector[0];
            double y = a.vector[1] - b.vector[1];
            double z = a.vector[2] - b.vector[2];
            return new vec(x, y, z);
        }

        public static double operator *(vec a, vec b)
        {
            double x = a.vector[0] * b.vector[0];
            double y = a.vector[1] * b.vector[1];
            double z = a.vector[2] * b.vector[2];
            return x+y+z;
        }
    }
}
