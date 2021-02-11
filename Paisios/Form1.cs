using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using help_about;
using Paisios.Properties;

namespace Paisios
{
    #region Public Enumerations
    public enum DataMode { Text, Hex }
    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };
    #endregion

    public partial class Form1 : Form
    {
        #region Private Variables

        // Various colors for logging info
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };

        // Temp holder for whether a key was pressed
        private bool KeyHandled = false;

        private Settings settings = Settings.Default;

        private string LogFileName = "";

        #endregion



        public Form1()
        {
            InitializeComponent();

            // Restore the users settings
            InitializeControlValues();

            // Enable/disable controls based on the current state
            EnableControls();
        }



        #region Local Properties

        private DataMode CurrentDataMode
        {
            get
            {
                if (rbHex.Checked) return DataMode.Hex;
                else return DataMode.Text;
            }

            set
            {
                if (value == DataMode.Text) rbText.Checked = true;
                else rbHex.Checked = true;
            }
        }

        #endregion






        /// <summary> Log data to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        private void Log(LogMsgType msgtype, string msg)
        {
            rchtxtbx_output.Invoke(new EventHandler(delegate
            {
                if (rchtxtbx_output.Lines.Length > 1000
                ) //remove 500 lines when over 1000 to make sure we do not slow down.
                {
                    rchtxtbx_output.Select(0,
                        rchtxtbx_output.GetFirstCharIndexFromLine(rchtxtbx_output.Lines.Length - 500));
                    rchtxtbx_output.SelectedText = "";
                }

                rchtxtbx_output.SelectedText = string.Empty;
                rchtxtbx_output.SelectionFont = new Font(rchtxtbx_output.SelectionFont, FontStyle.Bold);
                rchtxtbx_output.SelectionColor = LogMsgTypeColor[(int)msgtype];

                if (chkbx_show_data.Checked)
                {
                    if (chckbx_timestamp.Checked) // Check if we are using timestamp or not.
                    {
                        rchtxtbx_output.AppendText(GetTimestamp(DateTime.Now) + msg);
                    }
                    else
                    {
                        rchtxtbx_output.AppendText(msg);
                    }
                }

                rchtxtbx_output.ScrollToCaret();
            }));

            if (chkbx_log.Checked)
            {
                using (StreamWriter sr = File.AppendText(LogFileName))
                {
                    if (chckbx_timestamp.Checked) // Check if we are using timestamp or not.
                    {
                        sr.WriteLine(GetTimestamp(DateTime.Now) + msg);
                    }
                    else
                    {
                        sr.WriteLine(msg);
                    }
                    sr.Close();
                }

            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxtbx_output.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // The form is closing, save the user's preferences
            SaveSettings();
        }


        private void btn_help_Click(object sender, EventArgs e)
        {
            Help_Form help = new Help_Form();
            help.Show();
        }

        public String GetTimestamp(DateTime value)
        {
            string result = "";
            if (chckbx_timestamp.Checked)
            {
                result = value.ToString("HH:mm:ss.ffff") + "   ";
            }

            return result;
        }



        private void rchtxtbx_output_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                 ContextMenu contextMenu = new ContextMenu();

                 MenuItem menuItem = new MenuItem("Clear");
                 menuItem.Click += new EventHandler(ClearAction);
                 contextMenu.MenuItems.Add(menuItem);

                 menuItem = new MenuItem("Select All");
                 menuItem.Click += new EventHandler(SelectAllAction);
                 contextMenu.MenuItems.Add(menuItem);

                 menuItem = new MenuItem("Cut");
                 menuItem.Click += new EventHandler(CutAction);
                 contextMenu.MenuItems.Add(menuItem);

                 menuItem = new MenuItem("Copy");
                 menuItem.Click += new EventHandler(CopyAction);
                 contextMenu.MenuItems.Add(menuItem);

                 menuItem = new MenuItem("Paste");
                 menuItem.Click += new EventHandler(PasteAction);
                 contextMenu.MenuItems.Add(menuItem);

                 rchtxtbx_output.ContextMenu = contextMenu;
            }

        }

        void ClearAction(object sender, EventArgs e)
        {
            rchtxtbx_output.Focus();
            rchtxtbx_output.Clear();
        }

        void SelectAllAction(object sender, EventArgs e)
        {
            rchtxtbx_output.Focus();
            rchtxtbx_output.SelectAll();
        }

        void CutAction(object sender, EventArgs e)
        {
            rchtxtbx_output.Focus();
            rchtxtbx_output.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            rchtxtbx_output.Focus();
            Clipboard.SetText(rchtxtbx_output.SelectedText);
        }

        void PasteAction(object sender, EventArgs e)
        {
            rchtxtbx_output.Focus();
            if (Clipboard.ContainsText())
            {
                rchtxtbx_output.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }

    }
}
