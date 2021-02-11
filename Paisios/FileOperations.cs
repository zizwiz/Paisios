using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paisios
{
    public partial class Form1
    {

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Richtext File|*.rtf|Text File|*.txt";
            saveFileDialog1.Title = "Save Output Data to file";
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;

            if ((filename != "") && (rchtxtbx_output.Text != ""))
            {
                if (filename.Split('.').Last() == "rtf")
                {
                    rchtxtbx_output.SaveFile(filename, RichTextBoxStreamType.RichText);
                }
                else
                {
                    rchtxtbx_output.SaveFile(filename, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                MessageBox.Show("Nothing in output window to save");
            }

        }

        private void chkbx_log_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_log.Checked)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text File|*.txt";
                saveFileDialog1.Title = "Log Data to file";
                saveFileDialog1.ShowDialog();
                LogFileName = saveFileDialog1.FileName;
            }
        }

    }
}
