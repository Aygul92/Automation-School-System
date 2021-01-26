using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditStudentNote : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void bt_advze_Click(object sender, EventArgs e)
    {
        try
        {
            int secilenOgrId = Convert.ToInt32(Request.QueryString["ogrId"]);
            int secilenDersId = Convert.ToInt32(Request.QueryString["courseId"]);
            con.Open();


            string sql = "update OgrenciDers set Vize=@Vize where OgrenciDers.OgrenciID=" + secilenOgrId;

            SqlCommand komut = new SqlCommand(sql, con);

            komut.Parameters.AddWithValue("@Vize", Tb_vize.Text);

            komut.ExecuteNonQuery();

            con.Close();
            con.Close();
            string script = "alert(\"the Note of Midterim is updated!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

        }

        catch (Exception ex)

        {

        }
    }

    protected void bt_adfnl_Click(object sender, EventArgs e)
    {
        try
        {
            int secilenOgrId = Convert.ToInt32(Request.QueryString["ogrId"]);
            int secilenDersId = Convert.ToInt32(Request.QueryString["courseId"]);
            con.Open();


            string sql = "update OgrenciDers set Final=@Final where OgrenciDers.OgrenciID=" + secilenOgrId;

            SqlCommand komut = new SqlCommand(sql, con);

            komut.Parameters.AddWithValue("@Final", Tb_final.Text);

            komut.ExecuteNonQuery();

            con.Close();
            con.Close();
            string script = "alert(\"the Note of Final is updated!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

        }

        catch (Exception ex)

        {

        }
    }

    protected void bt_ort_Click(object sender, EventArgs e)
    {
        int vize = Convert.ToInt32(Tb_vize.Text);
        int final = Convert.ToInt32(Tb_final.Text);
        int ort;
        ort = (vize * 40) / 100 + (final * 60) / 100;
        lb_sonuc.Text = ort.ToString();

    }

    protected void bt_orthes_Click(object sender, EventArgs e)
    {
        DataTable OrtTable = new DataTable();
        try
        {
            int secilenOgrId = Convert.ToInt32(Request.QueryString["ogrId"]);
            int secilenDersId = Convert.ToInt32(Request.QueryString["courseId"]);

            int ortalama = Convert.ToInt32(lb_sonuc.Text.ToString().Split(',')[0]);
            con.Open();
            string query = string.Format("update OgrenciDers set Ort = {0} where OgrenciDers.OgrenciID = {1}and OgrenciDers.DersId ={2}", ortalama, secilenOgrId, secilenDersId);

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(OrtTable);
            con.Close();
            da.Dispose();
            if (OrtTable != null && OrtTable.Rows.Count > 0)
            {
                lb_sonuc.Text = OrtTable.Rows[0]["Ort"].ToString();
            }
            else
            {

            }



        }
        catch (Exception ex)
        {

        }

    }
}
