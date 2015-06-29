using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebVideoDownloader_2
{
    public partial class frmMain : Form
    {
        public Process m_Process;
        public Thread m_OutputThread;
        public Thread m_ErrorThread;
        private ListViewItem vi;
        private frmAddVdo addvdo = new frmAddVdo();
        public int proId;
        public string reader;        
     
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestConsole();
        }       

        protected void StreamInput(string text, int progressIndex)
        {
            this.m_Process.StandardInput.WriteLine(text);
            this.m_Process.StandardInput.Flush();
            proId = progressIndex;
        }

        protected string ConvertFromOem(string text)
        {
            return Encoding.GetEncoding(CultureInfo.InstalledUICulture
                .TextInfo.OEMCodePage).GetString(
                Encoding.Default.GetBytes(text));
        }

        protected void StreamOutput()
        {
            string line = this.m_Process.StandardOutput.ReadLine();
            try
            {
                do
                {
                    if (line.Length > 0)
                    {
                        Downloading(ConvertFromOem(line));
                    }
                    line = this.m_Process.StandardOutput.ReadLine();
                } while (line.Length >= 0);
            }
            catch { }
        }

        protected void Downloading(string text)
        {
              Lucy.FormatTextReader(text);

              /* progressBar1.Invoke(new Action(() =>
                    progressBar1.Value = Lucy.PercentTage));

               label1.Invoke(new Action(() =>
                   label1.Text = Lucy.PercentTage + "%"));

            label2.Invoke(new Action(() =>
                label2.Text = "ขนาดไฟล์ " + Lucy.FileSize));

            label3.Invoke(new Action(() =>
                label3.Text = "อัตราการดาวน์โหลด " + Lucy.TimeDownload));

            label4.Invoke(new Action(() =>
                label4.Text = "เวลาที่เหลือ " + Lucy.TimeLeft));*/
            
        }

        protected void StreamError()
        {
            string line = this.m_Process.StandardError.ReadLine();
            try
            {
                do
                {
                    line = this.m_Process.StandardError.ReadLine();
                    if (line.Length > 0)
                    {
                        Downloading(line);
                    }
                } while (line.Length >= 0);
            }
            catch { }
        }

        
        public void TestConsole()
        {
            m_Process = new Process();
            m_Process.StartInfo.FileName = "cmd";
            m_Process.StartInfo.UseShellExecute = false;
            m_Process.StartInfo.CreateNoWindow = true;
            m_Process.StartInfo.RedirectStandardOutput = true;
            m_Process.StartInfo.RedirectStandardError = true;
            m_Process.StartInfo.RedirectStandardInput = true;

            m_Process.Start();
            m_OutputThread = new Thread(StreamOutput);
            m_OutputThread.IsBackground = true;
            m_OutputThread.Start();

            m_ErrorThread = new Thread(StreamError);
            m_ErrorThread.IsBackground = true;
            m_ErrorThread.Start();
            StreamInput(@"C:\Users\Kirati\Desktop\2ddf\youtube-dl U1kPywbxQHk", 0);
            //wZZ7oFKsKzY 
            //09R8_2nJtjg
        }
         
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tubbby-DL v1.0 for YouTube.com\nProgrammed by Kirati Petkong\n(kiratisonic555@gmail.com)",
                "เกี่ยวกับโปรแกรม",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult addvdoDlg = addvdo.ShowDialog(this);

            if (addvdoDlg == DialogResult.OK)
            {
                try
                {
                    if (addvdo.txtUrl.Text.IndexOf("www.youtube.com") != -1)
                    {
                        TubeListener listener = new TubeListener(addvdo.txtUrl.Text,
                                                addvdo.comboFormatType.Text, "พร้อม", getFormatCommand());

                        vi = new ListViewItem(listener.Title);
                        vi.SubItems.Add(listener.FormatType);
                        vi.SubItems.Add(listener.Status);
                        vi.SubItems.Add(listener.YoutubeID);
                        vi.SubItems.Add(listener.FormatCommand);
                        this.xvi.Items.AddRange(new ListViewItem[] { vi });
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเพิ่มวีดีโอได้ โปรดตรวจสอบความถูกต้องของ URL ใหม่อีกครั้ง", "ผิดพลาด",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                    
                catch (Exception)
                {
                    MessageBox.Show("ไม่สามารถเพิ่มวีดีโอได้ โปรดตรวจสอบความถูกต้องของ URL ใหม่อีกครั้ง","ผิดพลาด", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private string getFormatCommand()
        {
            var result = "";

            if (ICompound.Paneltype == "Sound")
            {
                if (addvdo.comboBitrateSound.Text != "Auto")
                {
                    result += " -ab " + addvdo.comboBitrateSound.Text;
                }
                else
                {
                    result += string.Empty;
                }


                if (addvdo.comboSoundType.Text == "Stereo")
                {
                    result += " -c:v copy -c:a libmp3lame -ac 2 -q:a 2";
                }
                else if (addvdo.comboSoundType.Text == "Mono")
                {
                    result += " -c:v copy -c:a libmp3lame -ac 1 -q:a 2";
                }
                else
                {
                    result += string.Empty;
                }

                if (addvdo.comboHZSound.Text != "Auto")
                {
                    result += " -ar " + addvdo.comboHZSound.Text;
                }
                else
                {
                    result += string.Empty;
                }
                
            }

            else if (ICompound.Paneltype == "Video")
            {
                if (addvdo.comboResolution.Text != "Auto")
                {
                    result += " -s " + addvdo.comboResolution.Text
                        .Substring(0,12).Replace(" x ", "x");
                }
                else
                {
                    result += string.Empty;
                }

                if (addvdo.comboVdoBitrate.Text != "Auto")
                {
                    result += " -b:v " + addvdo.comboVdoBitrate.Text + "k";
                }
                else
                {
                    result += string.Empty;
                }

                if (addvdo.comboFrameRate.Text != "Auto")
                {
                    result += " -r " + addvdo.comboFrameRate.Text;
                }
                else
                {
                    result += string.Empty;
                }

                if (addvdo.comboAspectRatio.Text != "Auto")
                {
                    result += " -aspect " + addvdo.comboAspectRatio.Text;
                }
                else
                {
                    result += string.Empty;
                }

                if (addvdo.comboDelsound.Text == "ใช่")
                {
                    result += " -an ";
                }
                else
                {
                    result += string.Empty;
                }
            }

            return " -y " + result;
        }
       
    }
}
