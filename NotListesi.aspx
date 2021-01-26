<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="NotListesi.aspx.cs" Inherits="NotListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    
    
    <style type="text/css">
        .auto-style1 {
            width: 201px;
        }
    </style>

    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cplPageContents" runat="Server">
      <div class="container">

        <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xs-offset-0 col-sm-offset-0 col-md-offset-3 col-lg-offset-3 toppad" style="left: 76px; top: 13px; width: 58%; height: 387px">
            <div class="panel panel-info">
                <div class="panel-heading">
                    
                </div>
                <div class="panel-body">
                   <table class="table">
    <thead>
        <tr>
          
            <th class="auto-style1">Name of Lessons</th>
            <th>Midterm</th>
            <th>Final</th>
            <th>Average</th>
        </tr>
    </thead>
    <tbody>
        <tr>
         
            <td class="auto-style1">

                 <asp:Repeater ID="NotList" runat="server">
                                    <ItemTemplate>
                                        <li class="list-group-item"><%#Eval("Adi")%></li>

                                    </ItemTemplate>
                                </asp:Repeater>

            </td>
            <td>

                 <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <li class="list-group-item"><%#Eval("Vize")%></li>
                                    </ItemTemplate>
                                </asp:Repeater>

            </td>
            <td>
                  <asp:Repeater ID="Repeater2" runat="server">
                                    <ItemTemplate>
                                        <li class="list-group-item"><%#Eval("Final")%></li>
                                    </ItemTemplate>
                                </asp:Repeater>


            </td>
            <td>
                <asp:Repeater ID="Repeater3" runat="server">
                                    <ItemTemplate>
                                        <li class="list-group-item"><%#Eval("Ort")%></li>
                                    </ItemTemplate>
                                </asp:Repeater>
            </td>
        </tr>
       

    </tbody>
</table>

                </div>
              
            </div>
        </div>
    </div>


</asp:Content>

