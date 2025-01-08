using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static exam.Event;

namespace exam //https://github.com/DavydSafonov/exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Event> Music = new List<Event>();
        static List<Event> Comedy = new List<Event>();
        static List<Event> Theatre = new List<Event>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Event> events = new List<Event>
            {
                new Event
                {
                    Name = "Oasis Croke Park",
                    EventDate = new DateTime(2025, 06, 20),
                    TypeOfEvent = EventType.Music,

                },
                new Event
                {
                    Name = "Electronic Picnic",
                    EventDate = new DateTime(2025, 08, 20),
                    TypeOfEvent = EventType.Music,
                },
            };

            List<Ticket> tickets = new List<Ticket>
            {
                new Ticket
                {
                    Name ="Early Bird",
                    Price = 100,
                    AvailableTickets = 100
                },
                new Ticket
                {
                    Name = "Platinum",
                    Price = 150,
                    AvailableTickets = 100
                }               
            };


            List<VIPticket> vipTickets = new List<VIPticket>
            {
                new VIPticket
                {
                    Name = "Ticket and Hotel Package",
                    Price = 150m,
                    AdditionalCost = 100m,
                    AdditionalExtras = "4* hotel",
                    AvailableTickets = 100  
                },
                new VIPticket
                {
                     Name = "Weekend Ticket",
                     Price = 200m,
                     AdditionalCost = 100m,
                     AdditionalExtras = "with camping",
                     AvailableTickets = 100
                },
            };

        }
    }
}