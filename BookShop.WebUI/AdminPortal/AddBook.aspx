<%@ Page Language="C#"  MasterPageFile="~/AllMaster/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BookShop.WebUI.aminPortal.AddBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <table>
            <tr>
               <td>图书名称:</td>
               <td><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
             </tr>
            <tr>
               <td>作者:</td>
                <td><asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
               <td>图书所属分类:</td>
               <td><asp:DropDownList ID="PbId" runat="server" OnSelectedIndexChanged="PbId_SelectedIndexChanged" AutoPostBack="true"/></td>
               </tr>
                <tr>
                   <td>出版社:</td>
                   <td><asp:DropDownList ID="PublisherName" runat="server" AutoPostBack="true" OnSelectedIndexChanged="PublisherName_SelectedIndexChanged"/></td>
                   </tr>
                   <tr>
                       <td>ISBN:</td>
                       <td><asp:TextBox ID="TxtISBN" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                   <td>出版时间:</td>
                   <td><asp:TextBox ID="TxtTime" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                      <td>定价(元):</td>
                      <td><asp:TextBox ID="TxtUnitPrice" runat="server"></asp:TextBox></td>
                  </tr>
                  <tr>
                      <td>字数:</td>
                      <td><asp:TextBox ID="TxtWordsCount" runat="server"></asp:TextBox></td>
                  </tr>
                  <tr>
                  <td>上传封面:</td>
                  <td>
                      <asp:FileUpload ID="FileUpload1" runat="server"/>
                  </td>
             </tr>
            <tr>
               <td>内容提要:</td>
               <td><asp:TextBox ID="TxtContentDescription" runat="server" TextMode="MultiLine" Rows="8" Columns="25"></asp:TextBox></td>
          </tr>
        </table>
            <asp:Button ID="BtnOk"  runat="server" Text="添加" Width="80px" BackColor="Green" OnClick="BtnOk_Click"></asp:Button>
    	    </asp:Content>