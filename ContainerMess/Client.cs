using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerMess {
    class Client {

#if VERSION_1                 
        public void DoSomething<TContainer, TContent>(TContainer container, TContent content) 
            where TContainer : ItemContainer<TContent> 
            where TContent : Item {

            var location = container.Location;

            container.Remove(content);

            content.Location = location;
        }
#endif

        public void DoSomething<TContainer, TContent>(TContainer container, TContent content)
            where TContainer : Item
            where TContent : Item {

            var location = container.Location;


            var dynamicContainer = (dynamic)container;
            dynamicContainer.Remove(content);

            content.Location = location;
        }
    }
}
