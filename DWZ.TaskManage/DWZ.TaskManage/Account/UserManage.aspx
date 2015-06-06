<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManage.aspx.cs" Inherits="DWZ.TaskManage.Account.UserManage" %>


<form id="form1" runat="server" action="Account/AddUser.aspx" class="pageForm required-validate" onsubmit="return validateCallback(this)">
    <div id="umList">
        头上一片青天，心中一个信念。

        <a href="Account/Login.aspx?id=1213" rel="container" target="navTab">Click</a>
        <a href="Account/Login.aspx" target="dialog">Dialog</a>
        <a href="#" id="dialogByJs">Click2</a>

        <div class="tabs">
            <div class="tabsHeader">
                <div class="tabsHeaderContent">
                    <ul>
                        <li><a href="#" class="selected"><span>标题1</span></a></li>
                        <li><a href="#"><span>标题2</span></a></li>
                    </ul>
                </div>
            </div>
            <div class="tabsContent">
                <div>
                    <table class="list">
                        <tr>
                            <th>ID</th>
                            <th>UserName</th>
                            <th>Password</th>
                        </tr>

                        <% foreach (DWZ.Models.User user in GetUsers())
                           {
                        %>
                        <tr>
                            <td><%=user.Id %></td>
                            <td><%=user.UserName %></td>
                            <td><%=user.Password %></td>
                        </tr>
                        <%} %>
                    </table>
                </div>
                <div>
                    <div class="pageContent">
                        <div class="pageFormContent nowrap" layouth="97">

                            <dl>
                                <dt>用户名：</dt>
                                <dd>
                                    <input type="text" name="name" maxlength="20" class="required" />
                                    <span class="info">class="required"</span>
                                </dd>
                            </dl>
                            <dl>
                                <dt>密码：</dt>
                                <dd>
                                    <input id="w_validation_pwd" type="password" name="password" class="required alphanumeric" minlength="6" maxlength="20" alt="字母、数字、下划线 6-20位" />
                                    <span class="info">class="required alphanumeric" minlength="6" maxlength="20"</span>
                                </dd>
                            </dl>
                            <dl>
                                <dt>确认密码：</dt>
                                <dd>
                                    <input type="password" name="repassword" class="required" equalto="#w_validation_pwd" />
                                    <span class="info">class="required" equalto="#xxxId"</span>
                                </dd>
                            </dl>

                        </div>
                        <div class="formBar">
                            <ul>
                                <li>
                                    <div class="buttonActive">
                                        <div class="buttonContent">
                                            <button type="submit">提交</button>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="button">
                                        <div class="buttonContent">
                                            <button type="button" class="close">取消</button>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="tabsFooter">
                <div class="tabsFooterContent"></div>
            </div>
        </div>

    </div>
    <script type="text/javascript">
        $(function () {
            //alert($("#umList").html());
            $("#dialogByJs").click(function () {
                $.pdialog.open("Account/Login.aspx", "dialog1", "弹出窗口1", "{width:100px,height:100px,max:true,mask:true}");
            });
            //$.pdialog.open("Account/Login.aspx", "dialog1", "弹出窗口1", "{width:100px,height:100px,max:true,mask:true}");
        });
    </script>
</form>

