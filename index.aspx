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
    <!-- Incluindo o JavaScript do Jquery para Validações -->
    <script type="text/javascript" src="Scripts/jquery.validate.js"></script>
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
                        <form runat="server">
                        <h2>
                            Conecte-se conosco!</h2>
                        <asp:Label ID="Label2" runat="server" Text="Label"><h2><small>O registro leva menos de 2 minutos</small></h2></asp:Label><br />
                        <div class="form-group">
                        
                            <div class="input-group">
                                <input id="nome" class="form-control input-normal"  placeholder="Nome" name="nome" type="text" />
                            </div>
                        </div>
                        <div class="form-group">
              
                            <div class="input-group">
                                <input id="sobrenome" class="form-control"  placeholder="Sobrenome" name="sobrenome" type="text" />
                            </div>
                        </div>
                         <div class="form-group">
                            <div class="input-group">
                                <input id="email" class="form-control"  placeholder="Email" name="email" type="text" />
                            </div>
                        </div>
                         <div class="form-group">
                            <div class="input-group">
                                <input id="senha" class="form-control"  placeholder="Senha" name="senha" type="password" />
                            </div>
                        </div>
                         <div class="form-group">
                            <div class="input-group">
                                <input id="confSenha" class="form-control"  placeholder="Informe a senha novamente" name="confSenha" type="password" />
                            </div>
                        </div>
                        
                      
                         <asp:Button ID="btnEnviar" class="btn btn-primary btn-primary" runat="server" Text="Enviar Agora!"
                            OnClick="enviar_Click"  /><br />
  
                         <asp:Label ID="resultado" runat="server" Text=""></asp:Label>
                        </form>
                        <!-- Fim Formulário de $safeprojectname$ -->
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!--  Script para validar os inputs no cliente / Usuando API JQUERY VALIDATE  -->
    <script type="text/javascript">
        $('form').validate({
            rules: {
                nome: {
                    minlength: 3,
                    maxlength: 15,
                    required: true
                },
                sobrenome: {
                    minlength: 3,
                    maxlength: 15,
                    required: true
                },
                email: {
                    required: true,
                    email: true
                },
                senha: {
                    minlength: 6,
                    required: true
                
                },
                confSenha: {
                    minlength: 6,
                    required: true,
                    equalTo: '#senha'
                }
            },
         

            highlight: function (element) {
                $(element).closest('.form-group').addClass('has-error');
            },
            unhighlight: function (element) {
                $(element).closest('.form-group').removeClass('has-error');
            },
            errorElement: 'span',
            errorClass: 'help-block',
            errorPlacement: function (error, element) {
                if (element.parent('.input-group').length) {
                    error.insertAfter(element.parent());
                } else {
                    error.insertAfter(element);
                }
            }

        });
    </script>
</body>
</html>
