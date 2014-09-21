<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="$safeprojectname$.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Incluindo o CSS do Bootstrap -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" media="screen" />
    <!-- Incluindo o jQuery que é requisito do JavaScript do Bootstrap -->
    <script type="text/javascript" src="Scripts/jquery-1.9.0.min.js"></script>
    <!-- Incluindo o JavaScript do Bootstrap -->
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand">Formulário de $safeprojectname$</a>
                    <ul class="nav navbar-nav">
                    </ul>
                </div>
            </div>
        </div>
        <br />
        <div>
            <legend></legend>
        </div>
        <div id="content">
            <div class="container">
                <div class="navbar-text navbar-letf">
                    <div>
                        <!-- Formulário de $safeprojectname$ -->
                        <form id="form1" runat="server">
                        <h2>
                            Conecte-se conosco!</h2>
                        <asp:Label ID="Label2" runat="server" Text="Label"><h2><small>O registro leva menos de 2 minutos</small></h2></asp:Label><br />
                        <input id="nome" type="text" class="form-control" data-target=".has-feedback" runat="server"
                            placeholder="Nome" /><br />
                        <input id="sobrenome" type="text" class="form-control" runat="server" placeholder="Sobrenome" /><br />
                        <input id="email" type="text" class="form-control" runat="server" placeholder="E-mail" /><br />
                        <input id="Senha" type="password" class="form-control" runat="server" placeholder="Senha (6 ou mais caracteres)" /><br />
                        <input id="confSenha" type="password" class="form-control" runat="server" placeholder="Repita a Senha" /><br />
                        <asp:Button ID="btnEnviar" class="btn btn-primary btn-primary" runat="server" Text="Enviar Agora!"
                            OnClick="enviar_Click"  />
                         
                        <asp:Label ID="resultado" runat="server" ></asp:Label>
                        </form>
                        <!-- Fim Formulário de $safeprojectname$ -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
