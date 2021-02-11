using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenteredMessagebox; // use to centre box on centre of parent


namespace Paisios
{
    public partial class Form1
    {

        private void btn_seq_help_Click(object sender, EventArgs e)
        {
            MsgBox.Show("Write in the box the sequence of the data you want to send e.g.\r\r1\r2\r6\r4\r5\r3\r etc\r\rYou do not need to run all the items in the data arena.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btn_run_seq_Click(object sender, EventArgs e)
        {
            if (rchtxtbx_run_seq.Text == "")
            {
                MsgBox.Show("There is no sequence to run.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < rchtxtbx_run_seq.Lines.Length; i++)
                {
                    switch (rchtxtbx_run_seq.Lines[i])
                    {
                        case "1":
                            for (int j = 0; j < Int32.Parse(txtbx_iterations1.Text); j++) // times to send file
                            {
                                Invoke(new Action(() =>
                                {
                                    SendData(txtSendData_1.Text);
                                }));
                                await Task.Delay(Int32.Parse(txtbx_delay1.Text)); //add any delay between sends
                            }

                            break;
                        case "2":
                            for (int j = 0; j < Int32.Parse(txtbx_iterations2.Text); j++) // times to send file
                            {
                                Invoke(new Action(() =>
                                {
                                    SendData(txtSendData_2.Text);
                                }));
                                await Task.Delay(Int32.Parse(txtbx_delay2.Text)); //add any delay between sends
                            }

                            break;
                        case "3":
                            for (int j = 0; j < Int32.Parse(txtbx_iterations3.Text); j++) // times to send file
                            {
                                Invoke(new Action(() =>
                                {
                                    SendData(txtSendData_3.Text);
                                }));
                                await Task.Delay(Int32.Parse(txtbx_delay3.Text)); //add any delay between sends
                            }

                            break;
                        case "4":
                            for (int j = 0; j < Int32.Parse(txtbx_iterations4.Text); j++) // times to send file
                            {
                                Invoke(new Action(() =>
                                {
                                    SendData(txtSendData_4.Text);
                                }));
                                await Task.Delay(Int32.Parse(txtbx_delay4.Text)); //add any delay between sends
                            }

                            break;
                        case "5":
                            for (int j = 0; j < Int32.Parse(txtbx_iterations5.Text); j++) // times to send file
                            {
                                Invoke(new Action(() =>
                                {
                                    SendData(txtSendData_5.Text);
                                }));
                                await Task.Delay(Int32.Parse(txtbx_delay5.Text)); //add any delay between sends
                            }

                            break;
                        case "6":
                            for (int j = 0; j < Int32.Parse(txtbx_iterations6.Text); j++) // times to send file
                            {
                                Invoke(new Action(() =>
                                {
                                    SendData(txtSendData_6.Text);
                                }));
                                await Task.Delay(Int32.Parse(txtbx_delay6.Text)); //add any delay between sends
                            }

                            break;
                        default:
                            MsgBox.Show("There is no such sequence to run.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
        }
    }
}

