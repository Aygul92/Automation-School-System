using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Aca_ChangePass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable kullaniciTable = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
            con.Open();
        

            string sql = "update Hoca set Password=@Password";
 
            SqlCommand komut = new SqlCommand(sql, con);

            komut.Parameters.AddWithValue("@Password", tb_passs.Text);

            komut.ExecuteNonQuery();

            con.Close();
            string script = "alert(\"Password is updated!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

            // create data adapter

            // this will query your database and return the result to your datatable

            if (kullaniciTable != null && kullaniciTable.Rows.Count > 0)
            {
                Hoca akitfKullanici = new Hoca();
                akitfKullanici.Password = kullaniciTable.Rows[0]["Password"].ToString();


                Session["AktifKullanici"] = akitfKullanici;
                Response.Redirect("Default.aspx", false);
            }
            else
            {

            }
            //con.Close();
        }

        catch (Exception ex)

        {

        }






    }
}