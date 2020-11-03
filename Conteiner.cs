using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    public class Gym //контейнер
    {

        public List<tennis> data = new List<tennis>();

        public static int counter = 0;

        public void Output()
        {
            if (counter == 0)
            {
                ExccessLaboratoryEmpty err = new ExccessLaboratoryEmpty("ERROR!!!\n Laboratory is empty");
                throw err;
            }
            else
            {
                foreach (object i in data)
                {
                    Console.WriteLine($"Object {i}");
                }
            }
        }

        public void Remove(tennis A)
        {
            data.Remove(A);
        }

        public void ClearLaboratory()
        {
            if (counter == 0)
            {
                ExccessLaboratoryEmpty err = new ExccessLaboratoryEmpty("ERROR!!!\n Laboratory is empty");
                throw err;
            }
            else
            {
                counter = 0;
                data.Clear();
                Console.WriteLine("Empty!");

            }
        }

        public void Push(tennis N)
        {
            data.Add(N);
            counter++;
        }
    }
}
