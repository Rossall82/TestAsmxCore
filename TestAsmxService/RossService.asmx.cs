using System.Web.Services;

namespace TestAsmxService
{
    /// <summary>
    /// Summary description for RossService
    /// </summary>
    [WebService(Namespace = "http://rossall.dev/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RossService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string ReturnMessage(string toAppend) => $"You have provided {toAppend}";
    }

}
