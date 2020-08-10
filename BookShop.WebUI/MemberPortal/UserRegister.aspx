<%@ Page Language="C#" MasterPageFile="~/AllMaster/IndexMaseter.Master" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="BookShop.WebUI.MemberPortal.UserRegister" %>

<%@ Register Assembly="Great.Control" Namespace="Great.Control" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <table>
           <tr>
               <td colspan="2">
                   <asp:ValidationSummary ID="ValidationSummary1" runat="server"  ForeColor="Red" ShowMessageBox="true"/>
               </td>
           </tr>
           <tr>
              <td>用户名</td>
              <td><asp:TextBox ID="txtLoginId" runat="server"></asp:TextBox>
                  <asp:Button ID="btnCheckLoginId" runat="server" Text="检查是否可用" OnClick="btnCheckLoginId_Click" CausesValidation="false" />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoginId" Text="*"  ForeColor="Red" />
              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtLoginId" ValidationExpression="[a-zA-Z][a-zA-Z0-9]{3,19}$" ErrorMessage="用户名必须以字母开头，包含4-20个字母数字下划线" ForeColor="Red" />
              </td>
           </tr>
          <tr>
              <td>真实姓名</td>
              <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="* " ForeColor="Red" />
              <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtName" ValidationExpression="~[\u4e00-\u9fa5]{2,4}$" ErrorMessage="2-3到中文" ForeColor="Red" />
              </td>
              </tr>
           <tr>
              <td>密码</td>
              <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword" ErrorMessage="* " ForeColor="Red" />
              <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPassword" ValidationExpression="[a-zA-Z0-9][a-zA-Z0-9]{5,19}$" ErrorMessage="用户名必须以字母数字开头，包含6-20个字母数字下划线" ForeColor="Red" />
              </td>
           </tr>
           <tr>
              <td>确认密码</td>
              <td><asp:TextBox ID="txtRePassword" runat="server" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtRePassword" ErrorMessage="* " ForeColor="Red" />
                  <asp:CompareValidator ID="CompareValidator1" runat="server"  ControlToValidate="txtRePassword" ControlToCompare="txtPassword" ErrorMessage="确认密码和密码必须一致" ForeColor="Red"/>
          </td>
           </tr>
           <tr>
               <td>性别</td>
               <td><asp:RadioButton ID="rbMale" runat="server" Text="男" Checked="true" GroupName="Sex" ></asp:RadioButton>
                   <asp:RadioButton ID="rbFeMale" runat="server" Text="女" GroupName="Sex" ></asp:RadioButton></td>
          </tr>
           <tr>
              <td>出生年月</td>
              <td><asp:TextBox ID="txtBirthday" runat="server" onfocus="WdatePicker({dateFmt: 'yyyy-MM-dd', minDate: '1960-1', maxDate: '2010-10' })"></asp:TextBox>
                  <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtBirthday" 
                      Type="Date" Operator="DataTypeCheck" ErrorMessage="出生年月格式不正确" ForeColor="Red" />
                  <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtBirthday" Type="Date" ErrorMessage="出生年月必须在当前日期前100-5年" ForeColor="Red" />
              </td>
          </tr>
          <tr>
             <td>学历</td>   
              <td><asp:DropDownList ID="ddlDegree" runat="server" >
                      <asp:ListItem Value="0" Selected= "True">==请输入学历==</asp:ListItem>
                      <asp:ListItem Value="1" Selected = "False">硕士</asp:ListItem>
                      <asp:ListItem Value="2" Selected = "False">本科</asp:ListItem>
                      <asp:ListItem Value="3" Selected = "False">大专</asp:ListItem>
                      <asp:ListItem Value="4" Selected = "False">博士</asp:ListItem>
                      <asp:ListItem Value="5" Selected = "False">高中</asp:ListItem>
                      <asp:ListItem Value="5" Selected = "False">初中</asp:ListItem>
                      <asp:ListItem Value="6" Selected = "False">初中</asp:ListItem>
                  </asp:DropDownList>
                  </td>
             </tr>
               <tr>
              <td>联系电话</td>
              <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="你的电话号码格式不正确" ControlToValidate="txtPhone" ForeColor="Red" ValidationExpression="(\(\d{4}\)|\d{4}-)?\d{8}"></asp:RegularExpressionValidator>
              </td>
           </tr>
               <tr>
              <td>Email</td>
              <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="邮件地址格式不正确" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail"></asp:RegularExpressionValidator>
                 </td>
                   </tr>
           <tr>
              <td>联系地址</td>
              <td><asp:TextBox ID="txtAddree" runat="server"></asp:TextBox></td>
              </tr>
           <tr>
          <td>个人描述</td>
           <td>
                  <asp:TextBox ID="txtDesciption" runat="server" TextMode="MultiLine" Rows="8" Columns="30" />
          </td>
          </tr>
           <tr>
               <td>从那里获知本站点</td>
               <td>
                 <asp:CheckBoxList ID="cblSource" runat="server">
                     <asp:ListItem Value="朋友推荐">朋友推荐</asp:ListItem>
                     <asp:ListItem Value="网络广告、媒体">网络广告、媒体</asp:ListItem>
                     <asp:ListItem Value="网上链接...">网上链接...</asp:ListItem>
                     <asp:ListItem Value="报纸、电视等媒体">报纸、电视等媒体</asp:ListItem>
                     <asp:ListItem Value="其他">其他</asp:ListItem>
               </asp:CheckBoxList>
                 </td>
               </tr>

           <tr>
               <td>验证码</td>
               <td>
                   <asp:TextBox ID="txtCheckCode" runat="server" />
                   <asp:CompareValidator ID="CompareValidator3" runat="server" Text="验证码输入错误" ForeColor="Red" ControlToValidate="txtCheckCode"  />
               </td>
           </tr>


               <tr>
                   <td>
                       <cc1:GreatValidateCode ID="GreatValidateCode1" runat="server" />
                   </td>
                   <td>
                       <asp:LinkButton ID="lbtnCreateCode" runat="server" Text="看不清...." OnClick="lbtnCreateCode_Click"  CausesValidation="false"/>
                   </td>
               </tr>

           <tr>

               <td colspan="2">
              <asp:Button ID="btnRegister" runat="server" Text="确认注册" OnClick="btnRegister_Click" />
               </td>
          </tr>
      </table>

        </asp:Content>