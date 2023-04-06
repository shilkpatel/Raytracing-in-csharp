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
        public vec() { }

        public double x() { return vector[0]; }
        public double y() { return vector[1]; }
        public double z() { return vector[2]; }


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

        public static vec operator *(vec a, double b) 
        {
            a.vector[0] *= b;
            a.vector[1] *= b;
            a.vector[2] *= b;

            return a;

        }

        public double norm() 
        {
            return Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);
        }

        public vec unit() 
        {
            vec unit_vector = new vec();
            double norm = this.norm();
            unit_vector.vector[0] = this.vector[0] / norm;
            unit_vector.vector[1] = this.vector[1] / norm;
            unit_vector.vector[2] = this.vector[2] / norm;

            return unit_vector;
        }
    }
}
