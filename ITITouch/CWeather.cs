using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace ITITouch.Weather
{
    public class CWeather
    {
        public static string GetAllWetherInfo() 
        {
            string info = "";
            info = GetCityWetherInfo("天津");
            return info;
        }

        public static string GetCityWetherInfo(string cityName) 
        {
            string strWether="";
            string CenterName="";
            string url="";

            string CityCName="";
            string rootName="";

            if (cityName == "天津") 
            
            {
                url = "http://flash.weather.com.cn/wmaps/xml/" + "tianjin.xml";
                CenterName = "北辰";
                cityName = "天津";
                rootName = "tianjin";
                
            }
            strWether = GetFileData(url, CenterName, rootName);
            return strWether == "" ? "" : CityCName + strWether;

        }
        public static string GetFileData(string url, string CenterName, string RootName) 
        {
            string info = "";
            try
            {
                Uri uri = new Uri(url);
                HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(uri);
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";
                request.AllowAutoRedirect = false;
                request.Timeout = 5000;
                HttpWebResponse resopne = (HttpWebResponse)request.GetResponse();
                Stream responeStream = resopne.GetResponseStream();
                if (responeStream != null)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(responeStream);
                    XmlNode node = doc.SelectSingleNode("/" + RootName + "/city[@centername='" + CenterName + "']");
                    if (node != null)
                    {
                        info += " " + node.Attributes["tem2"].Value.ToString() + "℃~" + node.Attributes["tem1"].Value.ToString() + "℃";
                        info += " " + node.Attributes["temNow"].Value.ToString() + "°";
                        info += " " + node.Attributes["stateDetailed"].Value.ToString();
                        info += " " + node.Attributes["windDir"].Value.ToString();
                        info += " " + node.Attributes["windPower"].Value.ToString();
                        info += " "+node.Attributes["time"].Value.ToString();


                    }
                }
            }
            catch (Exception e)
            {
                info = "";
            }
            return info;

        }
       
    }
}
