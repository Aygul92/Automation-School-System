using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class TestLogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGirisYap_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable kullaniciTable = new DataTable();
            string query = "SELECT * FROM Ogrenci WHERE Mail = '" + loguser.Text + "' AND Password= '" + logpass.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(kullaniciTable);
            con.Close();
            da.Dispose();
            if (kullaniciTable != null && kullaniciTable.Rows.Count > 0)
            {
                Ogrenci akitfKullanici = new Ogrenci();
                akitfKullanici.Id = Convert.ToInt32(kullaniciTable.Rows[0]["Id"].ToString());
                akitfKullanici.SinifID = (kullaniciTable.Rows[0]["SinifID"] != null && kullaniciTable.Rows[0]["SinifID"] != System.DBNull.Value) ? Convert.ToInt32(kullaniciTable.Rows[0]["SinifID"].ToString()) : 0;
                akitfKullanici.Adi = kullaniciTable.Rows[0]["Adi"].ToString();
                akitfKullanici.Mail = kullaniciTable.Rows[0]["Mail"].ToString();
                akitfKullanici.Password = kullaniciTable.Rows[0]["Password"].ToString();
                akitfKullanici.Adress = kullaniciTable.Rows[0]["Adres"].ToString();
                akitfKullanici.KTarihi = Convert.ToDateTime(kullaniciTable.Rows[0]["KTarihi"].ToString());
                akitfKullanici.Statu = Convert.ToBoolean(kullaniciTable.Rows[0]["Statu"].ToString());

                Session["AktifKullanici"] = akitfKullanici;
                Response.Redirect("PersonalInfo.aspx", false);

            }
            else Response.Write("hata");
        }
        catch (Exception ex)
        {

        }
    }
}