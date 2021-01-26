<%@ Page Title="" Language="C#" MasterPageFile="~/AcademicMasterPage.master" AutoEventWireup="true" CodeFile="EditStudentNote.aspx.cs" Inherits="EditStudentNote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="bootstrap-3.3.7-dist/css/personalinfo.css" rel="stylesheet" />

    <script src="bootstrap-3.3.7-dist/js/personalinfo.js"></script>


</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="cplPageContents" Runat="Server">
    <form id="form1" runat="server">
      <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xs-offset-0 col-sm-offset-0 col-md-offset-3 col-lg-offset-3 toppad">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <h3 class="panel-title">Sheena Shrestha</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-3 col-lg-3 " align="center">
                            <img alt="User Pic" src="http://babyinfoforyou.com/wp-content/uploads/2014/10/avatar-300x300.png" class="img-circle img-responsive">
                        </div>
                        <div class=" col-md-9 col-lg-9 ">
                            <table class="table table-user-information">
                                <tbody>
                                    <tr>
                                        <td>Midterm :</td>
                                        <td>
                                            <asp:TextBox ID="Tb_vize" runat="server"></asp:TextBox>
                                             
                                            <asp:Button ID="bt_advze" class="btn btn-warning" runat="server" Text="Add" Height="30px" Width="50px" OnClick="bt_advze_Click" />

                                    </tr>
                                    <tr>
                                        <td>Final :</td>
                                        <td>
                                            <asp:TextBox ID="Tb_final" runat="server"></asp:TextBox>
                                           
                                           
                                            <asp:Button ID="bt_adfnl" class="btn btn-warning" runat="server" Text="Add" Height="30px" Width="50px" OnClick="bt_adfnl_Click" />

                                    </tr>
                                    <tr>
                                        <td> Average :</td>
                                        <td>
                                            
                                            <asp:Button ID="bt_ort" class="btn btn-info" runat="server" Text="Evaluate" Height="30px" Width="70px" OnClick="bt_ort_Click" />
                                            <asp:Label ID="lb_sonuc" runat="server" Text="Label"></asp:Label>
                                    &nbsp;&nbsp;
                                               <asp:Button ID="bt_ort1" class="btn btn-success" runat="server" Text="Add" Height="30px" Width="56px" OnClick="bt_orthes_Click" />
                                            </br>
                                    </tr>
                                   
                                </tbody>
                            </table>

                        </div>
                    </div>
                </div>
               
            </div>
        </div>
  </form>






</asp:Content>

