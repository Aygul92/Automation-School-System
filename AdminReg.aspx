<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminReg.aspx.cs" Inherits="AdminReg" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1">


    <!-- Website CSS style -->
    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">

    <!-- Website Font style -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.1/css/font-awesome.min.css">
    <link href="bootstrap-3.3.7-dist/css/admincss.css" rel="stylesheet" />
    <!-- Google Fonts -->
    <link href='https://fonts.googleapis.com/css?family=Passion+One' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Oxygen' rel='stylesheet' type='text/css'>

    <title>Admin</title>
    <style type="text/css">
        .auto-style1 {
            position: relative;
            display: table;
            border-collapse: separate;
            -webkit-box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.21) !important;
            -moz-box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.21) !important;
            box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.21) !important;
            left: 0px;
            top: 0px;
            width: 135px;
        }
        .auto-style2 {
            position: relative;
            display: table;
            border-collapse: separate;
            -webkit-box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.21) !important;
            -moz-box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.21) !important;
            box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.21) !important;
            left: 0px;
            top: 0px;
            width: 135px;
            height: 22px;
        }
        .auto-style3 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row main">
            <div class="main-login main-center">
                <h2>Admin Registration</h2>
                <form class="" method="post" action="#" runat="server">

                    <div class="form-group">
                        <label for="name" class="cols-sm-2 control-label">Your Name</label>
                        <div class="cols-sm-10">
                            <div class="auto-style1">
                                <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                 <asp:TextBox ID="ad_name" runat="server" Height="20px" ForeColor="Black"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="email" class="cols-sm-2 control-label">Your Email</label>
                        <div class="cols-sm-10">
                            <div class="auto-style2">
                                <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                <asp:TextBox ID="ad_mail" runat="server" Height="20px" ForeColor="Black"></asp:TextBox>
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <label for="password" class="cols-sm-2 control-label">Password</label>
                        <div class="cols-sm-10">
                            <div class="auto-style1">
                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                <asp:TextBox ID="ad_pass" runat="server" Height="20px" ForeColor="Black"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="confirm" class="cols-sm-2 control-label">Confirm Password</label>
                        <div class="cols-sm-10">
                            <div class="auto-style1">
                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>

                                <asp:TextBox ID="ad_conf" runat="server" Height="20px" ForeColor="Black"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="form-group " style="text-align: center">
                        <strong>
                       <asp:Button ID="ad_reg" runat="server" Text="Register" CssClass="auto-style3" ForeColor="Blue" OnClick="ad_reg_Click" Width="171px" />
                        </strong>
                    </div>

                </form>
            </div>
        </div>
    </div>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
