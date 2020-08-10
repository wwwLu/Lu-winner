<%@ Page Language="C#" MasterPageFile="~/AllMaster/AdminMaster.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="BookShop.WebUI.AdminPortal.BookList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
        <asp:DropDownList ID="ddlCategory" runat="server" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true"/>
        <div>

            <asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gvBooks_RowCommand" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                     <asp:BoundField DataField="Title" HeaderText="书名" />
                    <asp:BoundField DataField="Author" HeaderText="作者" />
                    <asp:BoundField DataField="Publisher" HeaderText="出版社" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="单价" DataFormatString="{0:F2}"/>
                    <asp:BoundField DataField="PublishDate" HeaderText="出版日期" DataFormatString="{0:yyyy-MM-dd}" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbtnEdit" runat="server" Text="编辑" CommandName="EditBook"  CommandArgument='<%#Eval("Id") %>' />
                            <asp:LinkButton ID="lbtnDelete" runat="server" Text="删除" CommandName="DeleteBook"  CommandArgument='<%#Eval("Id") %>'
                             OnClientClink="javascript:return confirm('确认删除该图书吗？')" ></asp:LinkButton>
                                
                                
                                </ItemTemplate>
                    </asp:TemplateField>

                    </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <webdiyer:AspNetPager ID="AspNetPager1" 
                   runat="server" PrevPageText="上一页" NextPageText="下一页" FirstPageText="首页"  
                LastPageText="尾页" OnPageChanging="AspNetPager1_PageChanging" ></webdiyer:AspNetPager>
            
        </div>
    

    </asp:Content>