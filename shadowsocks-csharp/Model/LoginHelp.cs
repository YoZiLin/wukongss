using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Shadowsocks.Model
{
    public class LoginHelp
    {

        public static List<NodesInfo> LoginAction(string password, string port, ref string message,ref string encryption)
        {
            string loginApiUrl = "https://www.wukongss.com/api/applogin.json";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("port", port);
            parameters.Add("password", MD5Fun(password));

            ResultInfo<UserInfo> userInfo = HttpWebResponseUtility.CreatePostHttpResponse<ResultInfo<UserInfo>>(loginApiUrl, parameters);

            List<NodesInfo> list = new List<NodesInfo>();
            if (userInfo != null)
            {
                switch (userInfo.code)
                {
                    case "8000":
                        encryption = userInfo.data.encryption;
                        DateTime timeStamp = new DateTime(1970, 1, 1);
                        long a = (DateTime.UtcNow.Ticks - timeStamp.Ticks) / 10000000;
                        string nodesUrl = "https://www.wukongss.com/api/nodes.json";
                        string sign = MD5Fun(a.ToString() + userInfo.data.token);
                        Dictionary<string, string> pars = new Dictionary<string, string>();
                        pars.Add("timestamp", a.ToString());
                        pars.Add("token", HttpUtility.UrlEncode(userInfo.data.token));
                        pars.Add("sign", HttpUtility.UrlEncode(sign));
                        ResultInfo<List<NodesInfo>> result = HttpWebResponseUtility.CreatePostHttpResponse<ResultInfo<List<NodesInfo>>>(nodesUrl, pars);
                        if (result.code == "6000")
                        {
                            list = result.data;
                        }
                        else
                        {
                            message = "获取服务器节点列表失败";
                        }
                        break;
                    case "8001":
                        message = "密码错误";
                        break;
                    default:
                        message = "系统异常，请联系管理员！";
                        break;
                }
            }
            return list;
        }

        private static string MD5Fun(string text)
        {
            byte[] data = Encoding.GetEncoding("GB2312").GetBytes(text);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] OutBytes = md5.ComputeHash(data);
            string OutString = "";
            for (int i = 0; i < OutBytes.Length; i++)
            {
                OutString += OutBytes[i].ToString("x2");
            }
            return OutString;
        }

        public class NodesInfo
        {
            public string id { get; set; }
            public string name { get; set; }
            public string server { get; set; }
            public string remark { get; set; }
        }

        public class ResultInfo<T>
        {
            public string code { get; set; }
            public T data { get; set; }
            public string message { get; set; }
        }

        public class UserInfo
        {
            public string token { get; set; }
            public string plan { get; set; }
            public string transfer { get; set; }
            public string flow_down { get; set; }
            public string flow_left { get; set; }
            public string encryption { get; set; }
            public string expire_time { get; set; }
        }
    }
}
