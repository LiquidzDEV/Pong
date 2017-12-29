﻿using System;
using System.Linq;
using System.Windows.Forms;
using Pong.Source.Board;
using Pong.Source.Components;

namespace Pong.Source
{
    /// <summary>
    /// This is the Form of our application.
    /// It holds the visual appereance that the user will see and manages the input handling from the Keyboard and Arduino.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly Pong _main;

        /// <inheritdoc />
        /// <summary> Constructor of the <see cref="T:Pong.Source.MainForm" />. Initializes the components and adds the DigitalPinUpdated Event. </summary>
        public MainForm()
        {
            _main = Pong.Instance;

            if (Pong.ArduinoMode)
                Pong.Arduino.DigitalPinUpdated += DigitalPinUpdated;

            InitializeComponent();
            World.SetBounds(ClientSize.Height, ClientSize.Width);
            _main.Player1 = new Player(pnlPlayer1, lblPlayer1);
            _main.Player2 = new Player(pnlPlayer2, lblPlayer2);
            _main.Ball = new Ball(pBall);
        }

        /// <summary> This Event is triggered when a digital pin is updated. </summary>
        /// <param name="pin"> The updated Pin </param>
        /// <param name="state"> the changed Value (HIGH or LOW) </param>
        private static void DigitalPinUpdated(PinMapping pin, byte state)
        {
            if (pin == PinMapping.ButtonStart && state == Arduino.HIGH && !Pong.Instance.Started)
            {
                ArduinoHelper.SetStartLeds(false, false);
                ArduinoHelper.StopBlinking();
                Pong.Instance.Ball.Start();
                Pong.Instance.Started = true;
            }
        }

        /// <summary> Triggered when the Form is loading. </summary>
        private void MainFormLoad(object sender, EventArgs e)
        {
            tsBallSlow.Checked = Properties.Settings.Default.ballSlow;
            tsBallNormal.Checked = Properties.Settings.Default.ballNormal;
            tsBallFast.Checked = Properties.Settings.Default.ballFast;
            tsPanelSmall.Checked = Properties.Settings.Default.panelSmall;
            tsPanelNormal.Checked = Properties.Settings.Default.panelNormal;
            tsPanelBig.Checked = Properties.Settings.Default.panelBig;

            ResetRound();
            timerPaddle.Start();
            timerBall.Start();

            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        /// <summary> Triggered when the Form is closing (not closed!). </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ballSlow = tsBallSlow.Checked;
            Properties.Settings.Default.ballNormal = tsBallNormal.Checked;
            Properties.Settings.Default.ballFast = tsBallFast.Checked;
            Properties.Settings.Default.panelSmall = tsPanelSmall.Checked;
            Properties.Settings.Default.panelNormal = tsPanelNormal.Checked;
            Properties.Settings.Default.panelBig = tsPanelBig.Checked;
            Properties.Settings.Default.Save();

            if (Pong.ArduinoMode)
                Pong.Arduino.Close();
        }

        #region Bewegen der Balken

        void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            SetMovingState(e.KeyCode, true);
        }

        void MainFormKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            else if (e.KeyCode == Keys.F12)
            {
                WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
                tsFullscreen.Checked = WindowState == FormWindowState.Maximized;
            }

            SetMovingState(e.KeyCode, false);
        }

        private void SetMovingState(Keys keycode, bool isKeyDown)
        {
            if (!Pong.ArduinoMode)
            {
                switch (keycode)
                {
                    case Keys.W:
                        _main.Player1.PlayerUp = isKeyDown;
                        break;
                    case Keys.S:
                        _main.Player1.PlayerDown = isKeyDown;
                        break;

                    case Keys.Up:
                        _main.Player2.PlayerUp = isKeyDown;
                        break;
                    case Keys.Down:
                        _main.Player2.PlayerDown = isKeyDown;
                        break;
                }
            }
        }

        void timerPaddle_Tick(object sender, EventArgs e)
        {
            _main.Player1.Move();
            _main.Player2.Move();
        }

        #endregion

        #region Ball

        private void timerBall_Tick(object sender, EventArgs e)
        {
            if (_main.Started)
                _main.Ball.Move();
        }

        private void timerIncreaseSpeed_Tick(object sender, EventArgs e)
        {
            _main.Ball.IncreaseSpeed();
        }

        #endregion

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(' ') && !_main.Started && !Pong.ArduinoMode)
            {
                _main.Ball.Start();
                timerIncreaseSpeed.Start();
                _main.Started = true;
            }
        }

        private void MainFormSizeChanged(object sender, EventArgs e)
        {
            World.SetBounds(ClientSize.Height, ClientSize.Width);
            _main.Player1.Resize();
            _main.Player2.Resize();
            Pong.DebugMessage("Auflösung verändert. (" + ClientSize.Height + "/" + ClientSize.Width + ")");
        }

        public void ResetRound()
        {
            _main.Started = false;
            timerIncreaseSpeed.Stop();
            _main.Player1.Reset();
            _main.Player2.Reset();
            _main.Ball.Reset();
            Pong.DebugMessage("Spiel wurde zurückgesetzt.");
        }

        #region ContextMenu

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ctxtMenu.Show(this.Location.X + e.Location.X, this.Location.Y + e.Location.Y);
            }
        }

        private void ctxtMenu_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem currentItem)) return;

            ((ToolStripMenuItem)currentItem.OwnerItem).DropDownItems.OfType<ToolStripMenuItem>().ToList()
                .ForEach(item =>
                {
                    if (item.Checked && !item.Equals(currentItem))
                    {
                        item.Checked = false;
                    }
                });

            currentItem.Checked = true;

            if (currentItem.Equals(tsPanelSmall))
            {
                _main.Player1.SetPanelHeight(Player.PanelSmall);
                _main.Player2.SetPanelHeight(Player.PanelSmall);
            }
            else if (currentItem.Equals(tsPanelNormal))
            {
                _main.Player1.SetPanelHeight(Player.PanelNormal);
                _main.Player2.SetPanelHeight(Player.PanelNormal);
            }
            else if (currentItem.Equals(tsPanelBig))
            {
                _main.Player1.SetPanelHeight(Player.PanelBig);
                _main.Player2.SetPanelHeight(Player.PanelBig);
            }
            else if (currentItem.Equals(tsBallSlow))
            {
                Ball.SetSpeedLevel(2);
            }
            else if (currentItem.Equals(tsBallNormal))
            {
                Ball.SetSpeedLevel(3);
            }
            else if (currentItem.Equals(tsBallFast))
            {
                Ball.SetSpeedLevel(4);
            }
        }

        private void tsFullscreen_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            tsFullscreen.Checked = WindowState == FormWindowState.Maximized;
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    #endregion
}

