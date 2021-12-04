using System;
using System.Collections.Generic;

namespace Common
{
    public class LogService
    {
        public static void SaveToFile(List<ILog> ChangedElements)
        {
            foreach (var item in ChangedElements)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
