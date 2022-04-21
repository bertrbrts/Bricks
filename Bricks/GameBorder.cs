using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class GameBorder
    {
        public float Width { get; set; }
        public float Height { get; set; }
        private Texture2D ImgPixel { get; set; }
        private SpriteBatch spriteBatch { get; set; }
        public GameBorder(float screenWidth, float screenHeight, SpriteBatch spriteBatch, GameContent gameContent)
        {
            Width = screenWidth;
            Height = screenHeight;
            ImgPixel = gameContent.ImgPixel;
            this.spriteBatch = spriteBatch;
        }

        public void Draw()
        {
            spriteBatch.Draw(ImgPixel, new Rectangle(0, 0, (int)Width - 1, 1), Color.White); // draw top border
            spriteBatch.Draw(ImgPixel, new Rectangle(0, 0, 1,(int)Height - 1), Color.White); // draw left
            spriteBatch.Draw(ImgPixel, new Rectangle((int)Width - 1, 0, 1, (int)Height - 1), Color.White); // draw right
        }
    }
}
