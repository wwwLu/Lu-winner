<%@ Page Title="" Language="C#" MasterPageFile="~/AllMaster/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AllBookList.aspx.cs" Inherits="BookShop.WebUI.AdminPortal.AllBookList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="float:left;width:200px">
           <asp:DataList ID="dlCategory" runat="server" OnItemCommand="dlCategory_ItemCommand">
                <ItemTemplate>
                    <asp:LinkButton ID="lbtnCategory" runat="server" Text='<%#Eval("Name") %>' CommandName="ShowBookList" 
                        CommandArgument='<%#Eval("Id") %>'/>
                </ItemTemplate>
            </asp:DataList>
        </div>

        <div style="float:left;width:800px;">
            <asp:DataList ID="dlBook" runat="server">
                <ItemTemplate>
                    <div style="float:left;width:120px;">
                        <asp:ImageButton ID="imgBookButton" runat="server" 
                            ImageUrl='<%#Eval("ISBN","~/Images/BookCovers/{0}.jpg")%>' 
                             Width="100px" Height="150px"/>
                    </div>
                    <div style="float:left;width:600px;">
                        <asp:LinkButton ID="lbtnCategory" runat="server" Text='<%#Eval("Title") %>' 
                        CommandName="ShowBookList" 
                        CommandArgument='<%#Eval("Id") %>'/>
                        <p><%#Eval("Author") %></p>
                        <p>出版日期:<%#Eval("PublishDate") %></p>
                        <p><%# Eval("ContentDescription").ToString().Length > 100 ? Eval("ContentDescription").ToString().Substring(100) : Eval("ContentDescription").ToString() %></p>
                        <p style="text-align:right">￥<%#Eval("UnitPrice","{0:F2}") %></p>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <webdiyer:AspNetPager ID="AspNetPager1" 
            runat="server" PrevPageText="上一页" NextPageText="下一页" FirstPageText="首页"  LastPageText="尾页" 
            OnPageChanging="AspNetPager1_PageChanging"></webdiyer:AspNetPager>
</div>
</asp:Content>
