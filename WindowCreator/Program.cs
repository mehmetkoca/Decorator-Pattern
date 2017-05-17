using System;

namespace WindowCreator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WindowCreator windowCreate = new WindowCreator();
            windowCreate.PaintHeader();
            windowCreate.PaintFrame();
            windowCreate.PaintBackgroundImage();
            windowCreate.PaintBackgroundColor();
            windowCreate.PaintShadow();
            windowCreate.PaintVerticalScrollBar();
            windowCreate.PaintHorizontalScrollBar();
        }
    }
}
