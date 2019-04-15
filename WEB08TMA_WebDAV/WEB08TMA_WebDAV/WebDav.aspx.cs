using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB08TMA_WebDAV
{
    public partial class WebDav : System.Web.UI.Page
    {
        #region Password

        string emailOpenDrive = "maxim.tickhonovich@gmail.com";
        string passwordOpenDrive = "";
        #endregion Password

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createDirectory_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = HttpWebRequest.Create("https://webdav.opendrive.com/maxik") as HttpWebRequest;
            request.Credentials = new NetworkCredential("maxim.tickhonovich@gmail.com", "qwert12345");
            request.Method = WebRequestMethods.Http.MkCol;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            HttpStatusCode code = response.StatusCode;
        }

        protected void deleteDirectory_Click(object sender, EventArgs e)
        {
            //https://webdav.yandex.ru/maximka
            HttpWebRequest request = HttpWebRequest.Create("https://webdav.opendrive.com/maxik") as HttpWebRequest;
            request.Credentials = new NetworkCredential(emailOpenDrive, passwordOpenDrive);
            request.Method = "DELETE";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            HttpStatusCode code = response.StatusCode;
        }

        protected void deleteFile_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = HttpWebRequest.Create("https://webdav.opendrive.com/sert.jpg") as HttpWebRequest;
            request.Credentials = new NetworkCredential(emailOpenDrive, passwordOpenDrive);
            request.Method = "DELETE";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            HttpStatusCode code = response.StatusCode;
        }

        protected void downloadFile_Click(object sender, EventArgs e)
        {
            string url = "https://webdav.opendrive.com/test.docx";
            string save_path = "D:\\";
            string name = "Тестовый файл.docx";

            WebClient wc = new WebClient();
            wc.Credentials = new NetworkCredential(emailOpenDrive, passwordOpenDrive);
            wc.DownloadFile(url, save_path + name);
        }

        protected void uploadFile_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://webdav.opendrive.com/1/my.txt");
            req.Credentials = new NetworkCredential(emailOpenDrive, passwordOpenDrive);
            req.Accept = "*/*";
            req.Headers.Add("Depth: 1");
            req.Method = "PUT";
            req.ContentType = "application/binary";
            using (Stream myReqStream = req.GetRequestStream())
            {
                using (FileStream myFile = new FileStream("E:\\lol.txt", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader myReader = new BinaryReader(myFile))
                    {
                        byte[] buffer = myReader.ReadBytes(2048);
                        while (buffer.Length > 0)
                        {
                            myReqStream.Write(buffer, 0, buffer.Length);
                            buffer = myReader.ReadBytes(2048);
                        }
                    }
                }
            }
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        }

        protected void CopyFile_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = HttpWebRequest.Create("https://webdav.opendrive.com/1/sert.jpg") as HttpWebRequest;
            req.Credentials = new NetworkCredential(emailOpenDrive, passwordOpenDrive);
            req.Method = "COPY";
            req.Headers.Add("Destination", "https://webdav.opendrive.com/2/copy.jpg");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            HttpStatusCode code = res.StatusCode;
        }

    }
}