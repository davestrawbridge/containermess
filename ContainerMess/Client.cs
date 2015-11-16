using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerMess {
    class Client {
         
        public void DoSomething<TContainer, TContent>(TContainer container, TContent content) 
            where TContainer : ItemContainer<TContent> 
            where TContent : Item {

            var location = container.Location;

            container.Remove(content);

            content.Location = location;
        }
    }
}
