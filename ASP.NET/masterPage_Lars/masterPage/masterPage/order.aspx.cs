using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace masterPage
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;database=gamestore;uid=root;password=mysql";

            MySqlConnection con = new MySqlConnection(myConnection);

            try
            {
                con.Open();
            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
            }


            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter("select * from games", myConnection);
            DataSet myDataset = new DataSet();
            myDataAdapter.Fill(myDataset);

            GridView1.DataSource = myDataset;
            GridView1.DataBind();

        }
    }
}