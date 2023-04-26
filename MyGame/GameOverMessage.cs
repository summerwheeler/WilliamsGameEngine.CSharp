﻿using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class GameOverMessage : GameObject
    {
        private readonly Text _text = new Text();

        public GameOverMessage(int score)
        {
            _text.Font = Game.GetFont("Resources/Courneuf-Regular.ttf");
            _text.Position = new Vector2f(50.0f, 50.0f);
            _text.CharacterSize = 48;
            _text.FillColor = Color.Red;
            _text.DisplayedString = "GAME OVER\n\nYOUR SCORE: " + score + "\n\nPRESS ENTER TO CONTINUE";
        }

        public override void Draw()
        {
            Game.RenderWindow.Draw(_text);
        }

        public override void Update(Time elpased)
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
            {
                GameScene scene = new GameScene();
                Game.SetScene(scene);
            }
        }
    }
}
