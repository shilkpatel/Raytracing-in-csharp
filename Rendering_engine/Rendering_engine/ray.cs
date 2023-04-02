using System;
using System.Collections.Generic;
using System.Text;

namespace Rendering_engine
{
    class ray
    {
        vec direction;
        vec origin;



        public ray(vec direction, vec origin) 
        {
            this.direction = direction;
            this.origin = origin;
        }

        bool hit_sphere(vec centre, double radius)
        {
            vec oc = origin - centre;
            double a = direction * direction;
            double b = 2 * (oc * direction);
            double c = (oc * oc) - (radius * radius);
            double discriminant = b * b - 4 * a * c;
            return (discriminant > 0);
        }


        public double[] ray_colour()
        {
            vec sphere_origin = new vec(0, 0, 10);
            double radius = 1;
            if (hit_sphere(sphere_origin, radius)) 
            {
                return new double[] { 255, 0, 0 };
            }
            return new double[] { 0, 0, 0 };

        }

    }
}
