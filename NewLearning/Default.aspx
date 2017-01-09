<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewLearning.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
<script type = "text/javascript">
    function ShowCurrentTime() {
        $.ajax({
            type: "POST",
            url: "Default.aspx/GetCurrentTime",
            data: '{name: "' + $("#<%=txtUserName.ClientID%>")[0].value + '" }',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: OnSuccess,
            failure: function (response) {
                alert(response.d);
            }
        });
    }
    function OnSuccess(response) {
        alert(response.d);
    }



    function LogOut() {
        $.ajax({
            type: "POST",
            url: "Default.aspx/LogOut",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                alert("Success:" + response.d);

                location.href = 'http://www.google.com';
            },
        failure: function (response) {
            alert("Failure:"+response.d);
        }
        })
    }
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
Your Name :
<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
<input id="btnGetTime" type="button" value="Show Current Time"
    onclick = "LogOut()" />
</div>

       

    </div>
    </form>
</body>
</html>
