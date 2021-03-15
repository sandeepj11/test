using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProd
{
    class Program
    {

		
			
		static void Main(string[] args)
        {
         
            var client = new RestClient("https://carrierdev.myshopify.com/admin/api/2020-07/products.json");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic OWU1MzcwYTMwZGUzNDczM2ZmNTU2NTExMWJkZjQyZGQ6c2hwcGFfMTdjMjEyYTkzYjA0ZTM4MGU0M2M5Y2JiYjQyYWExZDA=");
            request.AddHeader("Content-Type", "application/json");
            StringBuilder body = new StringBuilder();
            body.Append("{ ");
            body.Append("\"product\":{");
            body.Append("\"title\":" + "\"" + " 212 Central Air Conditioner" + "\"" + ",");
            body.Append("\"sku\":" + "\"" + "24ANB148A003" + "\"" + ",");
            body.Append("\"options\":[{\"name\":\"Brand\",\"position\":1,\"values\":[" + "\"" + "Carrier" + "\"" + "]}],");
            body.Append("\"variants\":[{\"option1\":" + "\"" + "Carrier" + "\"" + ",");
            body.Append("\"title\":" + "\"" + "Carrier" + "\"" + ",");
            body.Append("\"price\":" + "\"" + "12333" + "\"" + ",");
            body.Append("\"sku\":" + "\"" + "24ANB148A003" + "\"");
            body.Append("}]}}");
            request.AddParameter("application/json",body.ToString(),ParameterType.RequestBody);
            IRestResponse response = client.Execute(request); 
           Console.WriteLine(response.StatusCode+"\n"+response.Content);
           Console.ReadKey();
        }
    }
}
