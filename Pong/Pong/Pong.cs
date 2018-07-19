﻿using RetroTable.Board;
using RetroTable.Main;
using RetroTable.Pong.Components;
using RetroTable.UserSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroTable.Pong
{
    public class Pong
    {
        private PongForm Pongform;

        /// <summary> Holding the instance of a Player. </summary>
        internal Player Player1, Player2;

        /// <summary> Holding the instance of the <see cref="Ball"/>. </summary>
        internal Ball Ball;

        /// <summary> True, if a match is running. </summary>
        internal bool Started { get; private set; }

        /// <summary> Time left in seconds. </summary>
        internal int TimeLeft;

        public Pong()
        {
            Pongform = new PongForm(this);
        }

        internal void Show()
        {
            Player1.ScorePoints = 0;
            Player2.ScorePoints = 0;
            TimeLeft = UserManager.Player1.TimeLimit * 60;
            ResetRound();
            Pongform.Show();
        }

        internal void Hide()
        {
            Pongform.Hide();
        }

        internal void Start()
        {
            if (Started) return;

            Ball.Start();
            Started = true;

            Pongform.timerMain.Start();
            Pongform.timerBall.Start();
            if (TimeLeft <= 0)
            {
                Player1.ScorePoints = 0;
                Player2.ScorePoints = 0;
                TimeLeft = UserManager.Player1.TimeLimit * 60;
                Pongform.lblWinner.Visible = false;
            }

            if (Retrotable.ArduinoMode)
            {
                ArduinoHelper.SetStartLeds(false, false);
                ArduinoHelper.StopBlinking();
            }
        }

        internal void ResetRound()
        {
            Started = false;
            Pongform.timerMain.Stop();
            Pongform.timerBall.Stop();
            Player1.Reset();
            Player2.Reset();
            Ball.Reset();
            System.Diagnostics.Debug.WriteLine("Spiel wurde zurückgesetzt.");
        }
    }
}
