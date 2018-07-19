﻿using RetroTable.Board;
using RetroTable.Main;
using RetroTable.UserSystem;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RetroTable.Pong.Components
{
    /// <summary> This Class holds the variables for one player. </summary>
    public class Player
    {
        /// <summary> The movement speed of the player. </summary>
		private const int Speed = 20;

        /// <summary> The three sizes of the panel configured over the options. </summary>
		public const int PanelSmall = 50;
        public const int PanelNormal = 150;
        public const int PanelBig = 200;

        private readonly Panel _pnl;
        private readonly Label _lblScore;

        private bool Player1;

        public bool PlayerUp;
        public bool PlayerDown;

        internal int ScorePoints { get; set; }

        public Player(bool player1, Panel pnl, Label lblScore)
        {
            Player1 = player1;
            _pnl = pnl;
            _lblScore = lblScore;

            Retrotable.onValueChanged += RetroTable_onValueChanged;
        }

        private void RetroTable_onValueChanged(PinMapping button, int newValue)
        {
            if (button == PinMapping.Player1Bar)
                newValue = 100 - newValue;

            double position = (World.Bottom - _pnl.Size.Height - World.Upper) / 100f * newValue;
            _pnl.Location = new Point(_pnl.Location.X, Math.Min(World.Bottom - _pnl.Size.Height, Convert.ToInt32(position) + World.Upper));
        }

        /// <summary> Let the player move, depending which button is pressed, when no Arduino is connected. </summary>
        public void Move()
        {
            if (PlayerUp)
            {
                _pnl.Location = new Point(_pnl.Location.X, Math.Max(World.Upper, _pnl.Location.Y - Speed));
            }
            else if (PlayerDown)
            {
                _pnl.Location = new Point(_pnl.Location.X, Math.Min(World.Bottom - _pnl.Size.Height, _pnl.Location.Y + Speed));
            }
        }

        /// <summary> Gives this player a scorepoint. </summary>
        internal void Score()
        {
            ScorePoints++;
            _lblScore.Text = ScorePoints + "\n" + (Player1 ? UserManager.Player1.Name : UserManager.Player2.Name);
            Retrotable.Instance.Pong.ResetRound();
            System.Diagnostics.Debug.WriteLine("Ein Punkt wurde vergeben.");
        }

        /// <summary> Sets the players panel position relative to the poti value. </summary>
        [Obsolete("Replaced with Eventhandler onValueChanged", true)]
        internal void SetRelativePanelPosition(int percentage)
        {
            if (Player1)
                percentage = 100 - percentage;

            double position = (World.Bottom - _pnl.Size.Height - World.Upper) / 100f * percentage;
            _pnl.Location = new Point(_pnl.Location.X, Math.Min(World.Bottom - _pnl.Size.Height, Convert.ToInt32(position) + World.Upper));
        }

        /// <summary> Changes the panel height. </summary>
        public void SetPanelHeight(int height)
        {
            _pnl.Height = height;
            System.Diagnostics.Debug.WriteLine("Höhe des Balken wurde auf " + height + " gesetzt!");
        }

        internal bool Hits(PictureBox ball)
        {
            return _pnl.Bounds.IntersectsWith(ball.Bounds);
        }

        internal void Reset()
        {
            _pnl.Location = new Point(_pnl.Location.X, ((World.Bottom - World.Upper) / 2) - (_pnl.Size.Height / 2));
            _lblScore.Text = ScorePoints + "\n" + (Player1 ? UserManager.Player1.Name : UserManager.Player2.Name);
        }

        public void Resize()
        {
            int x = Player1 ? 10 : World.Right - _pnl.Size.Width - 10;
            _pnl.Location = new Point(x, Math.Min(World.Bottom - _pnl.Size.Height, _pnl.Location.Y));
        }
    }
}
