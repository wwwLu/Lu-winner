
	var ss = '<!--头部 B-->\
	<div id="top">\
    <div class="toplogo"><a href="index.html"><img src="images/logo.gif"></a></div>\
    <div class="topbanner"><a href="index.html" class="m_left">首页</a><a href="shopping.html" class="m_con">我的当当</a><a href="productlist.html" class="m_right">图书分类</a></div>\
    <div class="topnav"><img src="images/top-gwc.gif"> <a href="shopping.html" class="a1">购物车</a> | <a href="help.html" class="a1">帮助中心</a> | <a href="login.html" class="a1">我的帐户</a> | <a href="register.html" class="a1">新用户注册</a> | <a href="login.html" class="a1">登录</a></div>\
  </div>\
  <!--导航 B-->\
  <div id="h_banner"> \
    <!--菜单B-->\
    <div class="h_banner_top"> <span class="rim_l"></span> <span class="rim_c">图书分类： <a href="#" target="_blank">程序设计</a><span>|</span><a href="#" target="_blank">Web开发</a><span>|</span><a href="#" target="_blank">数据库管理</a><span>|</span><a href="#" target="_blank">*nux入门学习</a><span>|</span>热门分类： <a href="#" target="_blank">C#</a><span>|</span><a href="#" target="_blank">ASP.NET</a><span>|</span><a href="#" target="_blank">SQL Server</a><span>|</span><a href="#" target="_blank">PHP</a><span>|</span>其它分类： <a href="#" target="_blank">C#</a><span>|</span><a href="#" target="_blank">ASP.NET</a><span>|</span><a href="#" target="_blank">SQL Server</a></span> <span class="rim_r"></span> </div>\
    <!--搜索B-->\
    <div class="h_banner_foot">\
	<form action="?" name="searchform" method="get">\
        <select name="type"><option value="0" >当当分类</option><option value="1" selected>当当图书</option></select>\
        <input type="text" value="请输入您要查询的关键词" maxlength="50" name="key" ID="key_S" autocomplete="off" class="search_input" onfocus="if(this.value!=\'请输入您要查询的关键词\'){this.style.color=\'#404040\'}else{this.value=\'\';this.style.color=\'#404040\'}" onblur="if(this.value==\'\'){this.value=\'请输入您要查询的关键词\';this.style.color=\'#b6b7b9\'}" onkeydown="this.style.color=\'#404040\'" />\
        <a href="javascript:document.getElementById(\'search_btn\').click()" class="h_btn">搜 索</a>\
        <input type="submit" id="search_btn" style="display:none"/>\
      </form>\
      <div class="h_gbtn"><a href="#" target="_blank">高级搜索</a></div>\
      <div class="h_hbtn"><span>热门搜索：</span><a href="#" target="_blank">热搜1</a><a href="#" target="_blank">热搜2</a><a href="#" target="_blank">热搜3</a><a href="#" target="_blank">热搜4</a><a href="#" target="_blank">热搜5</a><a href="#" target="_blank">热搜6</a><a href="#" target="_blank">热搜7</a></div>\
    </div>\
  </div>';
document.write(ss);
