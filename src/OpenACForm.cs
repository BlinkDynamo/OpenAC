using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Configuration;

namespace OpenAC
{
    public partial class OpenACForm : Form
    {
        /* DLL IMPORTS */
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /* MOUSE ACTIONS */
        private const int MOUSEEVENTF_LEFTDOWN  = 0x02;
        private const int MOUSEEVENTF_LEFTUP    = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP   = 0x10;
        private const int MOUSEEVENTF_MOVE      = 0x0001;

        /* HOTKEYS */
        private const int START_HOTKEY_ID       = 00001;
        private const int STOP_HOTKEY_ID        = 00002;

        /* CONSTANTS */
        private const int DOUBLE_CLICK_DELAY    = 50;
        private const string VERSION_NUMBER     = "1.0.0";

        /* GLOBAL VARS */
        private bool is_running = false;

        /* CONSTRUCTOR */
        public OpenACForm()
        {
            InitializeComponent();
            SetDefaultControls();
            RegisterHotKeys();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /* ---------- METHOD DECLARATIONS ---------- */
        void SetDefaultControls()
        {
            /* Sets default values for all controls, prior to any user input or logic */

            /* Click Interval */
            clickIntervalHoursTB.Text = "0";
            clickIntervalMinutesTB.Text = "0";
            clickIntervalSecondsTB.Text = "0";
            clickIntervalMillisecondsTB.Text = "3000";

            /* Click Options */
            clickOptionsMouseButtonCB.SelectedIndex = 0;
            clickOptionsMouseButtonCB.DropDownStyle = ComboBoxStyle.DropDownList;

            clickOptionsClickTypeCB.SelectedIndex = 0;
            clickOptionsClickTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;

            /* Click Repeat */
            clickRepeatRepeatUntilStoppedRB.Checked = true;
            clickRepeatRepeatNTimesRB.Checked = false;
            
            /* Cursor Position */
            cursorPositionCurrentLocationRB.Checked = true;
            cursorPositionCustomLocationRB.Checked = false;
            xLocationTB.Text = "0";
            yLocationTB.Text = "0";

            /* Program State */
            startB.Enabled = true;
            stopB.Enabled = false;

            /* Status Textbox */
            statusTB.Enter += (sender, e) => this.ActiveControl = null;
            statusTB.Text = "Standby";
            statusTB.BackColor = Color.LightGray;

            /* Title and Version Label */
            titleAndVersionL.Text = "Open AutoClicker v" + VERSION_NUMBER;
        }

        void RegisterHotKeys()
        {
            /* Registers the hotkeys for the Start and Stop buttons */
            RegisterHotKey(this.Handle, START_HOTKEY_ID, 0, (int)Keys.F6);
            RegisterHotKey(this.Handle, STOP_HOTKEY_ID, 0, (int)Keys.F7);
        }

        void DoAutoClickerThread(int delay, int n_repeats, bool repeat_until_stopped, string mouse_button, string click_type, int x, int y)    /* DoAutoClickerThread is the main function that handles the active state of the AutoClicker. It is a threaded process. */
        {
            while (is_running)  
            {
                DoMouseClick(x, y, mouse_button, click_type);

                System.Threading.Thread.Sleep(delay);

                /* Check if the AutoClicker should repeat */
                if (n_repeats > 0)
                {
                    n_repeats--;
                }

                else if (repeat_until_stopped)
                {
                    continue;
                }

                else
                {
                    stopB_Click(null, null);
                }
            }
        }

        void DoMouseClick(int location_x, int location_y, string mouse_button, string click_type)
        {
            if (cursorPositionCustomLocationRB.Checked)
            {
                Cursor.Position = new System.Drawing.Point(location_x, location_y);    /* Move to the location */
            }

            /* Perform the click depending on the mouse button and click type */
            if (mouse_button == "left")
            {
                if (click_type == "single")
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(DOUBLE_CLICK_DELAY);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                }
            }
            else
            {
                if (click_type == "single")
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(DOUBLE_CLICK_DELAY);
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                }
            }
        }       

        /* ---------- EVENT HANDLERS ---------- */

        private void startB_Click(object sender, EventArgs e)
        {      
            /* STATUS VARIABLES */
            is_running = true;
            startB.Enabled = false;
            stopB.Enabled = true;

            /* RUNTIME VARIABLES */
            int delay;
            int n_repeats;
            bool repeat_until_stopped;
            string mouse_button;
            string click_type;
            int x;
            int y;

            /* SET RUNTIME VARIABLES */
            /* Sums all clickInterval values to get the delay in milliseconds */
            delay = Convert.ToInt32(clickIntervalHoursTB.Text) * 3600000 +
                    Convert.ToInt32(clickIntervalMinutesTB.Text) * 60000 +
                    Convert.ToInt32(clickIntervalSecondsTB.Text) * 1000 +
                    Convert.ToInt32(clickIntervalMillisecondsTB.Text);

            /* Set n_repeats and repeat_until_stopped from clickRepeat Radio Buttons */
            if (clickRepeatRepeatNTimesRB.Checked)
            {
                n_repeats = Convert.ToInt32(clickRepeatRepeatNTimesNUD.Text);
                repeat_until_stopped = false;
            }
            else
            {
                n_repeats = 0;
                repeat_until_stopped = true;
            }

            /* Set mouse button from clickOptions Combo Box */
            if (clickOptionsMouseButtonCB.SelectedIndex == 0)
            {
                mouse_button = "left";
            }
            else
            {
                mouse_button = "right";
            }

            /* Set click type from clickOptions Combo Box */
            if (clickOptionsClickTypeCB.SelectedIndex == 0)
            {
                click_type = "single";
            }
            else
            {
                click_type = "double";
            }
            /* Get the x and y location of the cursor */
            if (cursorPositionCurrentLocationRB.Checked)
            {
                x = Cursor.Position.X;
                y = Cursor.Position.Y;
            }
            else
            {
                x = Convert.ToInt32(xLocationTB.Text);
                y = Convert.ToInt32(yLocationTB.Text);
            }
            

            /* Start the AutoClicker thread */
            Task.Run(() => DoAutoClickerThread(delay, n_repeats, repeat_until_stopped, mouse_button, click_type, x, y));

            /* Update status to show that AutoClicker is running */
            statusTB.Text = "Running";
            statusTB.BackColor = System.Drawing.ColorTranslator.FromHtml("#00e673");
        }

