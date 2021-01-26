using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AdminReg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ad_reg_Click(object sender, EventArgs e)
    {
        try
        {
            if (true)// boş kontrolü
            {
                
            }

            if (true)//şifreler aynımı?
            {

            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=OgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
            con.Open();
            string query = "INSERT INTO Kullanici(KullaniciTipi, KullaniciAdi, KullaniciMail, KTarihi, Statu, KullaniciSifre,SinifID,Adress,Image) ";
            query += string.Format("VALUES ({0},'{1}','{2}','{3}',{4},'{5}')", UserRoles.AdminRolu, ad_name.Text.Trim(), ad_mail.Text.Trim(), DateTime.Now, 1, ad_pass.Text.Trim());
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            

        }
        catch (Exception ex)
        {

        }
    }
}
