using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotOfExile
{
	class Unique
	{
        public class Rootobject
        {
            public Query query { get; set; }
        }

        public class Query
        {
            public Printrequest[] printrequests { get; set; }
            public Results results { get; set; }
            public string serializer { get; set; }
            public int version { get; set; }
            public Meta meta { get; set; }
        }

        public class Results
        {
            public ArakuTiki ArakuTiki { get; set; }
        }

        public class ArakuTiki
        {
            public Printouts printouts { get; set; }
            public string fulltext { get; set; }
            public string fullurl { get; set; }
            public int _namespace { get; set; }
            public string exists { get; set; }
            public string displaytitle { get; set; }
        }

        public class Printouts
        {
            public string[] Hasname { get; set; }
            public string[] Hasbaseitem { get; set; }
            public object[] Hasquality { get; set; }
            public object[] Hasarmourrangetext { get; set; }
            public int[] Hasbaselevelrequirement { get; set; }
            public object[] Hasbasestrengthrequirement { get; set; }
            public string[] Hasimplicitstattext { get; set; }
            public string[] Hasexplicitstattext { get; set; }
            public string[] Hasflavourtext { get; set; }
        }

        public class Meta
        {
            public string hash { get; set; }
            public int count { get; set; }
            public int offset { get; set; }
            public string source { get; set; }
            public string time { get; set; }
        }

        public class Printrequest
        {
            public string label { get; set; }
            public string key { get; set; }
            public string redi { get; set; }
            public string typeid { get; set; }
            public int mode { get; set; }
        }
    }
}
