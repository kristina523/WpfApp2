using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

namespace ABBA
{

    public partial class Purchases : Page
    {
        private WILDBEREntities context = new WILDBEREntities();
        public Purchases()
        {
            InitializeComponent();
            PurchasesDateGrid.ItemsSource = context.Purchases.ToList();
        }
    }
}