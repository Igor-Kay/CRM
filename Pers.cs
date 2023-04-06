using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_1v
{
    class Pers
    {
        private int _id;
        private int _filialId;
        private int _subdivId;
        private string _surname;
        private int _age;
        private int _salary;
        private int _isStage;
        public Pers(int id, int filialId, int subdivId, string surname, int age, int salary, int isStage)
        {
            this._id = id;
            this._filialId = filialId;
            this._subdivId = subdivId;
            this._surname = surname;
            this._age = age;
            this._salary = salary;
            this._isStage = isStage;
        }
        public string surname { get { return _surname; } set { _surname = value; } }
        public int id { get { return _id; } set { _id = value; } }
        public int filialId { get { return _filialId; } set { _filialId = value; } }

        public int subdivId { get { return _subdivId; } set { _subdivId = value; } }

        public int age { get { return _age; } set { _age = value; } }

        public int salary { get { return _salary; } set { _salary = value; } }

        public int isStage { get { return _isStage; } set { _isStage = value; } }
    }
}
