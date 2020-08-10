<%@ Page Title="" Language="C#" MasterPageFile="~/AllMaster/IndexMaseter.Master" AutoEventWireup="true" CodeBehind="UpUserPwd.aspx.cs" Inherits="BookShop.WebUI.MemberPortal.UpUserPwd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>图书商城》前端浏览》更改密码</div>
    <div class="text" style="margin-top:30px; font-size:large; text-align:center;">用户修改密码</div>
    <div style="margin-top:20px;margin-left:60px;padding:10px">请输用户名:<asp:TextBox runat="server" ID="txtuername"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                  ControlToValidate="txtuername" Text ="*  用户名不能为空" ForeColor ="Red"></asp:RequiredFieldValidator>
    </div>
    <div style="margin-top:8px;margin-left:60px;padding:10px">请输入旧密码:<asp:TextBox  ID="txtoldpwd" runat="server" TextMode="Password" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                  ControlToValidate="txtoldpwd" ErrorMessage ="*  旧密码不能为空" ForeColor ="Red">
        </asp:RequiredFieldValidator>
    </div>
    <div style="margin-top:8px;margin-left:60px;padding:10px">请输入新密码:<asp:TextBox  ID="txtnewpwd" runat="server" TextMode="Password" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                  ControlToValidate="txtnewpwd" ErrorMessage ="*  新密码不能为空" ForeColor ="Red">
        </asp:RequiredFieldValidator>
    </div>
    <div style="margin-top:8px;margin-left:60px;padding:10px">再输入新密码:<asp:TextBox  ID="txtrenewpwd" runat="server" TextMode="Password" />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="两次密码不一致" ControlToCompare="txtrenewpwd" ControlToValidate="txtnewpwd" ForeColor="Red"></asp:CompareValidator>
    </div>
    <div style="margin-top:8px;margin-left:160px;"><asp:Button ID="BtnOk"  runat="server" Text="修改密码" OnClick="btnOK_Click" ></asp:Button></div>


</asp:Content>
