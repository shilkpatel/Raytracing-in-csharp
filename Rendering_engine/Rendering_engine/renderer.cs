using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Rendering_engine
{
    class renderer
    {
        Bitmap image = new Bitmap(1600, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
        float image_height = 800;
        float image_width = 1600;
        float viewport_height = 1;
        float viewport_width = 2;
        float distance_from_viewport = 1;



        public void render()
        {
            for (int i = 0; i < 1600; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    double pixel_height = viewport_height * (j / image_height)  - (viewport_height/2);// the shift is to bring image to the centre
                    double pixel_width = viewport_width * (i / image_width) - (viewport_width/2);
                    double pixel_depth = distance_from_viewport;
                    vec ray_origin = new vec(pixel_width, pixel_height, pixel_depth);
                    vec ray_direction = new vec(pixel_width, pixel_height, pixel_depth);
                    ray current_ray = new ray(ray_origin, ray_direction);
                    double[] ray_color = current_ray.ray_colour();
                    image.SetPixel(i, j, Color.FromArgb(255, (int)ray_color[0], (int)ray_color[1], (int)ray_color[2]));
                }
            }
            image.Save("test.bmp");
        }
    }
}
