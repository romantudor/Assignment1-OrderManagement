using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Operations;
using Models;
namespace OrderManagement
{
    public partial class regular : Form
    {
        public regular()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            Product prod = new Product();
            prod = retrieve();
            po.addProduct(prod);

        }

        public Product retrieve()
        {
            Product prod = new Product();
            prod.idproduct = Convert.ToInt32(idTxt.Text);
            prod.title = titleTxt.Text;
            prod.description = descTxt.Text;
            prod.color = colorTxt.Text;
            prod.size = Convert.ToInt32(sizeTxt.Text);
            prod.price = (float)Convert.ToDouble(priceTxt.Text);
            prod.stock = Convert.ToInt32(stockTxt.Text);
            return prod;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            dataGridView1.DataSource = po.view();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            Product prod = new Product();
            prod = retrieve();
            po.updateProduct(prod);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            Product prod = new Product();
            prod = retrieve();
            po.deleteProduct(prod);
        }

        public Order retrieveOrder()
        {
            Order ord = new Order();            
            ord.idOrder= Convert.ToInt32(idoTxt.Text);
            ord.name = nameoTxt.Text;
            ord.adress = adressoTxt.Text;
            ord.delivery = dateTimePicker1.Value;
            ord.status = statusoTxt.Text;
            return ord;
        }

        private void addoBtn_Click(object sender, EventArgs e)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            Order ord = new Order();
            ord = retrieveOrder();
            po.addOrder(ord);
           
        }

        private void updateoBtn_Click(object sender, EventArgs e)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            Order ord = new Order();
            ord = retrieveOrder();
            po.updateOrder(ord);
        }

        private void viewoBtn_Click(object sender, EventArgs e)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            dataGridView2.DataSource = po.viewOrders();

        }
        
        private Product getProduct(int id)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            return po.getProduct(id);
        }
        private Order getOrder(int id)
        {
            ProductOrderOperations po = new ProductOrderOperations();
            return po.getOrder(id);
        }

        public OrderDetails retrieveDetails()
        {
            OrderDetails ord = new OrderDetails();
            ord.idorder = Convert.ToInt32(idoTxt.Text);
            ord.idproduct = Convert.ToInt32(idproductTxt.Text);
            ord.iduser = Convert.ToInt32(iduserTxt.Text);
            ord.quantity = Convert.ToInt32(quantityTxt.Text);
            return ord;
        }

        private void addproducttoorderBtn_Click(object sender, EventArgs e)
        {
            int idorder = Convert.ToInt32(idoTxt.Text);
            int idproduct = Convert.ToInt32(idproductTxt.Text);
            int iduser = Convert.ToInt32(iduserTxt.Text);
            int quantity = Convert.ToInt32(quantityTxt.Text);

            
            Product prod = getProduct(idproduct);
            Order ord = getOrder(idorder);
            OrderDetails ordd = new OrderDetails();
            ordd.idorder = ord.idOrder;
            ordd.idproduct = prod.idproduct;
            ordd.iduser = iduser;
            ordd.quantity = quantity;
            ordd.price = ordd.quantity * prod.price;

            ProductOrderOperations po = new ProductOrderOperations();
           bool t= po.addProdOrder(ord, prod,ordd);
           if (t == false)
               lbl.Text = "Quantity too big!";
           else lbl.Text = "";
        }


    }
}
