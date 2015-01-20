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
    public class Score
    {
        //Fields
        private static int points = 0;
        private static int scarabs = 0;
        private static int lives = 3;
        private static int minimalPointsForNextLevel = 100;
        private static bool doorsClosed = true;
        private static bool gameOver = false;

        /* Maak een static method genaamd Initialize() die points = 0, scarabs = 0
         * en lives = 3 initialiseerd. Deze method roep je static aan: Score.Initialize();
         */
        public static void Initialize()
        {
            points = 0;
            scarabs = 0;
            lives = 3;
            gameOver = false;
            doorsClosed = true;
            minimalPointsForNextLevel = 100;
        }

        // Properties
        public static int Points
        {
            get { return points; }
            set { 
                    points = value;
                    if (points < 0)
                    {
                        if (lives == 0)
                        {
                            gameOver = true;
                        }
                        points = 0;
                    }
                }
        }
        public static bool GameOver
        {
            get { return gameOver; }
            set { gameOver = value; }
        }
        public static int Scarabs
        {
            get { return scarabs; }
            set { scarabs = value; }
        }
        public static int Lives
        {
            get { return lives; }
            set { lives = value; }
        }
        public static bool DoorsClosed
        {
            get { return doorsClosed; }
            set { doorsClosed = value; }
        }
        public static int MinimalPointsForNextLevel
        {
            set { minimalPointsForNextLevel = value; }
            get { return minimalPointsForNextLevel; }
        }

        /* Methods
         */
        public static bool OpenDoors()
        {
            if (points > minimalPointsForNextLevel)
                return true;
            else
                return false;
        }


    }
}
