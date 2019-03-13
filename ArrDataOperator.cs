using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
    class ArrDataOperator : DataOperator
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
                int[] ArrInt = DataGenerator.PopulateArray( size, MaxNumber, randomData);

                return true;
            }

            else if (tipo == "float")
            {
                float[] ArrFlt = DataGenerator.PopulateArray(size, maxNumber, randomData);

                return true;
            }

            else if (tipo == "itemslot")
            {
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

                return true;

            }
            else
            {
                return false;
            }
        }

        public bool SortDescending(string tipo)
        {
            tipo = tipo.ToLower();

            int size = 10;
            bool randomData = true;

            int MaxNumber = 100;
            float maxNumber = 100;


            if (tipo == "int")
            {
                int[] ArrInt = DataGenerator.PopulateArray(size, MaxNumber, randomData);

                int[] SortArrint = ArrInt.Reverse().ToArray();

                return true;
            }

            else if (tipo == "float")
            {
                float[] ArrFlt = DataGenerator.PopulateArray(size, maxNumber, randomData);

                float[] SortArrFlt = ArrFlt.Reverse().ToArray();

                return true;
            }

            else if (tipo == "itemslot")
            {
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

                ItemSlot[] SortItmFlt = ArrItm.Reverse().ToArray();
                return true;

            }
            else
            {
                return false;
            }
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
