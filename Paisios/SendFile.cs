using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paisios
{
    public partial class Form1
    {
        private async void btn_send_file_Click(object sender, EventArgs e)
        {
            rchtxtbx_output.Focus();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                for (int i = 0; i < Int32.Parse(txtbx_times_file.Text); i++) // times to send file
                {
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            for (int j = 0; j < Int32.Parse(txtbx_times_line.Text); j++) //loop times to send each line
                            {
                                SendData(line);
                                //rchtxtbx_output.AppendText((line + "\r"));
                                await Task.Delay(Int32.Parse(txtbx_delay.Text)); //add any delay between sends
                            }
                        }

                    }
                }
            }
        }

    }
}
