﻿using RetroTable.Main;
using System.Timers;

namespace RetroTable.Board
{
    /// <summary> Helperclass to access the Hardware connected through the Arduino Leonardo on the Lattepanda. </summary>
    public static class ArduinoHelper
    {
        /// <summary> Configures the pins from the arduino for the project. </summary>
        public static void Setup()
        {
            if (!Retrotable.DesktopMode)
            {
                Retrotable.ArduinoLeonardo.PinMode(PinMapping.Player1Buttons, Arduino.INPUT);
                Retrotable.ArduinoLeonardo.PinMode(PinMapping.Player2Buttons, Arduino.INPUT);

                Retrotable.ArduinoLeonardo.PinMode(PinMapping.EncoderSW, Arduino.INPUT);
                Retrotable.ArduinoLeonardo.PinMode(PinMapping.EncoderDT, Arduino.INPUT);
                Retrotable.ArduinoLeonardo.PinMode(PinMapping.EncoderCLK, Arduino.INPUT);

                Retrotable.ArduinoLeonardo.PinMode(PinMapping.Player1ButtonLeftLed, Arduino.OUTPUT);
                Retrotable.ArduinoLeonardo.PinMode(PinMapping.Player1ButtonRightLed, Arduino.OUTPUT);
                Retrotable.ArduinoLeonardo.PinMode(PinMapping.Player2ButtonLeftLed, Arduino.OUTPUT);
                Retrotable.ArduinoLeonardo.PinMode(PinMapping.Player2ButtonRightLed, Arduino.OUTPUT);
            }

            SetStartLeds(true, true);

            _blinkTimer = new Timer(500)
            {
                AutoReset = true
            };

            _blinkTimer.Elapsed += delegate
            {
                if (_blinkPlayer)
                {
                    _blinkState[0] = !_blinkState[0];
                    if (!Retrotable.DesktopMode)
                    {
                        Retrotable.ArduinoLeonardo.DigitalWrite(PinMapping.Player1ButtonLeftLed, _blinkState[0] ? Arduino.HIGH : Arduino.LOW);
                        Retrotable.ArduinoLeonardo.DigitalWrite(PinMapping.Player1ButtonRightLed, _blinkState[0] ? Arduino.HIGH : Arduino.LOW);
                    }
                }
                else
                {
                    _blinkState[1] = !_blinkState[1];
                    if (!Retrotable.DesktopMode)
                    {
                        Retrotable.ArduinoLeonardo.DigitalWrite(PinMapping.Player2ButtonLeftLed, _blinkState[1] ? Arduino.HIGH : Arduino.LOW);
                        Retrotable.ArduinoLeonardo.DigitalWrite(PinMapping.Player2ButtonRightLed, _blinkState[1] ? Arduino.HIGH : Arduino.LOW);
                    }
                }

                if (_blinkTimes > 0)
                {
                    _blinkTimes--;
                    if (_blinkTimes == 0)
                        StopBlinking();
                }
            };
        }

        /// <summary>
        /// Sets the player LEDs to green or red, depending on the bools given.
        /// </summary>
        /// <param name="player1">If true, the player1 LED is green, otherwise red</param>
        /// <param name="player2">If true, the player2 LED is green, otherwise red</param>
        //[System.Obsolete("DUO-LEDs are not implemented!", true)]
        //public static void SetLeds(bool player1, bool player2)
        //{
        //    if (!Retrotable.ArduinoMode) return;

        //    if (player1)
        //    {
        //        Retrotable.Arduino.DigitalWrite(PinMapping.Player1LedRed, Arduino.LOW);
        //        Retrotable.Arduino.DigitalWrite(PinMapping.Player1LedGreen, Arduino.HIGH);
        //    }
        //    else
        //    {
        //        Retrotable.Arduino.DigitalWrite(PinMapping.Player1LedGreen, Arduino.LOW);
        //        Retrotable.Arduino.DigitalWrite(PinMapping.Player1LedRed, Arduino.HIGH);
        //    }
        //    if (player2)
        //    {
        //        Retrotable.Arduino.DigitalWrite(PinMapping.Player2LedRed, Arduino.LOW);
        //        Retrotable.Arduino.DigitalWrite(PinMapping.Player2LedGreen, Arduino.HIGH);
        //    }
        //    else
        //    {
        //        Retrotable.Arduino.DigitalWrite(PinMapping.Player2LedGreen, Arduino.LOW);
        //        Retrotable.Arduino.DigitalWrite(PinMapping.Player2LedRed, Arduino.HIGH);
        //    }
        //}

        /// <summary>
        /// Sets the LEDs from the player startbuttons to on or off, depending on the given bool.
        /// </summary>
        /// <param name="player1">If true, the LED from the player 1 startbutton is on</param>
        /// <param name="player2">If true, the LED from the player 2 startbutton is on</param>
        public static void SetStartLeds(bool player1, bool player2)
        {
            if (!Retrotable.ArduinoMode) return;

            _blinkState[0] = player1;
            _blinkState[1] = player2;

            if (!Retrotable.DesktopMode)
            {
                Retrotable.ArduinoLeonardo.DigitalWrite(PinMapping.Player1ButtonLeftLed, _blinkState[0] ? Arduino.HIGH : Arduino.LOW);
                Retrotable.ArduinoLeonardo.DigitalWrite(PinMapping.Player1ButtonRightLed, _blinkState[0] ? Arduino.HIGH : Arduino.LOW);
                Retrotable.ArduinoLeonardo.DigitalWrite(PinMapping.Player2ButtonLeftLed, _blinkState[1] ? Arduino.HIGH : Arduino.LOW);
                Retrotable.ArduinoLeonardo.DigitalWrite(PinMapping.Player2ButtonRightLed, _blinkState[1] ? Arduino.HIGH : Arduino.LOW);
            }
        }

        private static Timer _blinkTimer;
        private static bool _blinkPlayer = false;
        private static bool[] _blinkState = new bool[2];
        private static int _blinkTimes = 0;

        /// <summary>
        /// Starts the blinking for a players startbutton.
        /// </summary>
        /// <param name="player1">If true, the player 1 startbutton will blink, otherwise the player 2 startbutton</param>
        public static void StartBlinking(bool player1, int intervall = 500)
        {
            if (!Retrotable.ArduinoMode) return;
            _blinkPlayer = player1;
            _blinkTimes = 0;
            _blinkTimer.Interval = intervall;
            _blinkTimer.Enabled = true;
        }

        public static void StartBlinking(bool player1, int times, int intervall = 500)
        {
            if (!Retrotable.ArduinoMode) return;
            _blinkPlayer = player1;
            _blinkTimes = times;
            _blinkTimer.Interval = intervall;
            _blinkTimer.Enabled = true;
        }

        /// <summary> Stops the blinking for the startbuttons. </summary>
        public static void StopBlinking()
        {
            if (!Retrotable.ArduinoMode) return;
            _blinkTimer.Enabled = false;
        }
    }
}
