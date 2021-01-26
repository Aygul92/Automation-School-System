using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Academic_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (((Hoca)Session["AktifKullanici"]) == null)
        {
            Response.Redirect("HocaLogin.aspx", false);
        }
        else
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
           // SqlCommand cmd2 = new SqlCommand("SELECT * FROM Sinif Inner Join Bolum On Sinif.BolumID=Bolum.Id Inner Join Hoca On Hoca.BolumId=Bolum.Id" + ((Hoca)Session["AktifKullanici"]).Id.ToString(), con);
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Hoca Where Id = " + ((Hoca)Session["AktifKullanici"]).Id, con);
          
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable acKullanici = new DataTable();

                sda.Fill(acKullanici);
                if (acKullanici != null && acKullanici.Rows.Count > 0)
                {
                    adres.Text = acKullanici.Rows[0]["Adres"].ToString();
                    mail.Text = acKullanici.Rows[0]["Mail"].ToString();
                    reg.Text = acKullanici.Rows[0]["KTarihi"].ToString();
                    depart.Text = acKullanici.Rows[0]["Adi"].ToString();
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