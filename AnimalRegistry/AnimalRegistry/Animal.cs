using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalRegistry
{
    class AnimalType

         {
            string animal;
            public string Animal { get => animal; set => animal = value; }
            string kingdom;
            public string Kingdom { get => kingdom; set => kingdom = value; }
            string picpath;
            public string Picpath { get => picpath; set => picpath = value; }
            int cae;
            public int Cae { get => cae; set => cae = value; }
            private string aclass;
            public string Aclass { get => aclass; set => aclass = value; }
            private string pop;
            public string Population { get => pop; set => pop = value; }
            private string cse;
            public string Cs { get => cse; set => cse = value; }
            string[] fty = new string[3];
            public string[] Fty { get => fty; set => fty = value; }

            public AnimalType()
            {

            }

            public AnimalType (string a, string k, string pic, int c, string ac, string po, string cs, string[] ft)
            {
                animal = a;
                kingdom = k;
                picpath = pic;
                cae = c;
                aclass = ac;
                pop = po;
                cse = cs;
                fty = ft;


            }

            public void saveData()
            {
                using (StreamWriter sw = File.AppendText("AnimalData.csv"))
                {
                    string eachItem = "";
                    foreach (var item in fty)
                    {
                        eachItem += "-" + eachItem;
                    }
                    sw.WriteLine(animal + "," + kingdom + "," + picpath + "," + cae + "," + aclass + "," + pop + "," + cse + "," + eachItem);
                }
            }





        }
    }

