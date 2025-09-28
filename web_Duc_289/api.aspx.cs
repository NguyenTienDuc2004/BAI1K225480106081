using System;
using DLL; // dùng DLL 
using System.Web.UI;

namespace web_Duc_289
{
    public partial class api : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json";

            string k1 = Request.QueryString["k1"];
            string k2 = Request.QueryString["k2"];
            string k3 = Request.QueryString["k3"];

            if (string.IsNullOrEmpty(k1) || string.IsNullOrEmpty(k2) || string.IsNullOrEmpty(k3))
            {
                Response.Write("{\"error\":\"Thiếu tham số k1, k2, k3\"}");
                return;
            }

            Class1 storyGen = new Class1();
            string story = storyGen.GenerateStory(k1, k2, k3);

            // trả về JSON
            Response.Write("{\"story\":\"" + story.Replace("\"", "\\\"") + "\"}");
        }
    }
}
