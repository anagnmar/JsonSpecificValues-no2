using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace ConsoleApp1
{

    public class MajorIssue
    {
        public int attributeId { get; set; }
        public string attributeKey { get; set; }
        public string attributeValue { get; set; }
    }

    public class Attributes
    {
        public MajorIssue majorIssues { get; set; }
    }

    public class RootObject
    {
        public string Name { get; set; }
        public string policyName { get; set; }
        public string targetResource { get; set; }
        public Attributes attributes { get; set; }
        public bool enabled { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string json = "{\"Name\":\"Kumar\",\"policyName\":\"Lic\",\"targetResource\":\"3Months\",\"attributes\":{\"MajorIssue\":{\"attributeId\":1,\"attributeKey\":\"check\",\"attributeValue\":\"7776000000\"}},\"enabled\":true}";


            dynamic Result = JsonConvert.DeserializeObject<dynamic>(json);

            var value = Result["attributes"]["MajorIssue"]["attributeValue"].ToString();

            Console.WriteLine("attributeValue: " + value);
        }
    }
}
    //dynamic Result_ = JsonConvert.DeserializeObject();

    //dynamic Result = JsonConvert.DeserializeObject<RootObject>(json);
