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
    public class LevelDoorOpen : ILevel
    {
         // Fields
        private Level level;
        private Image overlay, message;
        private float timer = 0f;

        // Properties

        // Constructor
        public LevelDoorOpen(Level level)
        {
            this.level = level;
            this.overlay = new Image(level.Game, @"Overlay\DoorsAreOpen", Vector2.Zero, '.');
            this.overlay.Color = new Color(1f, 1f, 1f, 1f);
        }

        // Update
        public void Update(GameTime gameTime)
        {
            this.timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (this.timer > 1.5f)
            {  
                this.level.State = this.level.Play;
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
