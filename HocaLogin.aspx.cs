using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HocaLogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGirisYap_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable kullaniciTable1 = new DataTable();
            string query = "SELECT * FROM Hoca WHERE Mail = '" + loguser.Text + "' AND Password= '" + logpass.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(kullaniciTable1);
            con.Close();
            da.Dispose();
            if (kullaniciTable1 != null && kullaniciTable1.Rows.Count > 0)
            {
                Hoca akitfKullanici = new Hoca();
                akitfKullanici.Id = Convert.ToInt32(kullaniciTable1.Rows[0]["Id"].ToString());
                akitfKullanici.BolumID = (kullaniciTable1.Rows[0]["BolumID"] != null && kullaniciTable1.Rows[0]["BolumID"] != System.DBNull.Value) ? Convert.ToInt32(kullaniciTable1.Rows[0]["BolumID"].ToString()) : 0;
                akitfKullanici.Adi = kullaniciTable1.Rows[0]["Adi"].ToString();
                akitfKullanici.Mail = kullaniciTable1.Rows[0]["Mail"].ToString();
                akitfKullanici.Password = kullaniciTable1.Rows[0]["Password"].ToString();
                akitfKullanici.Adress = kullaniciTable1.Rows[0]["Adres"].ToString();
                akitfKullanici.KTarihi = Convert.ToDateTime(kullaniciTable1.Rows[0]["KTarihi"].ToString());
                akitfKullanici.Statu = Convert.ToBoolean(kullaniciTable1.Rows[0]["Statu"].ToString());

                Session["AktifKullanici"] = akitfKullanici;
                Response.Redirect("Aca_PersonalInfo.aspx", false);
            }
            }
        catch (Exception ex)
        {

        }
    }
}