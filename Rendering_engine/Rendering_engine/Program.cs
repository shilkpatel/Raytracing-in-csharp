using System;
using System.Drawing;

namespace Rendering_engine
{
    class Program
    {
        Bitmap image = new Bitmap(1600, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
        float viewport_height = 1;
        float viewport_width = 1;
        float distance_from_viewport = 1;
        static void Main(string[] args)
        {
        }


        public static void render() 
        {
            for (int i = 0; i < 1600; i++) 
            {
                for (int j = 0; j < 800; j++) 
                {
                    int pixel_height = 
                }
            }
        }
    }
}
