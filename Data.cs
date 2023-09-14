using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 寝室管理系统
{
    internal class Data
    {
        public static Data[] Datas
        {
            get;
            set;
        }

        public Data(string name) { Name = name; }
        public string Name { get; set; }

        public static void ReadData(string path)
        {
            string[] contents = File.ReadAllText(path, Encoding.UTF8).Split(new char[] { ' ' });
            Datas = new Data[contents.Length];
            for (int i = 0; i < contents.Length; i++)
            {
                Datas[i] = new Data(contents[i]);
            }

        }

    }
}
