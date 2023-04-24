﻿using GameEngine;
using SFML.System;

namespace MyGame
{
    class GameScene : Scene
    {
        private int _score;
        public GameScene()
        {
            Ship ship = new Ship();
            AddGameObject(ship);

            MeteorSpawner meteorSpawner = new MeteorSpawner();
            AddGameObject(meteorSpawner);

            Score score = new Score(new Vector2f(10.0f, 10.0f));
            AddGameObject(score);
        }

        public int GetScore()
        {
            return _score;
        }

        public void IncreaseScore()
        {
            ++_score;
        }
    }
}