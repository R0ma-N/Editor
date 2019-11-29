using System.Collections.Generic;

namespace Geekbrains
{
    public sealed class TestExtension
    {
        private void NameMethod()
        {
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            
            
            list.Add(5);
            5.AddList(list).AddList(list2);
        }
    }
}
