using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Backend.Services
{
    public class Logic
    {
        private ObservableCollection<Message> Messages;
        public Logic()
        {

            Messages = new ObservableCollection<Message>();
            Messages.Add(new Message() { Name = "Janos", Content = "Szia", Date = DateTime.Now });
            Messages.Add(new Message() { Name = "Kati", Content = "Szia", Date = DateTime.Now });
            Messages.Add(new Message() { Name = "Janos", Content = "Hogy vagy?", Date = DateTime.Now });
            Messages.Add(new Message() { Name = "Kati", Content = "Jól és te", Date = DateTime.Now });
        }
        public IEnumerable<Message> GetAll() {
            return Messages;
        }
        public void Post(Message message) {
            Messages.Add(message);
        }
    }
}
