using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentMasterPage : System.Web.UI.MasterPage
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
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Ogrenci Where Ogrenci.Id=" + ((Ogrenci)Session["AktifKullanici"]).Id, con);

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dtKullanici = new DataTable();

                sda.Fill(dtKullanici);
                if (dtKullanici != null && dtKullanici.Rows.Count > 0)
                {
                    kullaniciAdi.Text = dtKullanici.Rows[0]["Adi"].ToString();
                    ddlKullaniciAdi.Text = dtKullanici.Rows[0]["Adi"].ToString();
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
