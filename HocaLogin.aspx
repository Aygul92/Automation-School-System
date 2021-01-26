<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HocaLogin.aspx.cs" Inherits="HocaLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link href="bootstrap-3.3.7-dist/css/bootstrap.css" rel="stylesheet" />
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="bootstrap-3.3.7-dist/css/Hocalogin.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            left: 0px;
            top: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="fullscreen_bg" class="fullscreen_bg" />

        <div class="container">
            <header>
                <h1>Student Information System</h1>
            </header>
            <section>
                <div id="container_demo">
                    <a class="hiddenanchor" id="toregister"></a>
                    <a class="hiddenanchor" id="tologin"></a>
                    <div id="wrapper">
                        <div id="login" class="animate form">
                            <h1>Log in</h1>
                            <h3><asp:Label ID="errorMessage" runat="server" ForeColor="Red"></asp:Label></h3>
                            <p>
                                <label for="username" class="uname">Your email or username </label>
                                <asp:TextBox ID="loguser" runat="server"></asp:TextBox>
                            </p>
                            <p>
                                <label for="password" class="youpasswd">Your password </label>
                                <asp:TextBox ID="logpass" runat="server" TextMode="Password"></asp:TextBox>
                            </p>
                            <p class="login button">
                                <asp:Button ID="btnGirisYap" runat="server" Text="Login" OnClick="btnGirisYap_Click" />
                            </p>
                           
                        </div>

                      </div>
                </div>
            </section>
        </div>
    </form>
</body>
</html>
