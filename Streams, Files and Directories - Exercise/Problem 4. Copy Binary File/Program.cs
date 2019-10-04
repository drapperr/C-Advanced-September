using System;
using System.IO;

namespace Problem_4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream streamReader = new FileStream("copyMe.png", FileMode.Open))
            {
                using (FileStream streamWriter = new FileStream("copyMe-copy.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArr = new byte[4096];

                        int size = streamReader.Read(byteArr, 0, byteArr.Length);

                        if (size==0)
                        {
                            break;
                        }

                        streamWriter.Write(byteArr, 0, size);
                    }
                }
            }
        }
    }
}
