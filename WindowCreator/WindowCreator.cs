using System;
namespace WindowCreator
{
    public class WindowCreator
    {
        private Window header;
        private Window frame;
        private Window backgroundImage;
        private Window backgroundColor;
        private Window shadow;
        private Window verticalScrollBar;
        private Window horizontalScrollBar;

        public WindowCreator()
        {
            header = new WindowHeader();
            frame = new WindowFrame();
            backgroundImage = new WindowBackgroundImage();
            backgroundColor = new WindowBackgroundColor();
            shadow = new WindowShadow();
            verticalScrollBar = new WindowVerticalScrollBar();
            horizontalScrollBar = new WindowHorizontalScrollBar();
        }

        public void PaintHeader(){header.Paint();}

        public void PaintFrame(){frame.Paint();}

        public void PaintBackgroundImage(){backgroundImage.Paint();}

        public void PaintBackgroundColor(){backgroundColor.Paint();}

        public void PaintShadow(){shadow.Paint();}

        public void PaintVerticalScrollBar(){verticalScrollBar.Paint();}

        public void PaintHorizontalScrollBar(){horizontalScrollBar.Paint();}

    }
}
