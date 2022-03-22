using Chat_Backend;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chat_Client
{
    public class MainWindowViewModel : ObservableRecipient
    {
        
        public RestCollection<Message> Messages { get; set; }
        
        public ICommand Send { get; set; }

        

    }
}
