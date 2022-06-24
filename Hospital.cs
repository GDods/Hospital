using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Hospital
    {

        public abstract class Pessoa : IPessoa
        {
            public string name { get; set; }
            public int age { get; set; }
            public string adr { get; set; }
            public string number { get; set; }

            public bool adm = false;
            public abstract string returnNumber(Pessoa pessoa);
        }

        public class Paciente : Pessoa
        {
            public Doutor doc { get; set; }

            public Paciente(string _name, int _age, Doutor _doutor)
            {
                name = _name;
                age = _age;
                doc = _doutor;
            }

            public override string returnNumber(Pessoa pessoa)
            {
                if (pessoa.name == this.name)
                {
                    return number;
                }
                else if (pessoa.name == doc.name)
                {
                    return number;
                }
                else if (pessoa.adm)
                {
                    return number;
                }
                else
                {
                    return "NOT OK";
                }
            }
        }

        public class Doutor : Pessoa
        {
            public enum Spec
            {
                general,
                cardio,
                ortho
            }
            public Spec spec { get; set; }
            public DateTime timeStart { get; set; }
            public DateTime timeEnd { get; set; }

            public Doutor(string _name, Spec _spec)
            {
                name = _name;
                spec = _spec;
            }

            public override string returnNumber(Pessoa pessoa)
            {
                if (pessoa.name == name)
                {
                    return number;
                }
                else if (pessoa.adm)
                {
                    return number;
                }
                else
                {
                    return "NOT OK";
                }
            }
        }
        public class Adimin : Pessoa
        {
            public Adimin(string _name)
            {
                name = _name;
                adm = true;
            }
            public override string returnNumber(Pessoa pessoa)
            {
                if (pessoa.adm)
                {
                    return number;
                }
                else
                {
                    return "NOT OK";
                }
            }
        }

    }
}
