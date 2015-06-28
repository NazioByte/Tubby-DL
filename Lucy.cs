using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Lucy
{
    private static Int32 _percentTag;
    private static string _fileSize;
    private static string _timeDownload;
    private static string _timeLeft;
    private static string[] rs = new string[10];

    public static void FormatTextReader(string textReader)
    {
           
            textReader = textReader.Replace(" ", "|");
            string[] w = textReader.Split('|');
            string capter = string.Empty;

            for (int i = 0; i <= w.Length - 1; i++)
            {
                if (!string.IsNullOrEmpty(w[i]))
                {
                    capter += w[i] + "|";
                }
            }

            Console.WriteLine(capter);            
            rs = capter.Split('|');
            if (rs[0] == "[download]" && rs.Length == 9)
            {
                setPercentTag();
                setFileSize();
                setTimeDownload();
                setTimeLeft();
            }
    }

    public static Int32 PercentTage
    {
        get { return _percentTag; }
        set { _percentTag = value; }
    }

    public static string FileSize
    {
        get { return _fileSize; }
        set { _fileSize = value; }
    }

    public static string TimeDownload
    {
        get { return _timeDownload; }
        set { _timeDownload = value; }
    }

    public static string TimeLeft
    {
        get { return _timeLeft; }
        set { _timeLeft = value; }
    }

    private static void setPercentTag()
    {
        string percentTmp = rs[1].Substring(0, 4).Replace("%", string.Empty);
        double percentDouble = double.Parse(percentTmp);
        int percentInt = Convert.ToInt32(percentDouble);
        PercentTage = percentInt;
    }

    private static void setFileSize()
    {
        if (rs[3].IndexOf("KiB") != -1)
        {
            var file_size = rs[3].Replace("KiB", "kB");
            FileSize = file_size;
        }
        else if (rs[3].IndexOf("MiB") != -1)
        {
            var file_size = rs[3].Replace("MiB", "MB");
            FileSize = file_size;
        }
        else if (rs[3].IndexOf("GiB") != -1)
        {
            var file_size = rs[3].Replace("GiB", "GB");
            FileSize = file_size;
        }
        else if (rs[3].IndexOf("TiB") != -1)
        {
            var file_size = rs[3].Replace("TiB", "TB");
            FileSize = file_size;
        }
        else if (rs[3].IndexOf("PiB") != -1)
        {
            var file_size = rs[3].Replace("PiB", "PB");
            FileSize = file_size;
        }
        else if (rs[3].IndexOf("EiB") != -1)
        {
            var file_size = rs[3].Replace("EiB", "EB");
            FileSize = file_size;
        }
        else if (rs[3].IndexOf("ZiB") != -1)
        {
            var file_size = rs[3].Replace("ZiB", "ZB");
            FileSize = file_size;
        }
        else if (rs[3].IndexOf("YiB") != -1)
        {
            var file_size = rs[3].Replace("YiB", "YB");
            FileSize = file_size;
        }
    }

    private static void setTimeDownload()
    {
        if (rs[5].IndexOf("KiB") != -1)
        {
            var time_download = rs[5].Replace("KiB", "kB");
            TimeDownload = time_download;
        }
        else if (rs[5].IndexOf("MiB") != -1)
        {
            var time_download = rs[5].Replace("MiB", "MB");
            TimeDownload = time_download;           
        }
        else if (rs[5].IndexOf("GiB") != -1)
        {
            var time_download = rs[5].Replace("GiB", "GB");
            TimeDownload = time_download;
        }
        else if (rs[5].IndexOf("TiB") != -1)
        {
            var time_download = rs[5].Replace("TiB", "TB");
            TimeDownload = time_download;
        }
        else if (rs[5].IndexOf("PiB") != -1)
        {
            var time_download = rs[5].Replace("PiB", "PB");
            TimeDownload = time_download;
        }
        else if (rs[5].IndexOf("EiB") != -1)
        {
            var time_download = rs[5].Replace("EiB", "EB");
            TimeDownload = time_download;
        }
        else if (rs[5].IndexOf("ZiB") != -1)
        {
            var time_download = rs[5].Replace("ZiB", "ZB");
            TimeDownload = time_download;
        }
        else if (rs[5].IndexOf("YiB") != -1)
        {
            var time_download = rs[5].Replace("YiB", "YB");
            TimeDownload = time_download;
        }
    }

    private static void setTimeLeft()
    {
        TimeLeft = rs[7];
    }
}
