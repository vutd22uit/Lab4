using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetHtml_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string htmlContent = GetHtmlContent(url);
            rtbHtmlContent.Text = htmlContent;
        }
        private string GetHtmlContent(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    string responseFromServer = reader.ReadToEnd();
                    return responseFromServer;
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
