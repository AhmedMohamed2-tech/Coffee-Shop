using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeForm : Form
    {
        public List<Coffee> Coffees = new List<Coffee>();
        private void RefreshDataGrid()
        {
            textBoxName.Clear();
            txtPrice.Clear();
            txtOrderQty.Clear();
            comboBoxBeanType.SelectedIndex=-1;
            comboBoxRoastLevel.SelectedIndex=-1;
            comboCoffeeType.SelectedIndex=-1;
            comboCupSize.SelectedIndex=-1;
            comboSugarQty.SelectedIndex=-1;
            comboSugarType.SelectedIndex=-1;

            // Reset the data source to force the DataGridView to refresh
            dataGridViewCoffees.DataSource = null;
            dataGridViewCoffees.DataSource = Coffees;
        }
        private void SetupDataGridView()
        {
            dataGridViewCoffees.AutoGenerateColumns = false;

            dataGridViewCoffees.Columns.Clear();
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Customer Name", DataPropertyName = "CusName" });
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Order Quantity", DataPropertyName = "Qty" });
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cup Size", DataPropertyName = "CupSize" });
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Coffee Type", DataPropertyName = "CoffeeType" });
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bean Type", DataPropertyName = "BeanType" });
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Roast ", DataPropertyName = "RoastLevel" });
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sugar Type", DataPropertyName = "SugarType" });
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sugar Quantity", DataPropertyName = "SugarLvl" });
            dataGridViewCoffees.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "Price" });
        }
        public CoffeeForm()
        {
            InitializeComponent();


        }
        private void CoffeeForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();

            Coffees.Add(new Coffee() { CusName = "Mohamed", Price = 2.50m, BeanType = BeanType.Arabica, RoastLevel = RoastLevel.Dark, CoffeeType=CoffeeType.Cappuccino,SugarType=SugarType.Caster,SugarLvl = SugarLvl.two,Qty=1,CupSize=CupSize.X_large });
            Coffees.Add(new Coffee() { CusName = "Aisha", Price = 15.00m, BeanType = BeanType.Robusta, RoastLevel = RoastLevel.Medium, CoffeeType = CoffeeType.Macchiato, SugarType = SugarType.Brown, SugarLvl = SugarLvl.one, Qty = 3, CupSize = CupSize.Medium });
            Coffees.Add(new Coffee() { CusName = "Jamiee", Price = 7.00m, BeanType = BeanType.Liberica, RoastLevel = RoastLevel.Light, CoffeeType = CoffeeType.Frappuccino, SugarType = SugarType.Confectioners, SugarLvl = SugarLvl.three, Qty = 2, CupSize=CupSize.large });
            Coffees.Add(new Coffee() { CusName = "Jasmine", Price = 25.00m, BeanType = BeanType.Excelsa, RoastLevel = RoastLevel.Light, CoffeeType = CoffeeType.Americano, SugarType = SugarType.White, SugarLvl = SugarLvl.four, Qty = 5, CupSize=CupSize.Small });
            Coffees.Add(new Coffee() { CusName = "Ahmed", Price = 45.75m, BeanType = BeanType.Arabica, RoastLevel = RoastLevel.Dark, CoffeeType = CoffeeType.Latte, SugarType = SugarType.Caster, SugarLvl = SugarLvl.one, Qty = 6, CupSize=CupSize.large });
            dataGridViewCoffees.DataSource = Coffees;
            comboBoxBeanType.DataSource = Enum.GetValues(typeof(BeanType));
            comboBoxRoastLevel.DataSource = Enum.GetValues(typeof(RoastLevel));
            comboSugarType.DataSource = Enum.GetValues(typeof(SugarType));
            comboCoffeeType.DataSource = Enum.GetValues(typeof(CoffeeType));
            comboCupSize.DataSource = Enum.GetValues(typeof(CupSize));
            comboSugarQty.DataSource = Enum.GetValues(typeof(SugarLvl));
            grpOrder.Visible= false;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            grpOrder.Visible = true;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewCoffees.SelectedRows.Count > 0)
            {
                Coffees.RemoveAt(dataGridViewCoffees.CurrentRow.Index);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a coffee to delete.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            grpOrder.Visible = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            string name = textBoxName.Text;
            int qty = int.Parse(txtOrderQty.Text);
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                BeanType beanType = (BeanType)comboBoxBeanType.SelectedItem;
                RoastLevel roastLevel = (RoastLevel)comboBoxRoastLevel.SelectedItem;
                CoffeeType coffeeType = (CoffeeType)comboBoxBeanType.SelectedItem;
                SugarType sugarType = (SugarType)comboBoxBeanType.SelectedItem;
                SugarLvl sugarLvl = (SugarLvl)comboBoxBeanType.SelectedItem;
                CupSize cupSize =  (CupSize)comboBoxBeanType.SelectedItem;


                Coffee coffee = (new Coffee()
                {
                    CusName = name,
                    Qty = qty,
                    CupSize = cupSize,
                    CoffeeType = coffeeType,
                    BeanType = beanType,
                    RoastLevel = roastLevel,
                    SugarType = sugarType,
                    SugarLvl = sugarLvl,
                    Price = price 
                });

                Coffees.Add(coffee);
                MessageBox.Show("Record Added!");
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }
    }
}
