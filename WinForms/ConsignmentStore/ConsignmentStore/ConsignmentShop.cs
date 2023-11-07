using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ConsignmentShopLibrary;

namespace ConsignmentStore
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        private decimal storeProfit = 0;


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingListBox.DataSource = cartBinding;

            shoppingListBox.DisplayMember = "Display";
            shoppingListBox.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            vendorListbox.DataSource = vendorBinding;

            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";

        }

        private void SetupData()
        {

            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "John", LastName = "Whick", Comission = .3 });
            store.Vendors.Add(new Vendor { FirstName = "Elon", LastName = "Musk", Comission = .1 });


            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Dracula",
                Description = "A book about a vampires",
                Price = 5.00M,
                Owner = store.Vendors[2]
            });

            store.Items.Add(new Item
            {
                Title = "T-Rex",
                Description = "A book about a dinosaurs",
                Price = 5.00M,
                Owner = store.Vendors[1]
            });


            store.Items.Add(new Item
            {
                Title = "Lord of The Rings",
                Description = "A book about magic and monsters",
                Price = 15.24M,
                Owner = store.Vendors[0]
            });


            store.Items.Add(new Item
            {
                Title = "Narnia",
                Description = "A book about magic",
                Price = 23.00M,
                Owner = store.Vendors[2]
            });


            store.Name = "Semanticus";

        }



        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            foreach (Item Book in shoppingCartData)
            {
                Book.Sold = true;
                Book.Owner.PaymentDue += (decimal)Book.Owner.Comission * Book.Price;
                storeProfit += (1 - (decimal)Book.Owner.Comission) * Book.Price;

            }

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            shoppingCartData.Clear();

            Earnings.Text = string.Format("{0}", storeProfit.ToString("c"));

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);

            foreach (Item i in store.Items)
            {
                if (i.Sold)
                {
                    Console.WriteLine(i.Title + " already sold by "+i.Owner.FirstName);
                }
            }

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked Cart");
            Item selectedItem = (Item)itemsListBox.SelectedItem; //Get current target

            foreach (Item Book in shoppingCartData)
            {
                if (Book == selectedItem)
                {
                    MessageBox.Show("You already have " + Book.Title);//Check if we already have it
                    return;
                }
            }
            
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);

        }



    }
}