        private void stopB_Click(object sender, EventArgs e)
        {
            /* Stop the AutoClicker */
            is_running = false;
            startB.Enabled = true;
            stopB.Enabled = false;

            /* Update status to show that AutoClicker is inactive */
            statusTB.Text = "Standby";
            statusTB.BackColor = Color.LightGray;
        }

        private void cursorPositionCurrentLocationRB_CheckedChanged(object sender, EventArgs e)
        {
            xLocationTB.Enabled = cursorPositionCustomLocationRB.Checked;
            yLocationTB.Enabled = cursorPositionCustomLocationRB.Checked;
            pickLocationB.Enabled = cursorPositionCustomLocationRB.Checked;
        }

        private void cursorPositionCustomLocationRB_CheckedChanged(object sender, EventArgs e)
        {
            xLocationTB.Enabled = cursorPositionCustomLocationRB.Checked;
            yLocationTB.Enabled = cursorPositionCustomLocationRB.Checked;
            pickLocationB.Enabled = cursorPositionCustomLocationRB.Checked;
        }

        private void clickRepeatRepeatNTimesRB_CheckedChanged(object sender, EventArgs e)
        {
            clickRepeatRepeatNTimesNUD.Enabled = clickRepeatRepeatNTimesRB.Checked;
        }

        private void clickRepeatRepeatUntilStoppedRB_CheckedChanged(object sender, EventArgs e)
        {
            clickRepeatRepeatNTimesNUD.Enabled = clickRepeatRepeatNTimesRB.Checked;
        }

        /* NULL TEXTBOXES SET TO 0 ON LEAVE */

        private void clickIntervalHoursTB_Leave(object sender, EventArgs e)
        {
            if (clickIntervalHoursTB.Text == "") clickIntervalHoursTB.Text = "0";
        }
        private void clickIntervalMinutesTB_Leave(object sender, EventArgs e)
        {
            if (clickIntervalMinutesTB.Text == "") clickIntervalMinutesTB.Text = "0";
        }
        private void clickIntervalSecondsTB_Leave(object sender, EventArgs e)
        {
            if (clickIntervalSecondsTB.Text == "") clickIntervalSecondsTB.Text = "0";
        }
        private void clickIntervalMillisecondsTB_Leave(object sender, EventArgs e)
        {
            if (clickIntervalMillisecondsTB.Text == "") clickIntervalMillisecondsTB.Text = "0";
        }
        private void clickRepeatRepeatNTimesNUD_Leave(object sender, EventArgs e)
        {
            if (clickRepeatRepeatNTimesNUD.Text == "") clickRepeatRepeatNTimesNUD.Text = "0";
        }
        private void xLocationTB_Leave(object sender, EventArgs e)
        {
            if (xLocationTB.Text == "") xLocationTB.Text = "0";
        }
        private void yLocationTB_Leave(object sender, EventArgs e)
        {
            if (yLocationTB.Text == "") yLocationTB.Text = "0";
        }

        private void pickLocationB_Click(object sender, EventArgs e)
        {
            /* Give a countdown before taking the location */
            Task.Run(() =>
            {
                for (int i = 3; i > 0; i--)
                {
                    this.Invoke(new Action(() =>
                    {
                        pickLocationB.Text = i.ToString();
                    }));
                    System.Threading.Thread.Sleep(1000);
                }

                this.Invoke(new Action(() =>
                {
                    pickLocationB.Text = "Pick Location";
                    xLocationTB.Text = Cursor.Position.X.ToString();
                    yLocationTB.Text = Cursor.Position.Y.ToString();
                }));
            });
        }

        /* ---------- HotKey Listener ---------- */
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312) 
            {
                if (m.WParam.ToInt32() == START_HOTKEY_ID) startB_Click(null, null);
                else if (m.WParam.ToInt32() == STOP_HOTKEY_ID) stopB_Click(null, null);
            }
            base.WndProc(ref m);
        }

        /* ---------- Form Load ---------- */
        private void FOrm_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
        }

        /* ---------- Form Closing ---------- */
        private void OpenACForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, START_HOTKEY_ID);
            UnregisterHotKey(this.Handle, STOP_HOTKEY_ID);
        }

    }   /* END OF CLASS OpenACForm */
}
