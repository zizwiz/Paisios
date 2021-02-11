using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Paisios
{
    public partial class Form1
    {

        private void InitializeControlValues()
        {
            cmbParity.Items.Clear(); cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            cmbParity.Text = settings.Parity.ToString();
            cmbStopBits.Text = settings.StopBits.ToString();
            cmbDataBits.Text = settings.DataBits.ToString();
            cmbParity.Text = settings.Parity.ToString();
            cmbBaudRate.Text = settings.BaudRate.ToString();
            CurrentDataMode = settings.DataMode;
            txtbx_delay.Text = settings.SendDelay;
            txtbx_times_line.Text = settings.TimesEachLine;
            txtbx_times_file.Text = settings.TimesFile;

            txtSendData_1.Text = settings.TxtBx1;
            txtSendData_2.Text = settings.TxtBx2;
            txtSendData_3.Text = settings.TxtBx3;
            txtSendData_4.Text = settings.TxtBx4;
            txtSendData_5.Text = settings.TxtBx5;
            txtSendData_6.Text = settings.TxtBx6;

            txtbx_delay1.Text = settings.Delay1;
            txtbx_delay2.Text = settings.Delay2;
            txtbx_delay3.Text = settings.Delay3;
            txtbx_delay4.Text = settings.Delay4;
            txtbx_delay5.Text = settings.Delay5;
            txtbx_delay6.Text = settings.Delay6;

            txtbx_iterations1.Text = settings.Iteration1;
            txtbx_iterations2.Text = settings.Iteration2;
            txtbx_iterations3.Text = settings.Iteration3;
            txtbx_iterations4.Text = settings.Iteration4;
            txtbx_iterations5.Text = settings.Iteration5;
            txtbx_iterations6.Text = settings.Iteration6;

            RefreshComPortList();

            // If it is still avalible, select the last com port used
            if (cmbPortName.Items.Contains(settings.PortName)) cmbPortName.Text = settings.PortName;
            else if (cmbPortName.Items.Count > 0) cmbPortName.SelectedIndex = cmbPortName.Items.Count - 1;
            else
            {
                MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary> Enable/disable controls based on the app's current state. </summary>
        private void EnableControls()
        {
            // Enable/disable controls based on whether the port is open or not
            cmbPortName.Enabled = cmbBaudRate.Enabled = cmbParity.Enabled = cmbDataBits.Enabled = cmbStopBits.Enabled = !serialPort1.IsOpen;
            grpbx_seq.Enabled = gbMode.Enabled = grpbx_send_file.Enabled = grpbx_Send_Data.Enabled = serialPort1.IsOpen;
            
            if (serialPort1.IsOpen)
            {
                btnOpenPort.Text = "&Close Port";
                cmbPortName.Enabled = cmbBaudRate.Enabled = cmbParity.Enabled = cmbDataBits.Enabled = cmbStopBits.Enabled = false;

            }
            else
            {
                btnOpenPort.Text = "&Open Port";
                cmbPortName.Enabled = cmbBaudRate.Enabled = cmbParity.Enabled = cmbDataBits.Enabled = cmbStopBits.Enabled = true;
            }
        }

        /// <summary> Save the user's settings. </summary>
        private void SaveSettings()
        {
            settings.BaudRate = int.Parse(cmbBaudRate.Text);
            settings.DataBits = int.Parse(cmbDataBits.Text);
            settings.DataMode = CurrentDataMode;
            settings.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
            settings.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
            settings.PortName = cmbPortName.Text;
            settings.SendDelay = txtbx_delay.Text;
            settings.TimesEachLine = txtbx_times_line.Text;
            settings.TimesFile = txtbx_times_file.Text;

            settings.TxtBx1 = txtSendData_1.Text;
            settings.TxtBx2 = txtSendData_2.Text;
            settings.TxtBx3 = txtSendData_3.Text;
            settings.TxtBx4 = txtSendData_4.Text;
            settings.TxtBx5 = txtSendData_5.Text;
            settings.TxtBx6 = txtSendData_6.Text;

            settings.Delay1 = txtbx_delay1.Text;
            settings.Delay2 = txtbx_delay2.Text;
            settings.Delay3 = txtbx_delay3.Text;
            settings.Delay4 = txtbx_delay4.Text;
            settings.Delay5 = txtbx_delay5.Text;
            settings.Delay6 = txtbx_delay6.Text;

            settings.Iteration1 = txtbx_iterations1.Text;
            settings.Iteration2 = txtbx_iterations2.Text;
            settings.Iteration3 = txtbx_iterations3.Text;
            settings.Iteration4 = txtbx_iterations4.Text;
            settings.Iteration5 = txtbx_iterations5.Text;
            settings.Iteration6 = txtbx_iterations6.Text;

            settings.Save();
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        { if (rbText.Checked) CurrentDataMode = DataMode.Text; }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        { if (rbHex.Checked) CurrentDataMode = DataMode.Hex; }


    }
}
