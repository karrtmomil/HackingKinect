﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace KinectoSoar.Controllers
{
    public class SoarKeyboard : Microsoft.Xna.Framework.GameComponent
    {
        private KeyboardState _currState;

        public SoarKeyboard(Game game)
            : base(game)
        {
            _currState = Keyboard.GetState();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            _currState = Keyboard.GetState();
            if (_currState.IsKeyDown(Keys.A))
            {
                Resources.Instance.MoveBirdLeft();
            }
            if (_currState.IsKeyDown(Keys.D))
            {
                Resources.Instance.MoveBirdRight();
            }
            if (_currState.IsKeyDown(Keys.W))
            {
                Resources.Instance.MoveBirdUp();
            }
        }
    }
}
