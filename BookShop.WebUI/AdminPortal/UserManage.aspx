<%@ Page Title="" Language="C#" MasterPageFile="~/AllMaster/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UserManage.aspx.cs" Inherits="BookShop.WebUI.AdminPortal.UserManage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>图书商城》后台管理》用户管理</div>
            <asp:GridView ID="gvwUserList" runat="server"  AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" Width="1600px" GridLines="Horizontal" style="margin-right: 28px" >
                <Columns>
                    <asp:BoundField ItemStyle-Width="150px" DataField="LoginId" HeaderText="登录名称" >
<ItemStyle Width="150px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="LoginPwd" HeaderText="登录密码" />
                    <asp:BoundField DataField="Name" HeaderText="真实姓名" />
                    <asp:BoundField ItemStyle-Width="300px" DataField="Address" HeaderText="地址" >
<ItemStyle Width="300px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Phone" HeaderText="电话号码" />
                    <asp:BoundField DataField="Mail" HeaderText="邮箱地址" />
                    <asp:TemplateField HeaderText="操作" ItemStyle-Width="100px">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkbtDelete" runat="server" Text="删除" CommandName="DeleteUser" CommandArgument='<%#Eval("Id") %>' OnClientClick="javascript:return confirm('确认删除该用户吗?')"></asp:LinkButton>
                            <asp:LinkButton ID="lnkbtnEdit" runat="server" Text="编辑"></asp:LinkButton>
                        </ItemTemplate>

<ItemStyle Width="100px"></ItemStyle>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
</asp:Content>
