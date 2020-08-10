<%@ Page Language="C#" MasterPageFile="~/AllMaster/IndexMaseter.Master" AutoEventWireup="true" CodeBehind="UseLogin.aspx.cs" Inherits="BookShop.WebUI.MemberPortal.UseLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:Panel ID="pnlLogin" runat="server">
            <asp:Label  ID="Label1" runat="server" Text="帐号："></asp:Label> <br />
            <asp:TextBox ID="txtLoginid" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoginId" ErrorMessage="*帐号不为空" ForeColor="Red"></asp:RequiredFieldValidator> <br />
            <asp:Label  ID="Label2" runat="server" Text="密码："></asp:Label><br />
            <asp:TextBox  ID="txtLoginPwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator  ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLoginPwd" ErrorMessage="*密码不为空" ForeColor="Red"></asp:RequiredFieldValidator> 

            <br />
            <asp:CheckBox ID="cbLoginExpires" runat="server" Text="2周内不用登入" /><br />
            <asp:Button  ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
            <asp:HyperLink ID="hlnkGetPassword" runat="server" Text="忘记密码" NavigateUrl="UpUserPwd.aspx"></asp:HyperLink><br />
            你还不是网上书店用户？<br />
            <asp:HyperLink ID="HyperRegister" runat="server" Text="注册新账号" NavigateUrl="UserRegister.aspx" ></asp:HyperLink><br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        </asp:Panel>

        <asp:Panel ID="pnlLoginView" runat="server">
             欢迎:<asp:Label ID="lblLoginId" runat="server" /><br/>
            登录日期:<asp:Label ID="lblVisite" runat="server" /><br/>
            IP:<asp:Label ID="lblIP" runat="server" /><br />
            <asp:Button ID="btnLogout" Text="注销" runat="server" OnClick="btnLogout_Click1"  />
            <asp:LinkButton ID="lbtnUpdatePassword" runat="server" Text="修改密码" />
        </asp:Panel>


        </asp:Content>