<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BookShop.WebUI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="../css/global_dangdang.css" rel="stylesheet" type="text/css" />
<link href="../css/dd_index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

<div class="content">
  <link href="../css/headban.css" rel="stylesheet" type="text/css" />
 

    <!--头部 B-->
	<div id="top">
    <div class="toplogo"><a href="index.aspx"><img src="../images/logo.gif"/></a></div>
    <div class="topbanner"><a href="index.aspx" class="m_left">首页</a><a href="BookList.aspx" class="m_con">我的当当</a><a href="GetNewBookList.aspx" class="m_right">图书分类</a></div>
    <div class="topnav"><img src="../images/top-gwc.gif"/> <a href="ShopCart.aspx" class="a1">购物车</a> | <a href="help.html" class="a1">帮助中心</a> | <a href="UseLogin.aspx" class="a1">我的帐户</a> | <a href="UserRegister.aspx" class="a1">新用户注册</a> | <a href="UseLogin.aspx" class="a1">登录</a></div>
  </div>
  <!--导航 B-->
  <div id="h_banner"> 
    <!--菜单B-->
    <div class="h_banner_top"> <span class="rim_l"></span> <span class="rim_c">图书分类： <a href="#" target="_blank">程序设计</a><span>|</span><a href="#" target="_blank">Web开发</a><span>|</span><a href="#" target="_blank">数据库管理</a><span>|</span><a href="#" target="_blank">*nux入门学习</a><span>|</span>热门分类： <a href="#" target="_blank">C#</a><span>|</span><a href="#" target="_blank">ASP.NET</a><span>|</span><a href="#" target="_blank">SQL Server</a><span>|</span><a href="#" target="_blank">PHP</a><span>|</span>其它分类： <a href="#" target="_blank">C#</a><span>|</span><a href="#" target="_blank">ASP.NET</a><span>|</span><a href="#" target="_blank">SQL Server</a></span> <span class="rim_r"></span> </div>
    <!--搜索B-->
    <div class="h_banner_foot">
        <div action="?" name="searchform" method="get">
        <select name="type"><option value="0" >当当分类</option><option value="1" selected>当当图书</option></select>
        <input type="text" value="请输入您要查询的关键词" maxlength="50" name="key" ID="key_S" autocomplete="off" class="search_input" onfocus="if(this.value!=\'请输入您要查询的关键词\'){this.style.color=\'#404040\'}else{this.value=\'\';this.style.color=\'#404040\'}" onblur="if(this.value==\'\'){this.value=\'请输入您要查询的关键词\';this.style.color=\'#b6b7b9\'}" onkeydown="this.style.color=\'#404040\'" />
        <a href="javascript:document.getElementById(\'search_btn\').click()" class="h_btn">搜 索</a>
        <input type="submit" id="search_btn" style="display:none"/>
        </div>
      <div class="h_gbtn"><a href="#" target="_blank">高级搜索</a></div>
      <div class="h_hbtn"><span>热门搜索：</span><a href="#" target="_blank">热搜1</a><a href="#" target="_blank">热搜2</a><a href="#" target="_blank">热搜3</a><a href="#" target="_blank">热搜4</a><a href="#" target="_blank">热搜5</a><a href="#" target="_blank">热搜6</a><a href="#" target="_blank">热搜7</a></div>
    </div>
  </div>
  
  <!--内容 B-->
  <div class="book">
    <div class="book_left">
      <div class="gtit">
        <span class="gleft"></span>
        <span class="grig"></span>
        <h2 class="col_w129">图书</h2>
      </div>
      <div class="glist">
      	<ul>
        	<li class="lititle"><a href="productlist.html">新书推荐</a></li>
            

            <asp:Repeater ID="RpBookList" runat="server">
                                   <ItemTemplate>
                                       <li><a href="BookList.aspx?Cart=<%#Eval("Id") %>"><%#Eval("Name") %></a></li>                        
                                   </ItemTemplate>
                </asp:Repeater>
        </ul>
      </div>
      <span class="blank8"></span>
      <div class="gtit">
          <span class="gleft"></span>
          <span class="grig"></span>
          <h2 class="col_w129">品牌出版社</h2>
      </div>
      <div class="glist1">
      	<ul>
        	<asp:Repeater ID="rpPublisherList" runat="server">
                                   <ItemTemplate>
                                       <li><a href="BookList.aspx?Cart=<%#Eval("Id") %>"><%#Eval("Name") %></a></li>                        
                                   </ItemTemplate>
                </asp:Repeater>
        </ul>
      </div>
    </div>
    <div class="book_center"> 
      <!--顶-->
      <div class="book_cg">
        <h2><span class="more"><a href="#">详情&gt;&gt;</a></span><a href="#">主编推荐 最全的图书、最低的价格尽在当当网！</a></h2>
        <div class="bookc">
          <div class="bookc_left">
            <div class="book_pic"> <a href="#" target="_blank" title="#"><img src="../images/BookCovers/978711515888_new.jpg" border="0" /></a> </div>
          </div>
          <div class="bookc_rig">
            <h3><a href="#" target="_blank" title="#">Effective C# 中文版改善C#程序的50种方法</a> </h3>
            <p class="txtind txt">本书围绕一些关于C#和.NET的重要主题，包括C#语言元素、.NET资源管理、使用C#表达设计、创建二进制组件和使用框架等，讲述了最常见的50个问题的解决方案，为程序员提供了改善C#和.NET程序的方法。本书通过将每个条款构建在之前的条款之上，并合理地利用之前的条款，来让读者最大限度地学习书中的内容，为其在不同情况下使用最佳构造提供指导。　　本书适合各层次的C#程序员阅读，同时可以推荐给高校教师（尤其是软件学院教授C#/.NET课程的老师），作为C#双语教学的参考书<span class='dot'>...</span></p>
            <p><s>定价：￥49</s>　　折扣价：￥38　　折扣：75折</p>
          </div>
          <div class="clear"></div>
        </div>
      </div>
      <!--中-->
      <div class="book_cg">
        <h2><span class="more"><a href="#">更多&gt;&gt;</a></span><a href="#">本月新出版 最新最热图书全收录，最佳品质、最优价格！</a></h2>
        <div class="bookc wrapfix">
            <div class="centerulli">
                            
                             <asp:DataList ID ="dlNewBooks" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"  Height="448px" Width="600px" OnItemCommand="dlNewBooks_ItemCommand">
                                  <ItemTemplate>
                                    <div style="text-align:center ;width:150px ;height:290px">
                                    <div><asp:ImageButton CommandName="ShowBookDetails" CommandArgument='<%#Eval("Id") %>' ID="imgBook"  runat="server" ImageUrl='<%#Eval("ISBN","~/Images/BookCovers/{0}.jpg")%>' Width="120px" Height="200" /></div>
                                    <div><asp:LinkButton CommandName="ShowBookDetails" CommandArgument='<%#Eval("Id") %>' ID="lbltitle"  runat="server" Text='<%#Eval("title") %>' ></asp:LinkButton><br /></div>
                                    <div>定价：<asp:Label ID="lblUnitPrice" runat="server" Text='<%#Eval("UnitPrice") %> '></asp:Label>元</div>
                                    </div>
                                 </ItemTemplate>
                            </asp:DataList>
                        </div>
        </div>
      </div>
      <!--底-->
      <div class="book_cg">
        <h2><span class="more"><a href="#">详情&gt;&gt;</a></span><a href="#">本周媒体热点 最热图书，全场打折、天天特价！</a></h2>
        <div class="bookc">
          <div class="bookc_left">
            <div class="book_pic"> <a href="#" target="_blank" title="#"><img src="../images/BookCovers/9787115158284_new.jpg" border="0" /></a> </div>
          </div>
          <div class="bookc_rig">
            <h3><a href="#" target="_blank" title="#">Effective C# 中文版改善C#程序的50种方法</a> </h3>
            <p>作者：（美）米切尔<br />出版社：人民邮电出版社<br />出版日期：2007-5-1</p>
            <p><s>定价：￥49</s>　　折扣价：￥38　　折扣：75折</p>
            <p class="txt">媒体评论：<br>　　 ASP.NET 
					  2.0在1.0版的基础上做了很多改进，用它可以更容易地创建数据驱动的网站。本书通过简明的语言和详细的步骤，以循序渐进的方式帮助读者迅速掌握使用ASP.NET 
					  2.0开发网站所需的基本知识。<br>　　 全书共分5个部分，共24章。第一部分介绍了ASP.NET 
					  2.0及其编程模型，Visual Web...</p>
          </div>
          <div class="clear"></div>
        </div>
      </div>
    </div>
    <div class="book_right">
      <div class="gtit"> <span class="gleft"></span> <span class="grig"></span>
        <h2 class="col_w148">用户登录</h2>
      </div>
      <div class="glist p5" style="line-height:25px;">
      	Email地址或昵称：<br />
        <INPUT name="username" type="text" class="login-input"><br />
        密码：<br />
        <INPUT name="paw" type="password" class="login-input" ><br />
        <INPUT name="dl" type="submit" value="登 录" class="login-submit"><br />
        您还不是当当网用户？<br />
        <A href="register.html">创建一个新用户>></A>
      </div>
      <span class="blank8"></span>
      <div class="gtit"> <span class="gleft"></span> <span class="grig"></span>
        <h2 class="col_w148">点击排行榜 Top10</h2>
      </div>
      <div class="glist1">
      	<ul>
        	<li class="lititle"><a href="class.html">框架设计（第2版）</a></li><li><a href="class.html">ASP.NET 2.0中文版</a></li><li><a href="class.html">.NET</a></li><li><a href="class.html">ASP.NET中文版</a></li><li><a href="class.html">Basic VB VB Script中文版</a></li><li><a href="class.html">C C++ VC VC++中文版</a></li><li><a href="class.html">CSS Div中文版</a></li><li><a href="class.html">HTML XML中文版</a></li><li><a href="class.html">J2EE中文版</a></li><li><a href="class.html">Java Script Java中文版</a></li><li><a href="class.html">JSP中文版</a></li><li><a href="class.html">WINDOWS中文版</a></li><li><a href="class.html">电子商务中文版</a></li><li><a href="class.html">计算机中文版</a></li><li><a href="class.html">计算机理论中文版</a></li><li><a href="class.html">其他中文版</a></li><li><a href="class.html">网站开发中文版</a></li><li class="more"><a href="class.html">更多>></a></li>
        </ul>
      </div>
    </div>
    <div class="clear"></div>
  </div>
  
    <!--底部广告 B-->
  <div align="center"><img src="../images/index-end.jpg" vspace="10"></div>
  <!--底部 B-->
  <div align="center">Copyright <span><span>&copy;</span></span> 当当网 2004-2009, All Rights Reserved. Powered By GreatSoft Corp.&nbsp;&nbsp;<img src="../images/validate.gif" align="absmiddle">&nbsp;&nbsp; 苏<A href="http://www.miibeian.gov.cn"  target="_blank">ICP证041189号</A></div>
</div>
    </form>
</body>
</html>
