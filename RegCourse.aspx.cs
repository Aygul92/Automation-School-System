using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegCourse : System.Web.UI.Page
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
                DataTable DersTable = new DataTable();
                string query = "SELECT  * FROM Ders ";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(DersTable);
                con.Close();
                da.Dispose();
                if (DersTable != null && DersTable.Rows.Count > 0)
                {
                    rptDersler.DataSource = DersTable;
                    rptDersler.DataBind();
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

    [WebMethod]
    public static string OgrenciDersKaydet(string secilenDersIdleri)
    {
        try
        {
            //DB Kayıt işlemleri
            List<int> idler = secilenDersIdleri.Split(',').Select(int.Parse).ToList();

            DataTable kullaniciTable = new DataTable();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
            con.Open();
            for (int i = 0; i < idler.Count; i++)
            {
                string query = "INSERT   INTO OgrenciDers(OgrenciID, DersID,Statu) ";
                query += string.Format("VALUES ({0},{1},{2})", ((Ogrenci)HttpContext.Current.Session["AktifKullanici"]).Id,  idler[i], 1);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
               
            }
            con.Close();
            
            return "ok";
        }
        catch (Exception ex)
        {
            return "hata";
        }
    }
}