<%@ Page Language="C#"  MasterPageFile="~/AllMaster/IndexMaseter.Master" AutoEventWireup="true" CodeBehind="GetNewBookList.aspx.cs" Inherits="BookShop.WebUI.MemberPortal.GetNewBookList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:DataList ID="dlBookList" runat="server" RepeatDirection="Horizontal" RepeatColumns="4" Width="400px" OnItemCommand="dlBookList_ItemCommand">
                 <ItemTemplate>
                     <div>
                         <asp:ImageButton ID="imgBookButton" runat="server" ImageUrl='<%#Eval("ISBN","~/Images/BookCovers/{0}.jpg")%>' 
                             Width="100px" Height="150px"/>
                     </div>
                     <div>
                         <asp:LinkButton ID="lbtnBookDetail" runat="server" Text='<%#Eval("Title") %>' 
                             CommandName="ShowBookDetail" CommandArgument='<%#Eval("Id") %>'/>
                     </div>
                     <div>
                          定价:<asp:Label ID="lblPrice" runat="server" Text='<%#Eval("UnitPrice","{0:f}") %>' />
                     </div>
                    </ItemTemplate>
            </asp:DataList>
    </asp:Content>
