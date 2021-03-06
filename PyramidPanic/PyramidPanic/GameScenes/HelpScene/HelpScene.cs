﻿// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
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
    public class HelpScene : IState
    {
        //Fields van de class StartScene
        private PyramidPanic game;
        private Image helpText;
        private Vector2 speed;

        // Constructor van de StartScene-class krijgt een object game mee van het type PyramidPanic
        public HelpScene(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        // Initialize methode. Deze methode initialiseert (geeft startwaarden aan variabelen).
        // Void wil zeggen dat er niets teruggegeven wordt.
        public void Initialize()
        {
            this.speed = new Vector2(0f, 20f);
            this.LoadContent();
        }

        // LoadContent methode. Deze methode maakt nieuwe objecten aan van de verschillende
        // classes.
        public void LoadContent()
        {
            this.helpText = new Image(game, @"Help\Help", new Vector2(0f, -1f), '.');
        }

        // Update methode. Deze methode wordt normaal 60 maal per seconde aangeroepen.
        // en update alle variabelen, methods enz.......
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                this.game.IState = this.game.GameOverScene;
            }
            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.game.IState = this.game.PlayScene;
            }
            //Console.WriteLine(Input.ScrollDirection());
            Console.WriteLine(this.helpText.Position.Y);
            
                if (Input.ScrollDirection() == "down")
                {
                    if ( this.helpText.Position.Y < -20)
                    this.helpText.Position += this.speed;
                }
                if (Input.ScrollDirection() == "up")
                {
                    if (this.helpText.Position.Y > -500)
                    this.helpText.Position -= this.speed;
                }
              
        }

        // Draw methode. Deze methode wordt normaal 60 maal per seconde aangeroepen en
        // tekent de textures op het canvas
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Green);
            this.helpText.Draw(gameTime);
        }
    }
}
