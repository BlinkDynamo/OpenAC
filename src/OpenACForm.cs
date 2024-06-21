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


namespace OpenAC
{
    public partial class OpenACForm : Form
    {
        /* IMPORTS */
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        /* MOUSE ACTIONS */
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        /* RUNTIME VARIABLES */
        int delay;  /* in milliseconds */
        int n_repeats;
        bool repeat_until_stopped;
        int x;
        int y;
        string mouse_button;
        string click_type;
        bool is_running;

        /* CONSTANTS */
        private const int DOUBLE_CLICK_DELAY = 50;

        /* CONSTRUCTOR */
        public OpenACForm()
        {
            InitializeComponent();

            SetDefaultControls();
        }

        /* ---------- METHOD DECLARATIONS ---------- */
        void SetDefaultControls()
        {
            /* Sets default values for all controls, prior to any user input or logic */

            /* Click Interval */
            clickIntervalHoursTB.Text = "0";
            clickIntervalMinutesTB.Text = "0";
            clickIntervalSecondsTB.Text = "0";
            clickIntervalMillisecondsTB.Text = "500";

            /* Click Options */
            clickOptionsMouseButtonCB.SelectedIndex = 0;
            clickOptionsClickTypeCB.SelectedIndex = 0;

            /* Click Repeat */
            clickRepeatRepeatUntilStoppedRB.Checked = true;
            clickRepeatRepeatNTimesRB.Checked = false;
            
            /* Cursor Position */
            cursorPositionCurrentLocationRB.Checked = true;
            cursorPositionCustomLocationRB.Checked = false;

            /* Program State */
            startB.Enabled = true;
            stopB.Enabled = false;
        }

        void DoAutoClicker()
        /* DoAutoClicker is the main function that handles the active state of the AutoClicker */
        {
            getData();  

            while (is_running)  
            {
                
                DoMouseClick(x, y);

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
                    is_running = false;
                }
            }
        }

        void getData()
        {
            /* Reads in data from all controls and stores them in variables */

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

            /* Set x and y from cursorPosition Radio Buttons */
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
        }

        void DoMouseClick(int x, int y)
        {
            if (mouse_button == "left")
            {
                if (click_type == "single")
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
                    System.Threading.Thread.Sleep(DOUBLE_CLICK_DELAY);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
                }
            }
            else
            {
                if (click_type == "single")
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)x, (uint)y, 0, 0);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)x, (uint)y, 0, 0);
                    System.Threading.Thread.Sleep(DOUBLE_CLICK_DELAY);
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)x, (uint)y, 0, 0);
                }
            }
        }       

        /* ---------- EVENT HANDLERS ---------- */

        private void startB_Click(object sender, EventArgs e)
        {      
            is_running = true;
            startB.Enabled = false;
            stopB.Enabled = true;

            /* Start the AutoClicker */
            DoAutoClicker();
        }

        private void stopB_Click(object sender, EventArgs e)
        {
            /* Stop the AutoClicker */
            is_running = false;
            startB.Enabled = true;
            stopB.Enabled = false;       
        }
    }   /* END OF CLASS OpenACForm */
}
