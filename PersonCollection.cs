using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_1v
{
    internal class PersonCollection
    {
        private List<Pers> lst = new List<Pers>();
        public PersonCollection()
        {
            FileStream fin = new FileStream("G:\\data.txt", FileMode.Open);
            StreamReader rdr = new StreamReader(fin, Encoding.UTF8);
            string line;
            string[] split;
            while ((line = rdr.ReadLine()) != null)
            {
                //создание и добавление объектов 
                split = line.Split('+');
                Pers obj = new Pers(Int32.Parse(split[0]), Int32.Parse(split[1]), Int32.Parse(split[2]), split[3],
                                        Int32.Parse(split[4]), Int32.Parse(split[5]), Int32.Parse(split[6]));
                lst.Add(obj);
            }
        }
    }
}
