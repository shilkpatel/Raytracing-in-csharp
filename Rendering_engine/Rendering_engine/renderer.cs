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
                    double pixel_height = viewport_height * (j / image_height);
                    double pixel_width = viewport_width * (i / image_width);
                    double pixel_depth = distance_from_viewport;

                }
            }
        }
    }
}
