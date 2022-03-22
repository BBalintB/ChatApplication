using Chat_Backend;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Chat_Client
{
    public class MainWindowViewModel : ObservableRecipient
    {
        
        public RestCollection<Message> Messages { get; set; }
        private Message msg;

        public Message MSG
        {
            get { return msg; }
            set 
            {
                if (value != null)
                {
                    msg = new Message()
                    {
                        Name = value.Name,
                        Content = value.Content,
                    };
                    OnPropertyChanged();
                    
                }
            }
        }


        public ICommand Send { get; set; }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {

                Messages = new RestCollection<Message>("http://localhost:24860/", "message", "hub");
                MSG = new Message();
                Send = new RelayCommand(() =>
                {
                    ;
                    Messages.Add(
                        new Message()
                        {

                            Name = MSG.Name,
                            Content = MSG.Content,
                            Date = DateTime.Now

                        }) ;
                });
            }
        }
    }
}
