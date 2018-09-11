﻿using RetroTable.Board;
using RetroTable.Main;
using RetroTable.MySql;
using RetroTable.Pong.Components;
using RetroTable.Test;
using RetroTable.UserSystem;

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

        internal PongRecords Records { get; }

        internal int BallSwitchesRound;
        internal int BallSwitchesGame;

        public Pong()
        {
            Pongform = new PongForm(this);
            if (Retrotable.Databasemode)
                Records = Database.Records.RecordsLoad();
            else
                Records = new PongRecords();

#if DEBUG
            new PongRecordsDataTest().Show();
#endif
        }

        //Wenn Pong geöffnet wird
        internal void Show()
        {
            ClearPoints();
            ResetRound();
            Pongform.Show();
            Pongform.UpdateRecordDisplay();

            Retrotable.LiveGameData.running = 1;
            Retrotable.LiveGameData.userId1 = UserManager.Player1.Id;
            Retrotable.LiveGameData.userId2 = UserManager.Player2.Id;
            Retrotable.UpdateLiveGameData();
        }

        //Immer wenn Pong über ESC geschlossen wird
        internal void Hide()
        {
            Pongform.Hide();

            Retrotable.LiveGameData.running = 0;
            Retrotable.UpdateLiveGameData();
        }

        // Jedes mal wenn Leertaste oder Start gedrückt wird
        internal void Start()
        {
            if (Started) return;

            BallSwitchesRound = 0;
            Ball.Start();
            Started = true;

            Pongform.lblWinner.Text = "";
            Pongform.timerMain.Start();
            Pongform.timerBall.Start();

            Pongform.UpdateRecordDisplay();

            if (TimeLeft <= 0)
            {
                ClearPoints();
            }

            if (Retrotable.ArduinoMode)
            {
                ArduinoHelper.SetStartLeds(false, false);
                ArduinoHelper.StopBlinking();
            }
        }

        internal void ClearPoints()
        {
            Player1.ScorePoints = 0;
            Player2.ScorePoints = 0;
            BallSwitchesGame = 0;
            TimeLeft = UserManager.Player1.TimeLimit * 60;
            Pongform.UpdateTime();

            Retrotable.LiveGameData.score1 = 0;
            Retrotable.LiveGameData.score2 = 0;
            Retrotable.LiveGameData.timeleft = TimeLeft;
            Retrotable.UpdateLiveGameData();
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
