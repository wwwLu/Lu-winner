<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetPassword.aspx.cs" Inherits="BookShop.WebUI.GetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h2>修改密码</h2>
            账号：<asp:TextBox ID ="txtLoginId" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="txtLoginId" ErrorMessage="*账号未输入" ForeColor="Red"></asp:RequiredFieldValidator><br />
            原密码：<asp:TextBox ID ="txtOldLoginPwd" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldLoginPwd" ErrorMessage="*原密码未输入" ForeColor="Red"></asp:RequiredFieldValidator><br />
            新密码：<asp:TextBox ID ="txtNewLoginPwd" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewLoginPwd" ErrorMessage="*新密码未输入" ForeColor="Red"></asp:RequiredFieldValidator><br />
            确认密码：<asp:TextBox ID ="txtNewLoginPwd2" runat="server" TextMode="Password"></asp:TextBox>
                      <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtNewLoginPwd2"
                      ControlToCompore="txtNewLoginPwd" ErrorMessage="确认密码与新密码必须相同" ForeColor="Red"></asp:CompareValidator><br />
            <asp:Button ID="btnLogin" runat="server" Text="确认修改" OnClick="btnLogin_Click" />
            <asp:HyperLink ID="hlnkGetPassword" runat="server" Text="马上登录" NavigateUrl="MemberPortal/UserLogin.aspx"></asp:HyperLink>
    </div>
    </form>
</body>
</html>
