using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditExamResults : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            SqlCommand cmd = new SqlCommand("select DersID, Adi from Ders inner join HocaDers on HocaDers.DersID = Ders.Id Where HocaDers.HocaID=" + ((Hoca)Session["AktifKullanici"]).Id, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            DropDownList1.DataValueField = "DersID";
            DropDownList1.DataTextField = "Adi";
            DropDownList1.DataSource = rdr;
            DropDownList1.DataBind();
        }
    }

    protected void btnDersSec_Click(object sender, EventArgs e)
    {
        try
        {
            int secilenDersID = Convert.ToInt32(DropDownList1.SelectedValue);
            Response.Redirect("ExamResult.aspx?courseId=" + secilenDersID, false);
        }
        catch (Exception ex)
        {

        }
    }
}
