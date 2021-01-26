using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (((Ogrenci)Session["AktifKullanici"]) == null)
        {
            Response.Redirect("Login.aspx", false);
        }
        else
        {
            try
            {
                DataTable SinifTable = new DataTable();
                string query = "SELECT * FROM Ogrenci INNER JOIN Sinif ON Ogrenci.SinifID = Sinif.Id";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(SinifTable);
                con.Close();
                da.Dispose();
                if (SinifTable != null && SinifTable.Rows.Count > 0)
                {
                    Sinifid.DataSource = SinifTable;
                    Sinifid.DataBind();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                //...
            }

        }
    }
}