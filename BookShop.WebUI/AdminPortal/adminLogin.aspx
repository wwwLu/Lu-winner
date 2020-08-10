<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="BookShop.WebUI.MemberPortal.adminLogin" %>



<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312"  />
<title>�û���¼</title>
<link href="../images/login.css" rel="stylesheet" type="text/css" />
</head>
<body>

    <div id="login">
	
	     <div id="top">
		      <div id="top_left"><img src="../images/login_03.gif" /></div>
			  <div id="top_center"></div>
		 </div>
		 
		 <div id="center">
		      <div id="center_left"></div>
			  <div id="center_middle">
			       <div id="user">�� ��
					   <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
					   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage="*��Ϊ��*" ForeColor="Red">
					   </asp:RequiredFieldValidator>
			       </div> 
				   <div id="password">��   ��
					   <asp:TextBox ID="UserPWD" runat="server" TextMode="Password"></asp:TextBox>
					   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="UserPWD" ErrorMessage="*��Ϊ��*" ForeColor="Red">
					   </asp:RequiredFieldValidator>
				   </div>
				   <div id="btn">
					   <asp:LinkButton ID="DLbtn" runat="server" Text="��¼"></asp:LinkButton>
					   <asp:LinkButton ID="Qkbtn" runat="server" Text="���"></asp:LinkButton>
				   </div>
			  
			  </div>
			  <div id="center_right"></div>		 
		 </div>
		 <div id="down">
		      <div id="down_left">
			      <div id="inf">
                       <span class="inf_text">�汾��Ϣ</span>
					   <span class="copyright">������������̨����ϵͳ 2010 v1.0</span>
			      </div>
			  </div>
			  <div id="down_center"></div>		 
		 </div>

	</div>
</body>
</html>

        </div>
    </form>
</body>
</html>
