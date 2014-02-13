using MyGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyGame.Data.Repositories
{
    internal class ItemRepository : BaseRepository, IExtendedRepository<Item>
    {
        private readonly List<Item> _items;

        public ItemRepository(IContext context)
            : base(context)
        {
            _items = context.Engine.Items;
        }

        public Item Get()
        {
            return _items.FirstOrDefault();
        }

        public Item Get(string id)
        {
            return _items.Single(item => item.Id == id);
        }

        public IEnumerable<Item> GetAll()
        {
            return _items;
        }

        public void Update(Item entity)
        {
            var itemToUpdate = _items.Single(item => item.Id == entity.Id);

            itemToUpdate.Id = entity.Id;
            itemToUpdate.IconId = entity.IconId;
            itemToUpdate.Description = entity.Description;
            itemToUpdate.ElementTemplate = entity.ElementTemplate;
        }

        public void Append(Item entity)
        {
            if (_items.All(item => item.Id != entity.Id))
            {
                _items.Add(entity);
            }

            throw new InvalidOperationException("Duplicate Item Id");
        }

        public void Remove(Item entity)
        {
            var itemToRemove = _items.Single(item => item.Id == entity.Id);
            
            _items.Remove(itemToRemove);
        }
    }
}