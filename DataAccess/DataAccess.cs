using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using Models;
using MySql.Data.MySqlClient;

namespace DA
{
    public class DataAccess
    {
        private string connString;

        public DataAccess()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public User GetUser(string userName)
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                  conn.Open();
                  string statement = "SELECT * FROM user where name=\""+ userName +"\";";
                
                  MySqlCommand cmd = new MySqlCommand(statement,conn);
                  MySqlDataReader reader = cmd.ExecuteReader();
                  if (reader.Read())
                  {
                      {
                          User user = new User();
                          user.id = reader.GetInt32("iduser");
                          user.name = reader.GetString("name");
                          user.password = reader.GetString("password");
                          user.IsAdmin = reader.GetBoolean("type");
                          return user;
                      }
                  }
              }
                  
                return null;
            }
            
            public void AddUser(User user)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO user(iduser,type,name, password) VALUES(@id,@IsAdmin,@name, @password)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@name", user.name);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
                    cmd.Parameters.AddWithValue("@id", user.id);
   
                    cmd.ExecuteNonQuery();
                }
            }
        public IList<User> RetrieveUsers()
            {
            IList<User> userList = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM user";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.id=reader.GetInt32("iduser");
                        user.name=reader.GetString("name");
                        user.password=reader.GetString("password");
                        user.IsAdmin=reader.GetBoolean("type");
                        userList.Add(user);
                    }
                }
                return userList;
            }
            }
        public void DeleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteUser";

                cmd.Parameters.Add(new MySqlParameter("username", user.name));

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateUser";

                cmd.Parameters.Add(new MySqlParameter("id", user.id));
                cmd.Parameters.Add(new MySqlParameter("isadmin", user.IsAdmin));
                cmd.Parameters.Add(new MySqlParameter("uname", user.name));
                cmd.Parameters.Add(new MySqlParameter("pass", user.password));

                cmd.ExecuteNonQuery();
            }
        }
        public void addProduct(Product prod)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product(idproduct,title,description,color,size,price,stock) VALUES(@id,@title,@desc,@color,@size,@price,@stock)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", prod.idproduct);
                cmd.Parameters.AddWithValue("@title", prod.title);
                cmd.Parameters.AddWithValue("@desc", prod.description);
                cmd.Parameters.AddWithValue("@color", prod.color);
                cmd.Parameters.AddWithValue("@size", prod.size);
                cmd.Parameters.AddWithValue("@price", prod.price);
                cmd.Parameters.AddWithValue("@stock", prod.stock);

                cmd.ExecuteNonQuery();
            }
        }
        public IList<Product> RetrieveProducts()
        {
            IList<Product> productList = new List<Product>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM product";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.idproduct = reader.GetInt32("idproduct");
                        prod.title = reader.GetString("title");
                        prod.description = reader.GetString("description");
                        prod.color = reader.GetString("color");
                        prod.size = reader.GetInt32("size");
                        prod.price = reader.GetFloat("price");
                        prod.stock = reader.GetInt32("stock");
                        productList.Add(prod);
                    }
                }
                return productList;
            }
        }
        public void updateProduct(Product prod)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product SET title = @ptitle, description = @desc,color=@pcolor,size=@psize,price=@pprice,stock=@pstock WHERE idproduct = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", prod.idproduct);
                cmd.Parameters.AddWithValue("@ptitle", prod.title);
                cmd.Parameters.AddWithValue("@desc", prod.description);
                cmd.Parameters.AddWithValue("@pcolor", prod.color);
                cmd.Parameters.AddWithValue("@psize", prod.size);
                cmd.Parameters.AddWithValue("@pprice", prod.price);
                cmd.Parameters.AddWithValue("@pstock", prod.stock);

                cmd.ExecuteNonQuery();
            }
        }
        public void deleteProduct(Product prod)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product WHERE idproduct = @id AND title = @ptitle";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", prod.idproduct);
                cmd.Parameters.AddWithValue("@ptitle", prod.title);

                cmd.ExecuteNonQuery();
            }
        }
        public Product getProduct(int idProduct)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM product WHERE idproduct = @id";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@id", idProduct);
                MySqlDataReader reader = cmd.ExecuteReader();
                Product prod = new Product();

                if (reader.Read())
                {
                    prod.idproduct = reader.GetInt32("idproduct");
                    prod.title = reader.GetString("title");
                    prod.description = reader.GetString("description");
                    prod.color = reader.GetString("color");
                    prod.size = reader.GetInt32("size");
                    prod.price = reader.GetFloat("price");
                    prod.stock = reader.GetInt32("stock");
                }
                        return prod;
                }
            }

        public Order getOrder(int idOrder)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM as1.order WHERE idOrder = @id";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@id", idOrder);
                MySqlDataReader reader = cmd.ExecuteReader();
                Order ord = new Order();

                if (reader.Read())
                {
                    ord.idOrder = reader.GetInt32("idOrder");
                    ord.name = reader.GetString("Customer");
                    ord.adress = reader.GetString("Adress");
                    ord.delivery = reader.GetDateTime("deliveryDate");
                    ord.status = reader.GetString("status");
                }
                return ord;
            }
        }
      
        public void addOrder(Order ord)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO as1.order(idOrder,Customer,Adress,deliveryDate,status) VALUES(@id,@name,@adress,@delivery,@status)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id",ord.idOrder );
                cmd.Parameters.AddWithValue("@name", ord.name);
                cmd.Parameters.AddWithValue("@adress", ord.adress);
                cmd.Parameters.AddWithValue("@delivery", ord.delivery);
                cmd.Parameters.AddWithValue("@status", ord.status);
                cmd.ExecuteNonQuery();
                
            }
        }
        public void updateOrder(Order ord)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE as1.order SET Customer = @name, Adress = @adr, deliveryDate = @delDate, status = @sts WHERE idOrder = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", ord.idOrder);
                cmd.Parameters.AddWithValue("@name", ord.name);
                cmd.Parameters.AddWithValue("@adr", ord.adress);
                cmd.Parameters.AddWithValue("@delDate", ord.delivery);
                cmd.Parameters.AddWithValue("@sts", ord.status);  

                cmd.ExecuteNonQuery();
            }
        }
        public IList<Order> RetrieveOrders()
        {
            IList<Order> ordersList = new List<Order>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM as1.order";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Order ord = new Order();
                        ord.idOrder = reader.GetInt32("idOrder");
                        ord.name = reader.GetString("Customer");
                        ord.adress = reader.GetString("Adress");
                        ord.delivery = reader.GetDateTime("deliveryDate");
                        ord.status = reader.GetString("status");
                        
                        ordersList.Add(ord);
                    }
                }
                return ordersList;
            }
        }

        private void updateStock(int id,int sold)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE as1.product SET stock = stock-@sold WHERE idproduct = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sold", sold);

                cmd.ExecuteNonQuery();
            }
        }

        public bool addProductToOrder(Order ord, Product prod,OrderDetails ordd)
        {
            if (prod.stock > ordd.quantity)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {

                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO as1.orderdetails(idOrder,idProduct,idUser,quantity,total,orderDate) VALUES(@ido,@idp,@idu,@quantity,@total,@da)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@ido", ord.idOrder);
                    cmd.Parameters.AddWithValue("@idp", prod.idproduct);
                    cmd.Parameters.AddWithValue("@idu", ordd.iduser);
                    cmd.Parameters.AddWithValue("@quantity", ordd.quantity);
                    cmd.Parameters.AddWithValue("@total", ordd.quantity * prod.price);
                    cmd.Parameters.AddWithValue("@da", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                updateStock(prod.idproduct, ordd.quantity);
                return true;
            }
            else
                return false;
        }
        public IList<OrderDetails> generate(DateTime d1, DateTime d2,int id)
        {
            IList<OrderDetails> ordersList = new List<OrderDetails>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM as1.orderdetails where orderDate>=@d1 and orderDate<=@d2 and idUser = @id";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@d1", d1);
                cmd.Parameters.AddWithValue("@d2", d2);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderDetails ord = new OrderDetails();
                        ord.idorder = reader.GetInt32("idOrder");
                        ord.idproduct = reader.GetInt32("idProduct");
                        ord.iduser = reader.GetInt32("idUser");
                        ord.quantity = reader.GetInt32("quantity");
                        ord.price = reader.GetInt32("total");
                        ord.orderDate = reader.GetDateTime("orderDate");
                        ordersList.Add(ord);
                    }
                }
                return ordersList;
            }
        }
       }

    }

