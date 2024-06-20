using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenAC
{

    /* a struct for storing all data needed to run AutoClicker */
    public struct ACData
    {
        int delay;
        int duration;
        int n_repeats;
        int x;
        int y;
        string mouse_button;
        string click_type;
        bool repeat_until_stopped;
        bool is_running;
    }

    public partial class OpenACForm : Form
    {
        /* constructor */
        public OpenACForm()
        {
            InitializeComponent();

            SetDefaultControls();
        }

        /* set default values for all controls */

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

    }   /* END OF CLASS OpenACForm */
}
