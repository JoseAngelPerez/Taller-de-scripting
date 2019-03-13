using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
    class QueueDataOperator : DataOperator
    {
        public bool SortAscending(string tipo)
        {
            tipo = tipo.ToLower();

            int size = 10;
            bool randomData = true;

            int MaxNumber = 100;
            float maxNumber = 100;


            if (tipo == "int")
            {
                Queue<int> QueueInt = DataGenerator.PopulateQueue(size, MaxNumber, randomData);

                return true;
            }

            else if (tipo == "float")
            {
                Queue<float> QueueFlt = DataGenerator.PopulateQueue(size, maxNumber, randomData);

                

                return true;
            }

            else if (tipo == "itemslot")
            {
                Queue<ItemSlot> QueueItm = DataGenerator.PopulateQueue(size);

                ItemSlot[] ItmArr = new ItemSlot[QueueItm.Count];

                for(int i =0; i<ItmArr.Length;i++)
                {
                    ItmArr[i] = QueueItm.Dequeue();
                }
                
                ItemSlot[] ArrItm = DataGenerator.PopulateArray(size);

                for (int j = 0; j < (ArrItm.Length - 1); j++)
                {
                    for (int k = 0; k < ArrItm.Length - j; k++)
                    {
                        if (ArrItm[k].Id > ArrItm[k + 1].Id)
                        {
                            int ArrItmI;
                            ArrItmI = ArrItm[k].Id;
                            ArrItm[k].Id = ArrItm[k + 1].Id;
                            ArrItm[k + 1].Id = ArrItmI;
                        }
                    }
                }

                for (int i = 0; i < size; i++)
                {
                    QueueItm.Enqueue(ItmArr[i]);
                }

                return true;

            }
            else
            {
                return false;
            }
        }

        public bool SortDescending(string tipo)
        {
            return true;
        }

        public bool Shuffle(string tipo)
        {
            return true;
        }

        public bool PerfectShuffle(string tipo)
        {
            return true;
        }

        public bool RemoveOdds(string tipo)
        {
            return true;
        }

        public bool PemoveEven(string tipo)
        {
            return true;
        }
    }
}
