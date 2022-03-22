using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Backend.Services
{
    public class Logic
    {
        private List<Message> Messages;
        public Logic()
        {
            Messages = new List<Message>();
        }
        public IEnumerable<Message> GetAll() {
            return Messages;
        }
        public void Post(Message message) {
            Messages.Add(message);
        }
    }
}
