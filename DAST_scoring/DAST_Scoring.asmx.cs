using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using FCC.ScriptLink;

namespace DAST_scoring
{
    /// <summary>
    /// Summary description for DAST_Scoring
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DAST_Scoring : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetVersion()
        {
            return "1.0";
        }
         

        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 inputObject, String ScriptParameter)
        {
            OptionObject2015 rObject = new OptionObject2015(inputObject);

            string Q1 = inputObject.GetFieldValue("425.74");
            string Q2 = inputObject.GetFieldValue("425.75");
            string Q3 = inputObject.GetFieldValue("425.76");
            string Q4 = inputObject.GetFieldValue("425.77");
            string Q5 = inputObject.GetFieldValue("425.78");
            string Q6 = inputObject.GetFieldValue("425.79");
            string Q7 = inputObject.GetFieldValue("425.8");
            string Q8 = inputObject.GetFieldValue("425.81");
            string Q9 = inputObject.GetFieldValue("425.82");
            string Q10 = inputObject.GetFieldValue("425.83");

            int q_1;
            int q_2;
            int q_3;
            int q_4;
            int q_5;
            int q_6;
            int q_7;
            int q_8;
            int q_9;
            int q_10;

            int total;

            if (Q1 != "" && Q1 == "1")
            {
                q_1 = 1;
            }
            else
            {
                q_1 = 0;
            } 

            if (Q2 != "" && Q2 == "1")
            {
                q_2 = 1;
            }
            else
            {
                q_2 = 0;
            }

            if (Q3 != "" && Q3 == "1")
            {
                q_3 = 1;
            }
            else
            {
                q_3 = 0;
            }

            if (Q4 != "" && Q4 == "1")
            
            {
                q_4 = 1;
            }
            else
            {
                q_4 = 0;
            }

            if (Q5 != "" && Q5 == "1")
            {
                q_5 = 1;
            }
            else
            {
                q_5 = 0;
            }

            if (Q6 != "" && Q6 == "1")
            {
                q_6 = 1;
            }
            else
            {
                q_6 = 0;
            }

            if (Q7 != "" && Q7 == "1")
            {
                q_7 = 1;
            }
            else
            {
                q_7 = 0;
            }

            if (Q8 != "" && Q8 == "1")
            {
                q_8 = 1;
            }
            else
            {
                q_8 = 0;
            }

            if (Q9 != "" && Q9 == "1")
            {
                q_9 = 1;
            }
            else
            {
                q_9 = 0;
            }

            if (Q10 != "" && Q10 == "1")
            {
                q_10 = 1;
            }
            else
            {
                q_10 = 0;
            }

            int sum = q_1 + q_2 + q_4 + q_5 + q_6 + q_7 + q_8 + q_9 + q_10;
            
            if (Q3 == "")
            {
                q_3 = 0;
                total = sum;
            }
            else if (q_3 == 1)
            {
                total = sum;
            }
            else
            {
                total = sum + 1;
            }
          
            rObject.SetFieldAsLocked("290.19");
            rObject.SetFieldValue("290.19", $"{total}");

            return rObject;
        }
    }
}