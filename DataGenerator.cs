using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
    static class DataGenerator
    {


        public static int[] PopulateArray(int size, int maxNumber, bool randomData = false)
        {
            int[] ArrInt = new int[size];


            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                ArrInt[i] = random.Next(0, maxNumber + 1);
            }

            if (randomData)
            {
                for (int j = 0; j < (ArrInt.Length - 1); j++)
                {
                    for (int k = 0; k < ArrInt.Length - j; k++)
                    {
                        if (ArrInt[k] > ArrInt[k + 1])
                        {
                            int ArrIntI;
                            ArrIntI = ArrInt[k];
                            ArrInt[k] = ArrInt[k + 1];
                            ArrInt[k + 1] = ArrIntI;
                        }
                    }
                }

                return ArrInt;

            }

            else
            {
                return ArrInt;
            }
        }

        public static float[] PopulateArray(int size, float maxNumber, bool randomData = false)
        {
            float[] ArrFlt = new float[size];

            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                ArrFlt[i] = ((float)random.NextDouble()) * maxNumber;
            }


            if (randomData)
            {
                for (int j = 0; j < (ArrFlt.Length - 1); j++)
                {
                    for (int k = 0; k < ArrFlt.Length - j; k++)
                    {
                        if (ArrFlt[k] > ArrFlt[k + 1])
                        {
                            float ArrFltI;
                            ArrFltI = ArrFlt[k];
                            ArrFlt[k] = ArrFlt[k + 1];
                            ArrFlt[k + 1] = ArrFltI;
                        }
                    }
                }

                return ArrFlt;

            }

            else
            {
                return ArrFlt;
            }
        }

        public static ItemSlot[] PopulateArray(int size)
        {
            ItemSlot[] ArrItm = new ItemSlot[10];
            
            ArrItm[1] = new ItemSlot(0,"a", 1, "x");
            ArrItm[2] = new ItemSlot(0,"b", 2, "xx");
            ArrItm[3] = new ItemSlot(0,"c", 3, "xxx");
            ArrItm[4] = new ItemSlot(0,"d", 4, "xxxx");
            ArrItm[5] = new ItemSlot(0,"e", 5, "xxxxx");
            ArrItm[6] = new ItemSlot(0,"a", 1, "xxxxxx");
            ArrItm[7] = new ItemSlot(0,"b", 2, "xxxxxxx");
            ArrItm[8] = new ItemSlot(0,"c", 3, "xxxxxxxx");
            ArrItm[9] = new ItemSlot(0,"d", 4, "xxxxxxxxx");
            ArrItm[10] = new ItemSlot(0,"e", 5, "xxxxxxxxxx");

            if(size<=10)
                {
                ItemSlot[] ItmArr = new ItemSlot[size];


                for (int i = 0; i < size; i++)
                {
                    Random random = new Random();

                    ItmArr[i] = ArrItm[random.Next(0, size + 1)];
                }
                return ItmArr;

            }
            else
            {
                return null;
            }
            
        }

        public static List<int> PopulateList(int size, int maxNumber, bool randomData = false)
        {

            List<int> IntList = new List<int>();

            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                IntList.Add(random.Next(0, maxNumber + 1));
            }

            if (randomData)
            {
                for (int j = 0; j < (IntList.Count - 1); j++)
                {
                    for (int k = 0; k < IntList.Count - j; k++)
                    {
                        if (IntList[k] > IntList[k + 1])
                        {
                            int IntListI;
                            IntListI = IntList[k];
                            IntList[k] = IntList[k + 1];
                            IntList[k + 1] = IntListI;
                        }
                    }
                }

                return IntList;
            }

            else
            {
                return IntList;
            }

        }

        public static List<float> PopulateList(int size, float maxNumber, bool randomData = false)
        {
            
            List<float> FltList = new List<float>();

            for (int i = 0; i < size; i++)
            {
                Random random = new Random();
              
                
                FltList.Add(((float)random.NextDouble()) * maxNumber);
            }

            if (randomData)
            {
                for (int j = 0; j < (FltList.Count - 1); j++)
                {
                    for (int k = 0; k < FltList.Count - j; k++)
                    {
                        if (FltList[k] > FltList[k + 1])
                        {
                            float FltListI;
                            FltListI = FltList[k];
                            FltList[k] = FltList[k + 1];
                            FltList[k + 1] = FltListI;
                        }
                    }
                }

                return FltList;
            }

            else
            {
                return FltList;
            }
        }

        public static List<ItemSlot> PopulateList(int size)
        {
            ItemSlot[] ArrItm = new ItemSlot[10];

            ArrItm[1] = new ItemSlot(0, "a", 1, "x");
            ArrItm[2] = new ItemSlot(0, "b", 2, "xx");
            ArrItm[3] = new ItemSlot(0, "c", 3, "xxx");
            ArrItm[4] = new ItemSlot(0, "d", 4, "xxxx");
            ArrItm[5] = new ItemSlot(0, "e", 5, "xxxxx");
            ArrItm[6] = new ItemSlot(0, "a", 1, "xxxxxx");
            ArrItm[7] = new ItemSlot(0, "b", 2, "xxxxxxx");
            ArrItm[8] = new ItemSlot(0, "c", 3, "xxxxxxxx");
            ArrItm[9] = new ItemSlot(0, "d", 4, "xxxxxxxxx");
            ArrItm[10] = new ItemSlot(0, "e", 5, "xxxxxxxxxx");

            if (size <= 10)
            {
                ItemSlot[] ItmArr = new ItemSlot[size];


                for (int i = 0; i < size; i++)
                {
                    Random random = new Random();

                    ItmArr[i] = ArrItm[random.Next(0, size + 1)];
                }


                List<ItemSlot> ItmList = new List<ItemSlot>();

                for (int i = 0; i < size; i++)
                {
                    ItmList.Add(ItmArr[i]);
                }

                return  ItmList;

            }
            else
            {
                return null;
            }
        }

        public static Queue<int> PopulateQueue(int size, int maxNumber, bool randomData = false)
        {
            int[] ArrInt = new int[size];


            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                ArrInt[i] = random.Next(0, maxNumber + 1);
            }

            if (randomData)
            {
                for (int j = 0; j < (ArrInt.Length - 1); j++)
                {
                    for (int k = 0; k < ArrInt.Length - j; k++)
                    {
                        if (ArrInt[k] > ArrInt[k + 1])
                        {
                            int ArrIntI;
                            ArrIntI = ArrInt[k];
                            ArrInt[k] = ArrInt[k + 1];
                            ArrInt[k + 1] = ArrIntI;
                        }
                    }
                }
            }
            Queue<int> QueueInt = new Queue<int>();

            for (int i = 0; i < size; i++)
            {
               

                QueueInt.Enqueue(ArrInt[i]);
            }

            return QueueInt;
        }

        public static Queue<float> PopulateQueue(int size, float maxNumber, bool randomData = false)
        {
            float[] ArrFlt = new float[size];

            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                ArrFlt[i] = ((float)random.NextDouble()) * maxNumber;
            }


            if (randomData)
            {
                for (int j = 0; j < (ArrFlt.Length - 1); j++)
                {
                    for (int k = 0; k < ArrFlt.Length - j; k++)
                    {
                        if (ArrFlt[k] > ArrFlt[k + 1])
                        {
                            float ArrFltI;
                            ArrFltI = ArrFlt[k];
                            ArrFlt[k] = ArrFlt[k + 1];
                            ArrFlt[k + 1] = ArrFltI;
                        }
                    }
                }
            }


            Queue<float> QueueFlt = new Queue<float>();

            for (int i = 0; i < size; i++)
            {


                QueueFlt.Enqueue(ArrFlt[i]);
            }

            return QueueFlt;

        }

        public static Queue<ItemSlot> PopulateQueue(int size)
        {

            ItemSlot[] ArrItm = new ItemSlot[10];

            ArrItm[1] = new ItemSlot(0, "a", 1, "x");
            ArrItm[2] = new ItemSlot(0, "b", 2, "xx");
            ArrItm[3] = new ItemSlot(0, "c", 3, "xxx");
            ArrItm[4] = new ItemSlot(0, "d", 4, "xxxx");
            ArrItm[5] = new ItemSlot(0, "e", 5, "xxxxx");
            ArrItm[6] = new ItemSlot(0, "a", 1, "xxxxxx");
            ArrItm[7] = new ItemSlot(0, "b", 2, "xxxxxxx");
            ArrItm[8] = new ItemSlot(0, "c", 3, "xxxxxxxx");
            ArrItm[9] = new ItemSlot(0, "d", 4, "xxxxxxxxx");
            ArrItm[10] = new ItemSlot(0, "e", 5, "xxxxxxxxxx");

            if (size <= 10)
            {
                ItemSlot[] ItmArr = new ItemSlot[size];


                for (int i = 0; i < size; i++)
                {
                    Random random = new Random();

                    ItmArr[i] = ArrItm[random.Next(0, size + 1)];
                }


                Queue<ItemSlot> QueueItm = new Queue<ItemSlot>();

                for (int i = 0; i < size; i++)
                {
                    QueueItm.Enqueue(ItmArr[i]);
                }

                return QueueItm;

            }
            else
            {
                return null;
            }
        }

        public static Stack<int> PopulateStack(int size, int maxNumber, bool randomData = false)
        {
            int[] ArrInt = new int[size];


            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                ArrInt[i] = random.Next(0, maxNumber + 1);
            }

            if (randomData)
            {
                for (int j = 0; j < (ArrInt.Length - 1); j++)
                {
                    for (int k = 0; k < ArrInt.Length - j; k++)
                    {
                        if (ArrInt[k] > ArrInt[k + 1])
                        {
                            int ArrIntI;
                            ArrIntI = ArrInt[k];
                            ArrInt[k] = ArrInt[k + 1];
                            ArrInt[k + 1] = ArrIntI;
                        }
                    }
                }
            }
            Stack<int> StackInt = new Stack<int>();

            for (int i = 0; i < size; i++)
            {


                StackInt.Push(ArrInt[i]);
            }

            return StackInt;
        }

        public static Stack<float> PopulateStack(int size, float maxNumber, bool randomData = false)
        {
            float[] ArrFlt = new float[size];

            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                ArrFlt[i] = ((float)random.NextDouble()) * maxNumber;
            }


            if (randomData)
            {
                for (int j = 0; j < (ArrFlt.Length - 1); j++)
                {
                    for (int k = 0; k < ArrFlt.Length - j; k++)
                    {
                        if (ArrFlt[k] > ArrFlt[k + 1])
                        {
                            float ArrFltI;
                            ArrFltI = ArrFlt[k];
                            ArrFlt[k] = ArrFlt[k + 1];
                            ArrFlt[k + 1] = ArrFltI;
                        }
                    }
                }
            }


            Stack<float> StackFlt = new Stack<float>();

            for (int i = 0; i < size; i++)
            {


                StackFlt.Push(ArrFlt[i]);
            }

            return StackFlt;
        }

        public static Stack<ItemSlot> PopulateStack(int size)
        {

            ItemSlot[] ArrItm = new ItemSlot[10];

            ArrItm[1] = new ItemSlot(0, "a", 1, "x");
            ArrItm[2] = new ItemSlot(0, "b", 2, "xx");
            ArrItm[3] = new ItemSlot(0, "c", 3, "xxx");
            ArrItm[4] = new ItemSlot(0, "d", 4, "xxxx");
            ArrItm[5] = new ItemSlot(0, "e", 5, "xxxxx");
            ArrItm[6] = new ItemSlot(0, "a", 1, "xxxxxx");
            ArrItm[7] = new ItemSlot(0, "b", 2, "xxxxxxx");
            ArrItm[8] = new ItemSlot(0, "c", 3, "xxxxxxxx");
            ArrItm[9] = new ItemSlot(0, "d", 4, "xxxxxxxxx");
            ArrItm[10] = new ItemSlot(0, "e", 5, "xxxxxxxxxx");

            if (size <= 10)
            {
                ItemSlot[] ItmArr = new ItemSlot[size];


                for (int i = 0; i < size; i++)
                {
                    Random random = new Random();

                    ItmArr[i] = ArrItm[random.Next(0, size + 1)];
                }


                Stack<ItemSlot> StackItm = new Stack<ItemSlot>();

                for (int i = 0; i < size; i++)
                {
                    StackItm.Push(ItmArr[i]);
                }

                return StackItm;
            }
            else
            {
                return null;
            }
        }

        public static Dictionary<string, int> PopulateDict(int size, int maxNumber, bool randomData = false)
        {
            int[] ArrInt = new int[size];


            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                ArrInt[i] = random.Next(0, maxNumber + 1);
            }

            if (randomData)
            {
                for (int j = 0; j < (ArrInt.Length - 1); j++)
                {
                    for (int k = 0; k < ArrInt.Length - j; k++)
                    {
                        if (ArrInt[k] > ArrInt[k + 1])
                        {
                            int ArrIntI;
                            ArrIntI = ArrInt[k];
                            ArrInt[k] = ArrInt[k + 1];
                            ArrInt[k + 1] = ArrIntI;
                        }
                    }
                }
            }

            Dictionary<string, int> DictInt = new Dictionary<string, int>();
            
            for (int i = 0; i < size; i++)
            {
                
              DictInt.Add( ArrInt[i].ToString(), ArrInt[i]);
              
            }

            return DictInt;
        }

        public static Dictionary<string, float> PopulateDict(int size, float maxNumber, bool randomData = false)
        {
            float[] ArrFlt = new float[size];

            for (int i = 0; i < size; i++)
            {
                Random random = new Random();

                ArrFlt[i] = ((float)random.NextDouble()) * maxNumber;
            }


            if (randomData)
            {
                for (int j = 0; j < (ArrFlt.Length - 1); j++)
                {
                    for (int k = 0; k < ArrFlt.Length - j; k++)
                    {
                        if (ArrFlt[k] > ArrFlt[k + 1])
                        {
                            float ArrFltI;
                            ArrFltI = ArrFlt[k];
                            ArrFlt[k] = ArrFlt[k + 1];
                            ArrFlt[k + 1] = ArrFltI;
                        }
                    }
                }
            }

            Dictionary<string, float> DictFlt = new Dictionary<string, float>();

            for (int i = 0; i < size; i++)
            {

                DictFlt.Add(ArrFlt[i].ToString(), ArrFlt[i]);

            }

            return DictFlt;


        }

        public static Dictionary<string, ItemSlot> PopulateDict(int size)
        {
            ItemSlot[] ArrItm = new ItemSlot[10];

            ArrItm[1] = new ItemSlot(0, "a", 1, "x");
            ArrItm[2] = new ItemSlot(0, "b", 2, "xx");
            ArrItm[3] = new ItemSlot(0, "c", 3, "xxx");
            ArrItm[4] = new ItemSlot(0, "d", 4, "xxxx");
            ArrItm[5] = new ItemSlot(0, "e", 5, "xxxxx");
            ArrItm[6] = new ItemSlot(0, "a", 1, "xxxxxx");
            ArrItm[7] = new ItemSlot(0, "b", 2, "xxxxxxx");
            ArrItm[8] = new ItemSlot(0, "c", 3, "xxxxxxxx");
            ArrItm[9] = new ItemSlot(0, "d", 4, "xxxxxxxxx");
            ArrItm[10] = new ItemSlot(0, "e", 5, "xxxxxxxxxx");

            if (size <= 10)
            {
                ItemSlot[] ItmArr = new ItemSlot[size];


                for (int i = 0; i < size; i++)
                {
                    Random random = new Random();

                    ItmArr[i] = ArrItm[random.Next(0, size + 1)];
                }

                Dictionary<string, ItemSlot> DictItm = new Dictionary<string, ItemSlot>();

                for (int i = 0; i < size; i++)
                {

                    DictItm.Add(ItmArr.ToString(), ItmArr[i]);

                }

                return DictItm;

               

            }
            else
            {
                return null;
            }
        }

    }
}
