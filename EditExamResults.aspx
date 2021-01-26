<%@ Page Title="" Language="C#" MasterPageFile="~/AcademicMasterPage.master" AutoEventWireup="true" CodeFile="EditExamResults.aspx.cs" Inherits="EditExamResults" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="bootstrap-3.3.7-dist/css/personalinfo.css" rel="stylesheet" />

    <script src="bootstrap-3.3.7-dist/js/personalinfo.js"></script>
    <style>
        .multiselect-container {
            position: absolute;
            list-style-type: none;
            margin: 0;
            padding: 0
        }

            .multiselect-container .input-group {
                margin: 5px
            }

            .multiselect-container > li {
                padding: 0
            }

                .multiselect-container > li > a.multiselect-all label {
                    font-weight: bold
                }

                .multiselect-container > li > label.multiselect-group {
                    margin: 0;
                    padding: 3px 20px 3px 10px;
                    height: 100%;
                    font-weight: bold;
                }

                .multiselect-container > li > a > label {
                    margin: 0;
                    height: 100%;
                    cursor: pointer;
                    font-weight: normal
                }

                    .multiselect-container > li > a > label.radio, .multiselect-container > li > a > label.checkbox {
                        margin: 0
                    }

                    .multiselect-container > li > a > label > input[type="checkbox"] {
                        margin-bottom: 5px
                    }

        .btn-group > .btn-group:nth-child(2) > .multiselect.btn {
            border-top-left-radius: 4px;
            border-bottom-left-radius: 4px
        }

        .row {
            margin-bottom: 20px;
        }

        .btn {
            padding: 10px 16px;
            font-size: 18px;
            line-height: 1.33;
            border-radius: 6px;
        }

        .auto-style1 {
            width: 652px;
            margin-left: -10px;
            margin-right: -10px;
            margin-bottom: 20px;
        }

        .auto-style2 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 33%;
            left: 31px;
            top: 0px;
            height: 38px;
            padding-left: 10px;
            padding-right: 10px;
        }
    </style>
    <script src="bootstrap-3.3.7-dist/js/DropDown.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cplPageContents" runat="Server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xs-offset-0 col-sm-offset-0 col-md-offset-3 col-lg-offset-3 toppad">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <div class="container">
                            <div class="auto-style2">
                                &nbsp;
                            </div>

                            <div class="auto-style1">
                                <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="185px">
                                </asp:DropDownList>
                                <asp:Button ID="btnDersSec" runat="server" OnClick="btnDersSec_Click" Text="Ders Seç" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>

