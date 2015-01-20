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
    public class Block : Image
    {
        //Fields
        private bool passable;
        private Char character;

        //Properties
        public bool Passable
        {
            get { return this.passable; }
            set { this.passable = value; }
        }
        public Rectangle Rectangle
        {
            get { return this.rectangle; }
        }
        public Char Character
        {
            get { return this.character; }
        }

        //Constructor
        public Block(PyramidPanic game, string pathNameAsset, Vector2 position, bool passable, Char character ) 
            : base(game, pathNameAsset, position, character)
        {
            this.passable = passable;
            this.character = character;
        }

        //Update

        //Draw
        public new void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
