using System.Collections.Generic;

namespace WINFORM_PRAC.Repository
{
    public interface IItemRepo
    {
        void Delete(int id);

        Item Insert(string name, int price, bool isdel);

        void Update(int id, string name, int price);

        IEnumerable<Item> List();

    }
}
