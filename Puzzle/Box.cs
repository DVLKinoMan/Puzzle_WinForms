using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class Box
    {
        private string Name;
        private string Text;
        private Color TXTColor;
        private Point Location;
        private Image img;
        private Font TXTFont;

        public Box()
        {
        }

        public Box(string name,string text, Color TXTColor,Point Location,Image img,Font TXTFont)
        {
            this.Name = name;
            this.Text = text;
            this.TXTColor = TXTColor;
            this.Location = Location;
            this.img = img;
            this.TXTFont = TXTFont;
        }

        public string BoxName
        {
            get
            {
                return this.Name;
            }
            set
            {
                Name = value;
            }
        }

        public string BoxText
        {
            get
            {
                return this.Text;
            }
            set
            {
                Text = value;
            }
        }

        public Color BoxTXTColor
        {
            get
            {
                return this.TXTColor;
            }
            set
            {
                TXTColor = value;
            }
        }

        public Point BoxLocation
        {
            get
            {
                return this.Location;
            }
        }

        public Image BoxImg
        {
            get
            {
                return this.img;
            }
            set
            {
                img = value;
            }
        }

        public Font BoxTXTFont
        {
            get
            {
                return this.TXTFont;
            }
        }
    }
}
