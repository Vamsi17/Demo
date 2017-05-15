using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace AccessoriesStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accessoriesManagerDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.accessoriesManagerDataSet.Item);
            // TODO: This line of code loads data into the 'accessoriesManagerDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.accessoriesManagerDataSet.Category);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            var selectedCategory = category.SelectedText;
            var selectedCategoryValue = category.SelectedValue;
            var selectedModel = Model.Text;

            if (!string.IsNullOrWhiteSpace(selectedModel))
            {
                if (accessoriesManagerDataSet.Item.Any(x => x.ItemName.Contains(selectedModel)))
                {
                    var resultDic = new List<Dictionary<string, object>>();

                    var fullList = accessoriesManagerDataSet.Item.Where(x => x.CategoryId == Convert.ToInt32(selectedCategoryValue)
                                                           && x.ItemName.Contains(selectedModel)).ToList();

                    if (fullList.Count == 0)
                    {
                       MessageBox.Show("Out Of Stock !! Please Add Stock ");
                    }

                    resultTable.DataSource = GetList(fullList);
                }
                else
                {
                    MessageBox.Show("Sorry this model doesn't exist please try again with correct model");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid model name");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var curentIndex = e.RowIndex;
            var selectedRow = resultTable.Rows[curentIndex];
            var itemID = selectedRow.Cells[0].Value;
            var categoryId = selectedRow.Cells[1].Value;
            var itemName = selectedRow.Cells[2].Value;
            var quantity = selectedRow.Cells[3].Value;

            if(e.ColumnIndex == 4 && resultTable.Columns[4].HeaderText == "AddStock")
            {
                DialogResult dialogResult = MessageBox.Show("Sure you want to add ?", "This will add one count in your stock?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                  SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0LL260;Initial Catalog=AccessoriesManager;Integrated Security=True");
                  var selectedSet =  accessoriesManagerDataSet.Item.Where(x => x.CategoryId == Convert.ToInt32(categoryId) && x.ItemName == itemName).FirstOrDefault();
                  selectedSet.RemainingQuantity = selectedSet.RemainingQuantity + 1;
                  var command = "UPDATE Item SET RemainingQuantity = " + selectedSet.RemainingQuantity + " WHERE ItemID =" + itemID + "";
                  con.Open();
                  SqlCommand sqlCommand = new SqlCommand(command);
                  sqlCommand.Connection = con;
                  sqlCommand.ExecuteNonQuery();
                  con.Close();
                  
                  resultTable.Update();
                  resultTable.RefreshEdit();
                }
            }
            else if (e.ColumnIndex == 5 && resultTable.Columns[5].HeaderText == "SellStock")
            {
                DialogResult dialogResult = MessageBox.Show("Sure you want to sell ?", "This will reuce one count in your stock?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0LL260;Initial Catalog=AccessoriesManager;Integrated Security=True");
                    var selectedSet = accessoriesManagerDataSet.Item.Where(x => x.CategoryId == Convert.ToInt32(categoryId) && x.ItemName == itemName).FirstOrDefault();
                    selectedSet.RemainingQuantity = selectedSet.RemainingQuantity - 1;
                    var command = "UPDATE Item SET RemainingQuantity = " + selectedSet.RemainingQuantity + " WHERE ItemID =" + itemID + "";
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(command);
                    sqlCommand.Connection = con;
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    
                    resultTable.Update();
                    resultTable.RefreshEdit();
                }
            }
        }



        public class Item
        {
            public string ItemName { get; set; }
            public int RemainingQuantity { get; set; }
            public int ItemID { get; set; }
            public int CategoryId { get; set; }
            public Item(int ItemID, int CategoryId, string Item, int Quantity)
            {
                this.ItemName = Item;
                this.ItemID = ItemID;
                this.CategoryId = CategoryId;
                this.RemainingQuantity = Quantity;
            }
        }
        protected List<Item> GetList(IEnumerable<AccessoriesManagerDataSet.ItemRow> fullList)
        {
            List<Item> itemList = new List<Item>();
            foreach (var list in fullList)
            {
                Item a = new Item(list.ItemID, list.CategoryId,list.ItemName, list.RemainingQuantity);
                itemList.Add(a);
            }

            return itemList;
        }
    }
}
