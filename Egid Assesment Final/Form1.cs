using System.Diagnostics;

namespace Egid_Assesment_Final
{
    public partial class Form1 : Form
    {

        OrderSystem orderSystem = new OrderSystem();
        List<Item> selectedItems = new List<Item>();

        private readonly string[] items = new[] { "item1", "item2", "item3" };
        private readonly int[]prices = new[] {10, 20, 30};
        public Form1()
        {
            InitializeComponent();

            foreach (var item in items)
            {
                ItemListBox.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void  button1_Click(object sender, EventArgs e)
        {
            var selectedItems = ItemListBox.SelectedItems;
            foreach (var selectedItem in selectedItems) {

                //find the price of selected item
                var itemIndex = Array.IndexOf(items, selectedItem);
                var price = prices[itemIndex];

                //Add item and price to order listbox
                OrderListBox.Items.Add(selectedItem+ "($" + price + ")");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedOrders = OrderListBox.SelectedItems;


            OrderListBox.Items.Remove(OrderListBox.SelectedItem);
            
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {

      SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int i = 0; i<OrderListBox.Items.Count; i++)
                {
                    writer.WriteLine(OrderListBox.Items[i].ToString());
                }
                writer.Close();
            }
            dlg.Dispose();

        }
    }
    }
