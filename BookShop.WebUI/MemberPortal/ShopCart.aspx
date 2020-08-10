<%@ Page Language="C#" MasterPageFile="~/AllMaster/IndexMaseter.Master" AutoEventWireup="true" CodeBehind="ShopCart.aspx.cs" Inherits="BookShop.WebUI.MemberPortal.ShopCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>我的购物车</div>
        <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvCart_RowDataBound"  ShowFooter="True" OnSelectedIndexChanged="gvCart_SelectedIndexChanged" OnRowCancelingEdit="gvCart_RowCancelingEdit" OnRowDeleting="gvCart_RowDeleting" OnRowEditing="gvCart_RowEditing" OnRowUpdating="gvCart_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="图书编号">
                    <ItemTemplate>
                        <asp:Label ID="lblBookId" runat="server" Text='<%#Eval("Book.Id") %>' />
                    </ItemTemplate>
                    </asp:TemplateField>
                <asp:BoundField  HeaderText="图书名称" DataField="Book.Title" ReadOnly="true" />
                <asp:BoundField  HeaderText="图书单价" DataField="Book.UnitPrice" ReadOnly="true"  />
                <asp:TemplateField HeaderText="数量">
                <ItemTemplate>
                    <asp:Label ID="lblnum" runat="server" Text='<%#Eval("Quantity") %>' />
                </ItemTemplate>
               <EditItemTemplate>
                   <asp:TextBox ID="txtnumber" runat="server" Text='<%#Eval("Quantity") %>' />
               </EditItemTemplate>
              </asp:TemplateField>
                <asp:BoundField  HeaderText="小计" DataField="SubTotal" ReadOnly="true"/>
               <asp:TemplateField HeaderText="操作">
                       <ItemTemplate>
                             <asp:LinkButton ID="lbtnEdit" runat="server" Text="编辑" CommandName="EditBook"   />
                             <asp:LinkButton ID="lbtnDelete" runat="server" Text="删除" CommandName="DeleteBook" />
                           </ItemTemplate>
                                  <EditItemTemplate>
                                      <asp:LinkButton ID="lbtnUpdate" runat="server" Text="更新" CommandName="Update"   />
                                      <asp:LinkButton ID="lbtnCancel" runat="server" Text="取消" CommandName="Cancel" />
                                  </EditItemTemplate>
                      </asp:TemplateField>
              </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:Label ID="lbshow" runat="server" Text="显示信息"></asp:Label><br />
    </asp:Content>