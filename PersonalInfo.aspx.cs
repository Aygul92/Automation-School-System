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
        if (((Ogrenci)Session["AktifKullanici"]) == null)
        {
            Response.Redirect("Login.aspx", false);
        }
        else
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanici WHERE id=" + ((Kullanici)Session["AktifKullanici"]).id.ToString(), con);
            SqlCommand cmd2= new SqlCommand("SELECT * FROM Ogrenci INNER JOIN Sinif on Ogrenci.SinifID=Sinif.Id INNER JOIN Bolum on Sinif.BolumID = Bolum.Id WHERE Ogrenci.Id=" + ((Ogrenci)Session["AktifKullanici"]).Id, con); 

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dtKullanici = new DataTable();
                
                sda.Fill(dtKullanici);
                if (dtKullanici != null && dtKullanici.Rows.Count > 0)
                {
                    lb_adres.Text = dtKullanici.Rows[0]["Adres"].ToString();
                    lb_mail.Text = dtKullanici.Rows[0]["Mail"].ToString();
                    lb_reg.Text = dtKullanici.Rows[0]["Ktarihi"].ToString();
                    lb_depart.Text = dtKullanici.Rows[0]["Adi"].ToString();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                //...
            }
            finally
            {
                con.Close();
            }
        }
    }
}