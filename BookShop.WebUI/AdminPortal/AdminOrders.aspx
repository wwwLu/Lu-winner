<%@ Page Title="" Language="C#" MasterPageFile="~/AllMaster/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminOrders.aspx.cs" Inherits="BookShop.WebUI.AdminPortal.AdminOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>图书商城》后台管理》图书管理</div>
        <div style="width: 1436px">
            <asp:GridView ID="gvwOrderList" runat="server"  AllowPaging="True" PageSize="10" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="1242px" GridLines="Horizontal" OnPageIndexChanging="GVBook_PageIndexChanging" style="margin-right: 28px" OnRowCommand="GvwBookList_RowCommand" OnRowDataBound="gvwBookList_RowDataBound"  >
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="编号" />
                    <asp:BoundField DataField="OrderDate" HeaderText="订单日期" />
                    <asp:BoundField DataField="UserId" HeaderText="UserId" />
                    <asp:BoundField DataField="TotalPrice" HeaderText="总价格" DataFormatString="{0:f}" />
                    <asp:BoundField DataField="OrderState" HeaderText="OrderState"  />
                    <asp:TemplateField HeaderText="操作" ItemStyle-Width="70px">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkbtDelete" runat="server" Text="删除" CommandName="DeleteOrder" CommandArgument='<%#Eval("Id") %>' OnClientClick="javascript:return confirm('确认删除该订单吗?')"></asp:LinkButton>
                            <asp:LinkButton ID="lnkbtnEdit" runat="server" Text="编辑"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
</asp:GridView>



        </div>
</asp:Content>
