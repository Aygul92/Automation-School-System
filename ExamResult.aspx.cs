using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectClass : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5J583K\SQL_2016;Initial Catalog=YeniOgrenciOtomasyon;Persist Security Info=True;User ID=sa;Password=123456789");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                DataTable SinifTable = new DataTable();
                int secilenDersId = Convert.ToInt32(Request.QueryString["courseId"]);
                SqlCommand cmd = new SqlCommand("select Ogrenci.Adi,Ogrenci.Id from Ders inner join OgrenciDers on Ders.Id= OgrenciDers.DersID inner join Ogrenci on Ogrenci.Id=OgrenciDers.OgrenciID Where Ders.Id=" + secilenDersId, con);
                con.Open();
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(SinifTable);
                con.Close();
                da.Dispose();
                if (SinifTable != null && SinifTable.Rows.Count > 0)
                {
                    ogr_id.DataSource = SinifTable;
                    ogr_id.DataBind();
                }
                else
                {

                }
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("EditExamResults.aspx", false);
        }
    }

  
}
