using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Car_Shop
{
    class TheWall
    {
        public int x;
        public int y;

        public int sizeX;
        public int sizeY;

        public Image wallImg;

        public TheWall(int x, int y, bool isRotatedImage = false)
        {
            wallImg = new Bitmap(Properties.Resources.tube);
            this.x = x;
            this.y = y;
            sizeX = 50;
            sizeY = 250;
            if (isRotatedImage)
                wallImg.RotateFlip(RotateFlipType.Rotate180FlipX);
        }




        class Player
        {
            public float x;
            public float y;

            public int size;
            public int score;

            public float gravityValue;

            public Image birdImg;

            public bool isAlive;

            public Player(int x, int y)
            {
                birdImg = new Bitmap(Properties.Resources.bird);
                this.x = x;
                this.y = y;
                size = 50;
                gravityValue = 0.2f;
                isAlive = true;
                score = 0;
            }
        }
    }
}
