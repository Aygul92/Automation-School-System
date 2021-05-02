<%@ Page Title="" Language="C#" MasterPageFile="~/AcademicMasterPage.master" AutoEventWireup="true" CodeFile="Aca_ChangePass.aspx.cs" Inherits="Aca_ChangePass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="bootstrap-3.3.7-dist/js/ChangePassword.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cplPageContents" runat="Server">
    // 

    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1>Change Password</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6 col-sm-offset-3">
                <p class="text-center">Use the form below to change your password. Your password cannot be the same as your username.</p>
                <form id="passwordForm1" runat="server">
                    &nbsp;<div class="row">
                        <div class="col-sm-6">
                            <asp:TextBox ID="tb_passs" runat="server"></asp:TextBox>
                            <br />
                            <br>
                            <asp:TextBox ID="tb_conf" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-sm-6">
                            <br>
                        </div>
                    </div>
                    &nbsp;<div class="row">
                        <div class="col-sm-12">
                        </div>
                    </div>
                    &nbsp;<asp:Button ID="Button1" runat="server" Text="Change Password" Width="174px" CssClass="col-xs-offset-0" BackColor="#993366" OnClick="Button1_Click" />
                </form>
            </div>
            <!--/col-sm-6-->
        </div>
        <!--/row-->
    </div>
</asp:Content>

