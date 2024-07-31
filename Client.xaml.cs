using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyYardPartner
{
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : Page
    {

        public Client()
        {
            InitializeComponent();
        }

        public string cname = "";
        public string ccontactno = "";
        public string caddress = "";
        public struct client
        {
            public string cname;
            public string ccontactno;
            public string caddress;
        }

        

        public client c = new client();

        private void AddClient(object sender, RoutedEventArgs e)
        {
            if (! (string.IsNullOrWhiteSpace(clientname.Text) && string.IsNullOrWhiteSpace(clientcontactno.Text) && string.IsNullOrWhiteSpace(clientaddress.Text)))
            {
                c.cname = clientname.Name;
                c.ccontactno = clientcontactno.Text;
                c.caddress = clientaddress.Text;

                new DataControlFlow().c1.Add(c);

                Console.WriteLine(new DataControlFlow().c1);

                NavigationService.Navigate(new DataControlFlow());

                MessageBox.Show("Client added successfully");
            }
            else
            {
                MessageBox.Show("All fields are mandatary as not null");
            }
        }
    }
}
