// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class LevelYouWon : ILevel
    {
         // Fields
        private Level level;
        private Image overlay;
        private float timer = 0f;

        // Properties

        // Constructor
        public LevelYouWon(Level level)
        {
            this.level = level;
            this.overlay = new Image(level.Game, @"Overlay\Youwon", Vector2.Zero, '.');
            this.overlay.Color = new Color(1f, 1f, 1f, 1f);
        }

        // Update
        public void Update(GameTime gameTime)
        {
            this.timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (this.timer > 3)
            {               
                this.level.State = this.level.Play;
                Score.Initialize();
                this.level.Initialize(this.level.LevelIndex = 0);
                this.level.Game.IState = this.level.Game.StartScene;
                this.timer = 0f;
            }
        }
        
        // Draw
        public void Draw(GameTime gameTime)
        {
            this.overlay.Draw(gameTime);
        }
    }
}
