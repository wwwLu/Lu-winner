<%@ Page Language="C#" MasterPageFile="~/AllMaster/IndexMaseter.Master" AutoEventWireup="true" CodeBehind="BookDetail.aspx.cs" Inherits="BookShop.WebUI.MemberPortal.BookDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <asp:DataList ID="dlBook" runat="server" OnItemCommand="dlBook_ItemCommand">
                <ItemTemplate>
                    <div style="float:left">
                            <asp:Image ID="ivBook" runat="server" ImageUrl='<%#Eval("ISBN","~/Images/BookCovers/{0}.jpg")%>' Width="200px"  Height="240px"/>
                        </div>
                    <div style="float:right">
                        <asp:Label ID="lblTitle" runat="server" Text='<%#Eval("Title") %>' />
                       <p>
                           <span>作者:</span>
                           <span><asp:Label ID="lblAuthor" runat="server" Text='<%#Eval("Author") %>' /></span>
                           <span>分类:</span>
                           <span><asp:Label ID="Label2" runat="server" Text='<%#Eval("Category") %>' /></span>
                       </p>
                        <p>
                            <span>出版社:</span>
                          <span><asp:Label ID="Label1" runat="server" Text='<%#Eval("Publisher") %>' /></span>
                            <span>ISBN:</span>
                          <span><asp:Label ID="Label3" runat="server" Text='<%#Eval("ISBN") %>' /></span>
                        </p>
                        <p>
                          <span>出版时间:</span>
                          <span><asp:Label ID="Label4" runat="server" Text='<%#Eval("PublishDate") %>' /></span>
                            <span>字数:</span>
                          <span><asp:Label ID="Label5" runat="server" Text='<%#Eval("WordsCount") %>' /></span>
                        </p>
                        <p>
                            <span>定价:</span>
                          <span><asp:Label ID="Label6" runat="server" Text='<%#Eval("UnitPrice") %>' /></span>
                        </p>
                        <p>
                            <asp:Button ID="btBuy" runat="server" Text= "购买图书" CommandArgument='<%#Eval("Id") %>' Font-Size="25px" BackColor="Green" />
                        </p>
                      </div>
                        <div style="clear:both">
                            <table>
                           <tr>
                              <td>
                                  <div>
                                      <hr />
                                      本书概要:<br />
                                      <asp:Label ID="label7" runat="server" Text='<%#Eval("ContentDescription") %>'></asp:Label>
                                 </div>
                             </td
                             </tr>
                          </table>
                            <div>
                                <hr />
                                作者简介: <br />
                                <asp:Label ID="label8" runat="server" Text='<%#Eval("AuthorDescription") %>'></asp:Label><br />
                            </div>
                            </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </asp:Content>