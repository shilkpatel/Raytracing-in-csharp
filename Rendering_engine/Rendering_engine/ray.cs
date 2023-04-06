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

        public vec at(double t) 
        {
            return this.origin + (this.direction * t);
        }

        double hit_sphere(vec centre, double radius)
        {
            vec oc = origin - centre;
            double a = direction * direction;
            double b = 2 * (oc * direction);
            double c = (oc * oc) - (radius * radius);
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                return (-b - discriminant) / 2 * a;
            }
            else
            {
                return -1;
            }
        }


        public double[] ray_colour()
        {
            double[] colour = new double[3]; 
            vec sphere_origin = new vec(0, 0, 10);
            double radius = 1;
            double t = hit_sphere(sphere_origin, radius); 
            if (t > 0) 
            {
                vec N = (this.at(t) - sphere_origin).unit();
                colour[0] = (N.x() + 1) * 0.5 * 255;
                colour[1] = (N.y() + 1) * 0.5 * 255;
                colour[2] = (N.z() + 1) * 0.5 * 255;
                return colour;
            }
            return colour;

        }

    }
}
