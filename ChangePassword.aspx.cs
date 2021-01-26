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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable kullaniciTable = new DataTable();
            int secilenOgrId = Convert.ToInt32(Request.QueryString["ogrId"]);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
            con.Open();
            //string query = "UPDATE Ogrenci SET Password=\"{0}\"",tb_pass;
            //string sql = "UPDATE Ogrenci SET Password=@Password";

            string sql = "update Ogrenci set Password=@Password where Ogrenci.id="+secilenOgrId;
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(sql, con);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@Password",tb_pass.Text);
           
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            con.Close();
            string script = "alert(\"Password is updated!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

            // create data adapter

            // this will query your database and return the result to your datatable

            if (kullaniciTable != null && kullaniciTable.Rows.Count > 0)
            {
                Ogrenci akitfKullanici = new Ogrenci();
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
