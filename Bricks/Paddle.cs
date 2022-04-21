using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Paddle
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float ScreenWidth { get; set; }

        private Texture2D ImgPaddle { get; set; }
        private SpriteBatch SpriteBatch { get; set; }

        public Paddle(float x, float y, float screenWidth, SpriteBatch spriteBatch, GameContent gameContent)
        {
            X = x;
            Y = y;
            ImgPaddle = gameContent.ImgPaddle;
            Width = ImgPaddle.Width;
            Height = ImgPaddle.Height;
            SpriteBatch = spriteBatch;
            ScreenWidth = screenWidth;
        }

        public void Draw()
        {
            SpriteBatch.Draw(ImgPaddle, new Vector2(X, Y), 
                null, Color.White, 0, new Vector2(0, 0), 
                1.0f, SpriteEffects.None, 0); 
        }

        public void MoveLeft()
        {
            X = X - 5;
            if (X < 1)
            {
                X = 1;
            }
        }

        public void MoveRight()
        {
            X = X + 5;
            if ((X + Width) > ScreenWidth)
            {
                X = ScreenWidth - Width;
            }
        }

        public void MoveTo(float x)
        {
            X = 0;
            if (x >= 0)
            {
                X = (x < ScreenWidth - Width) ? x : ScreenWidth - Width;
            }
        }
    }
}
