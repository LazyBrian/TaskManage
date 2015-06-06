
function showMenu(id) 
{ 
    if("" == id) 
    { 

        popMenu(id,155,"1111111"); 

    } 

    else 

    { 

        popMenu(id,155,"1111111"); 

    } 

    event.returnValue=false; 

       event.cancelBubble=true; 

       return false; 

} 
function popMenu(menuDiv,width,rowControlString) 

{ 

    //创建弹出菜单 

    var pop=window.createPopup(); 

    //设置弹出菜单的内容 

    pop.document.body.innerHTML=menuDiv.innerHTML; 

    

    var rowObjs=pop.document.body.all[0].rows; 

    //获得弹出菜单的行数 

    var rowCount=rowObjs.length; 

    //循环设置每行的属性 

    for(var i=0;i<rowObjs.length;i++) 

    { 

        //如果设置该行不显示，则行数减一 

        var hide=rowControlString.charAt(i)!='1'; 

        if(hide){ 

            rowCount--; 

        } 

        //设置是否显示该行 

        rowObjs[i].style.display=(hide)?"none":""; 

        //设置鼠标滑入该行时的效果 

        rowObjs[i].cells[0].onmouseover=function() 

        { 

            this.style.background="url(images/bgg2.jpg)"; 
            this.style.color="black"; 

        } 

        //设置鼠标滑出该行时的效果 

        rowObjs[i].cells[0].onmouseout=function(){ 

            this.style.background="url(images/bgg.jpg)"; 
            this.style.color="black"; 

        } 

    } 

    //屏蔽菜单的菜单 

    pop.document.oncontextmenu=function() 

    { 

            return false; 

    } 

    //选择右键菜单的一项后，菜单隐藏 

    pop.document.onclick=function() 

    { 

            pop.hide(); 

    } 

    //显示菜单 

    pop.show(event.clientX-1,event.clientY,width,rowCount*23,document.body); 

    return true; 

} 


function smoveArc(gid) 
{
document.getElementById("tanchu").href='kyxt/zongdan.asp?ckstr='+gid;
document.getElementById("tanchu").rel='zd_'+gid;	
document.getElementById("tanchu").click();
}
function huishou(gid) 
{
document.getElementById("huishou").href='kyxt/order/huishou.asp?ids='+gid;
document.getElementById("huishou").click();
}
function huanyuan(gid) 
{
document.getElementById("huanyuan").href='kyxt/order/huanyuan.asp?ids='+gid;
document.getElementById("huanyuan").click();
}
function huanyuan(gid) 
{
document.getElementById("huanyuan").href='kyxt/order/huanyuan.asp?ids='+gid;
document.getElementById("huanyuan").click();
}
function tszc(gid) 
{
document.getElementById("ts_zc").href='kyxt/order/ts_zc.asp?ids='+gid;
document.getElementById("ts_zc").click();
}
function tsyc(gid) 
{
document.getElementById("ts_yc").href='kyxt/order/ts_yc.asp?ids='+gid;
document.getElementById("ts_yc").click();
}
function xgkfd(gid) 
{
document.getElementById("xgkf").href='kyxt/order/xgkf.asp?ids='+gid;
document.getElementById("xgkf").rel='xgkf_'+gid;
document.getElementById("xgkf").click();
}
function hideDiv() { 
if (document.getElementById) { // DOM3 = IE5, NS6 
document.getElementById('hideshow').style.display = 'none'; 
}
else {
if (document.layers) { // Netscape 4
document.hideshow.display = 'none';
}
else { // IE 4 
document.all.hideshow.style.display = 'none'; 
}}}
function showDiv() { 
if (document.getElementById) { // DOM3 = IE5, NS6
document.getElementById('hideshow').style.display = 'block';
}
else {
if (document.layers) { // Netscape 4
document.hideshow.display = 'block';
}
else { // IE 4
document.all.hideshow.style.display = 'block';
}}}
var popup_dragging = false;
var popup_target;
var popup_mouseX;
var popup_mouseY;
var popup_mouseposX;
var popup_mouseposY;
var popup_oldfunction;
function popup_display(x)
{
  var win = window.open();
  for (var i in x) win.document.write(i+' = '+x[i]+'<br>');
}
function popup_mousedown(e)
{
  var ie = navigator.appName == "Microsoft Internet Explorer";
  if ( ie  &&  window.event.button != 1) return;
  if (!ie  &&  e.button            != 0) return;
  popup_dragging = true;
  popup_target   = this['target'];
  popup_mouseX   = ie ? window.event.clientX : e.clientX;
  popup_mouseY   = ie ? window.event.clientY : e.clientY;
  if (ie)
       popup_oldfunction = document.onselectstart;
  else popup_oldfunction  = document.onmousedown;
  if (ie)
       document.onselectstart = new Function("return false;");
  else document.onmousedown   = new Function("return false;");
}
function popup_mousemove(e)
{
  if (!popup_dragging) return;
  var ie      = navigator.appName == "Microsoft Internet Explorer";
  var element = document.getElementById(popup_target);
  var mouseX = ie ? window.event.clientX : e.clientX;
  var mouseY = ie ? window.event.clientY : e.clientY;
  element.style.left = (element.offsetLeft+mouseX-popup_mouseX)+'px';
  element.style.top  = (element.offsetTop +mouseY-popup_mouseY)+'px';
  popup_mouseX = ie ? window.event.clientX : e.clientX;
  popup_mouseY = ie ? window.event.clientY : e.clientY;
}

function popup_mouseup(e)
{
  if (!popup_dragging) return;
  popup_dragging = false;
  var ie = navigator.appName == "Microsoft Internet Explorer";
  var element = document.getElementById(popup_target);
  if (ie)
       document.onselectstart = popup_oldfunction;
  else document.onmousedown   = popup_oldfunction;
}
function popup_exit(e)
{
  var ie = navigator.appName == "Microsoft Internet Explorer";
  var element = document.getElementById(popup_target);
  popup_mouseup(e);
  element.style.visibility = 'hidden';
  element.style.display    = 'none';
}
function popup_show(ghd)
{
  element      = document.getElementById('popup');
  drag_element = document.getElementById('popup_drag');
  exit_element = document.getElementById('popup_exit');
  element.style.position   = "absolute";
  element.style.visibility = "visible";
  element.style.display    = "block";
    element.style.left = (document.documentElement.scrollLeft+popup_mouseposX-10)+'px';
    element.style.top  = (document.documentElement.scrollTop +popup_mouseposY-10)+'px';
  drag_element['target']   = 'popup';
  drag_element.onmousedown = popup_mousedown;
  exit_element.onclick     = popup_exit;
  document.getElementById("move4").value=ghd
}
function popup_mousepos(e)
{
  var ie = navigator.appName == "Microsoft Internet Explorer";
  popup_mouseposX = ie ? window.event.clientX : e.clientX;
  popup_mouseposY = ie ? window.event.clientY : e.clientY;
}
if (navigator.appName == "Microsoft Internet Explorer")
     document.attachEvent('onmousedown', popup_mousepos);
else document.addEventListener('mousedown', popup_mousepos, false);
if (navigator.appName == "Microsoft Internet Explorer")
     document.attachEvent('onmousemove', popup_mousemove);
else document.addEventListener('mousemove', popup_mousemove, false);
if (navigator.appName == "Microsoft Internet Explorer")
     document.attachEvent('onmouseup', popup_mouseup);
else document.addEventListener('mouseup', popup_mouseup, false);
