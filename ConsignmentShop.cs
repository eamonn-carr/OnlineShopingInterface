using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();


        public ConsignmentShop()
        {
            InitializeComponent();
            setupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            Itemlistbox.DataSource = itemsBinding;

            Itemlistbox.DisplayMember = "Display";
            Itemlistbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

        }
        //create initial data
        private void setupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "John", LastName = "Smith", });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Smith", });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "Book About Whales",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Of mice and Men",
                Description = "Farmers",
                Price = 2.50M,
                Owner = store.Vendors[1]
            });

            store.Name = "The Bookies";
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            //Figure out what is selected
            //add to cart
            //do we remove fomr item list?, no

            Item selectedItem = (Item)Itemlistbox.SelectedItem;

            MessageBox.Show(selectedItem.Title);
            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);


        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //Marks Item as sold
            //Clear the Cart

            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
        }
    }
}
