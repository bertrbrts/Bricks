using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class GameContent
    {
        public Texture2D ImgBrick { get; set; }
        public Texture2D ImgPaddle { get; set; }
        public Texture2D ImgBall { get; set; }
        public Texture2D ImgPixel { get; set; }
        public SoundEffect StartSound { get; set; }
        public SoundEffect BrickSound { get; set; }
        public SoundEffect PaddBounceSound { get; set; }
        public SoundEffect WallBounceSound { get; set; }
        public SoundEffect MissSound { get; set; }
        public SpriteFont LabelFont { get; set; }

        public GameContent(ContentManager Content)
        {
            // load images
            ImgBall = Content.Load<Texture2D>("ball");
            ImgPixel = Content.Load<Texture2D>("pixel");
            ImgPaddle = Content.Load<Texture2D>("Paddle");
            ImgBrick = Content.Load<Texture2D>("brick");

            // load sounds
            StartSound = Content.Load<SoundEffect>("StartSound");
            BrickSound = Content.Load<SoundEffect>("BrickSound");
            PaddBounceSound = Content.Load<SoundEffect>("PaddleBounceSound");
            WallBounceSound = Content.Load<SoundEffect>("WallBounceSound");
            MissSound = Content.Load<SoundEffect>("MissSound");

            // load fonts
            LabelFont = Content.Load<SpriteFont>("Arial20");
        }
    }
}
