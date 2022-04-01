using System;
using System.Collections.Generic;
using LiteDB;

namespace WINFORM_PRAC.Repository
{
    public class ItemRepo : IItemRepo, IDisposable
    {
        private readonly LiteDatabase _database;
        private readonly ILiteCollection<Item> _collection;

        public ItemRepo(string name)
        {
            _database = new LiteDatabase(name);
            _collection = _database.GetCollection<Item>();

        }
        public Item Insert(string name, int price, bool isdel)
        {
            var item = new Item
            {
                Name = name,
                Price = price,
                IsDeleted = isdel,
            };
            _collection.Insert(item);
            return item;
        }
        public void Update(int id, string name, int price)
        {
            var doc = _collection.FindById(id);
            doc.Name = name;
            doc.Price = price;
            _collection.Update(doc);
        }

        public void Delete(int id)
        {
            var doc = _collection.FindById(id);
            doc.IsDeleted = true;
            _collection.Update(doc);
        }


        public IEnumerable<Item> List()
        {
            return _collection.FindAll();
        }






        public void Dispose()
        {
            ((IDisposable)_database).Dispose();
        }
    }


}
