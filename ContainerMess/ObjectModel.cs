using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerMess {
    class Item {

        public string Location { get; set; }

        public Item Parent { get; set; }
    }

    class ItemContainer<TContent> : Item where TContent : Item {

        public IEnumerable<TContent> Contents { get; set; }

        public void Remove(Item item) {
            if (_contents.Contains(item) && item is TContent)
                _contents.Remove(item as TContent);
        }

        protected IList<TContent> _contents = new List<TContent>();
    }

    class ContentBase : Item {

    }

    class ContentA : ContentBase { }

    class ContentB : ContentBase { }

     
    class MyContainer : ItemContainer<ContentBase> {
        public void Add(ContentBase content) {
            _contents.Add(content);
        }
    }


}
