using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading.Tasks;

namespace WebVideoDownloader_2
{
    class TubeListener
    {
        public string Title { get; set; }
        public string FormatType { get; set; }
        public string Status { get; set; }
        public string YoutubeID { get; set; }
        public string FormatCommand { get; set; }
        private const string YoutubeLinkRegex = "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+";
                
        public TubeListener(string url, string formattype, string status, string formatcommand)
        {
            Title = getWebTitle(url);
            YoutubeID = getYoutubeID(url);
            FormatType = formattype;
            FormatCommand = formatcommand;
            Status = status;
        }

        private string getWebTitle(string url)
        {            
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string source = client.DownloadString(url);
            string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", 
                RegexOptions.IgnoreCase).Groups["Title"].Value;
            
            return title;
        }

        private string getYoutubeID(string url)
        {
            var regex = new Regex(YoutubeLinkRegex, RegexOptions.Compiled);
            foreach (Match match in regex.Matches(url))
            {                
                foreach (var groupdata in match.Groups.Cast<Group>().Where(groupdata => !groupdata.ToString().StartsWith("http://") && !groupdata.ToString().StartsWith("https://") && !groupdata.ToString().StartsWith("youtu") && !groupdata.ToString().StartsWith("www.")))
                {
                    return groupdata.ToString();
                }
            }
            return string.Empty;
        }

        
    }
}
