<body onkeydown="javascript:keyPress(event);" onkeyup="javascript:keyRelease(event);">
<div class="easyui-layout" data-options="fit:true,border:false">
	@*
  <div data-options="region:'north',split:true" style="text-align:right;padding:5px 0 0; height: 40px;">
	*@ @*
	<a href="javascript:void(0)" class="easyui-linkbutton" data-options=""
	id="">
	  个人空间
	</a>
	<a href="javascript:void(0)" class="easyui-linkbutton" data-options="" id="">单位空间 </a>
	*@ &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; @*
	<label id="Departmentcuser" style="font-size: 16px; font-family: 微软雅黑; font-weight: bold; color: Red">
	</label>
  </div>
  *@
	<div data-options="region:'center',split:true,border:false">
		<form method="post" id="form_XJXT">
			<table>
				<tr>
					<td width="600px">
						<label>
							<font color="red" size="3">
			  *
			</font>
							标&nbsp;&nbsp;题
						</label>
						<input type="text" value="" class="easyui-validatebox" name="SXBT" id="BT" style="width: 500px; height: 30px" />
					</td>
					<td style="width: 200px">日 期:

		 
	   <input type="text" name="ZDRQ" id="ZDRQXJXT" class="easyui-datebox" data-options="required:true" style="width: 90px;" />

					</td>
					<td>
						<label>
							重要度
						</label>
						<select name="ZYCD" id="ZYD">
							<option>一般
							</option>
							<option>重要
							</option>
							<option>非常重要
							</option>
						</select>
					</td>

					@*
		  <label>
			归档至
		  </label>
		  <input class="easyui-combotree" id="GDZ" name="GDZ" />
		  *@


					@*
		  <label>
			跟踪
		  </label>
		  <input type="radio" value="" />
		  *@


				</tr>
				<tr>
					<td>
						<label>
							<font color="red" size="3">
			  *
			</font>
							流&nbsp;&nbsp;程
						</label>
						<select name="LC" style="width: 500px;" onchange="newPerSon();" id="LC">
							<option selected>无
							</option>
							<option value="2">新建流程
							</option>
							<option>个人流程
							</option>
						</select>


					</td>
					<td style="width: 60px">
						<input type="hidden" name="RECEIVERlc" id="RECEIVERlc" class="easyui-validatebox" />
						<label id="LClab">
						</label>
					</td>
					<td>
						<input type="text" name="rylx1" id="rylx1" value="" readonly="readonly" />

					</td>
					<td>
						<label>
							项目
						</label>
						<select name="XMBM" id="XM">
							<option>1</option>
							<option>2</option>
							<option>3</option>
						</select>
					</td>
				</tr>
				<tr>
					<td>
						<label>
							&nbsp;附&nbsp;&nbsp;件
						</label>
						<input type="file" value="" multiple />
					</td>
				</tr>
				<tr>
					<td colspan="4">
						<script id="editorliucheng" type="text/plain" style="width: 95%; height: 350px;">
						</script>
					</td>
				</tr>
			</table>
		</form>
	</div>
	<div data-options="region:'south',border:false" style="height: 40px; padding-left: 5px; padding-top: 3px">
		<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-ok'" onclick="SaveFormXJXT()">发送
		</a>

	</div>
</div>
<!--选择用户窗口-->
<div id="Dlg_Userchoose" class="easyui-window" collapsible="false" minimizable="false"
	title="选择人员" maximizable="false" data-options="modal:true,closed:true,iconCls:'icon-save'"
	style="width: 900px; height: 600px; padding: 5px; background: #fafafa;">
	<div class="easyui-layout" data-options="fit:true,border:false" style="width: 900px; height: 600px;">
		<div data-options="region:'north',split:true" style="height: 40px; padding-left: 5px; padding-top: 3px">
			<a href="javascript:void(0)" class="easyui-linkbutton" data-options=""
				id="">岗位
			</a>
			<a href="javascript:void(0)" class="easyui-linkbutton" data-options=""
				id="">部门
			</a>
			&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
	  <label id="Departmentuser" style="font-size: 16px; font-family: 微软雅黑; font-weight: bold; color: Red">
	  </label>
		</div>
		<div data-options="region:'center',border:false" class="easyui-layout"
			style="width: 500px; height: 500px;">
			<div data-options="region:'north',split:true">
				<ul id="EasyTree_Department_cUser" class="easyui-tree" style="width: 400px; height: 200px;">
				</ul>
			</div>
			<div data-options="region:'center',split:true, border:false" style="width: 400px; height: 200px;">
				<table id="EasyGrid_cUser">
				</table>
			</div>
		</div>
		<div data-options="region:'east',split:true" style="width: 300px; height: 500px;">
			<div style="float: left; width: 30px; padding: 200px 0 0;">
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<img onclick="addcuser();" src="~/img/xiaojiantou.png" />
		<img onclick="dbdel();" src="~/img/xiaojiantouz.png" />
			</div>
			<br />
			<div style="float: left; height: 450px; width: 220px; padding: 0;">
				<form name="myform">
					<span style="position: absolute; border: 0px solid #000000">
						<select id="Select1" name="toList" onchange="delfir(this.selectedIndex)" ondblclick="dbdel()" size="100" style="height: 400px; width: 220px; border: 0px" multiple>
						</select>
					</span>
				</form>
			</div>
			<div style="float: right; width: 30px; padding: 185px 0 0;">
				&nbsp;&nbsp;
		<img onclick="UpOrDown(-1,'Select1')" src="~/img/xiaojiantous.png" style="cursor: pointer" />
				<img onclick="UpOrDown(1,'Select1')" src="~/img/xiaojiantoux.png" style="cursor: pointer" />
			</div>
		</div>
		<div data-options="region:'south',border:false" style="textalign: right; padding: 5px 0 0;">
			<input type="radio" name="rylx" id="cf" value="串发" />
			<label for="cf">
				串发
			</label>
			<input type="radio" name="rylx" value="并发" id="bf" />
			<label for="bf">
				并发
			</label>
			&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
	  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
	  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
	
	  <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-ok'"
		  onclick="savecUser()">保存
	  </a>
			<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-cancel'"
				onclick="closecUser()">取消
			</a>
		</div>
	</div>
</div>
<script type="text/javascript">

	
	
	//实例化编辑器
	var ue = UE.getEditor('editorliucheng');




	//-------------------------------------------------------------------------------  
	// 当然页面文件中还需要引入的文件如下：  
	// easyui.css 和其它页面用到的CSS文件  
	// jquery-1-8-3-min.js, easyui-lang-zh_CN.js, jquery-easyui-min.js, datagrid-detailview.js,  和其它页面用到的JS文件  
	//-------------------------------------------------------------------------------  
	//     结合SHIFT,CTRL,ALT键实现单选或多选  
	//-------------------------------------------------------------------------------  
	var KEY = { SHIFT: 16, CTRL: 17, ALT: 18, DOWN: 40, RIGHT: 39, UP: 38, LEFT: 37 };
	var selectIndexs = { firstSelectRowIndex: 0, lastSelectRowIndex: 0 };
	var inputFlags = { isShiftDown: false, isCtrlDown: false, isAltDown: false }

	function keyPress(event) {//响应键盘按下事件  
	   
	    var e = event || window.event;
	    var code = e.keyCode | e.which | e.charCode;
	    switch (code) {
	        case KEY.SHIFT:
	            inputFlags.isShiftDown = true;
	            $('#EasyGrid_cUser').datagrid('options').singleSelect = false;
	            break;
	        case KEY.CTRL:
	            inputFlags.isCtrlDown = true;
	            $('#EasyGrid_cUser').datagrid('options').singleSelect = false;
	            break;
	            /* 
                case KEY.ALT:    
                    inputFlags.isAltDown = true; 
                    $('#dataListTable').datagrid('options').singleSelect = false;            
                    break; 
                */
	        default:
	    }
	}

	function keyRelease(event) { //响应键盘按键放开的事件  
	    var e = event || window.event;
	    var code = e.keyCode | e.which | e.charCode;
	    switch (code) {
	        case KEY.SHIFT:
	            inputFlags.isShiftDown = false;
	            selectIndexs.firstSelectRowIndex = 0;
	            $('#EasyGrid_cUser').datagrid('options').singleSelect = true;
	            break;
	        case KEY.CTRL:
	            inputFlags.isCtrlDown = false;
	            selectIndexs.firstSelectRowIndex = 0;
	            $('#EasyGrid_cUser').datagrid('options').singleSelect = true;
	            break;
	            /* 
                case KEY.ALT:    
                    inputFlags.isAltDown = false; 
                    selectIndexs.firstSelectRowIndex = 0; 
                    $('#dataListTable').datagrid('options').singleSelect = true;             
                    break; 
                */
	        default:
	    }
	}



    //选择流程事件
    
	function newPerSon() {
		var currSelectIndex = document.all.LC.selectedIndex;
		//如果选择的是新建流程
		if (currSelectIndex == 1) {
			//清除已经选择人员
			$("#LClab").text("");
			//打开选择人员窗口
			$('#Dlg_Userchoose').window('open');
			getDataByAjax_cDepartment();
			//加载数据
			$("#EasyTree_Department_cUser").tree({
				cascadeCheck: false,
				animate: true,
				lines: true,
				onClick: function (node) {

					$('#Departmentuser').text(node.id + "-" + node.text);
					cshowUserByDepCode(node.id);
					if (node.id != "00") {
						if (node.state == "closed") {
							$('#EasyTree_Department_cUser').tree('expand', node.target);
						} else {
							$('#EasyTree_Department_cUser').tree('collapse', node.target);
						}
					}
				}
			});

			$('#EasyGrid_cUser').datagrid({
				//title: '用户管理',
				//iconCls: 'icon-save',
				// width: document.body.clientWidth - 410,
				singleSelect: true,
				height: "100%",
				rownumbers: true,
				fitColumns: false,
				onDblClickRow: selecs,
				onClickRow: function (index, row) {

				    //-------------for TEST 结合SHIFT,CTRL,ALT键实现单选或多选----------------      
				    if (index != selectIndexs.firstSelectRowIndex && !inputFlags.isShiftDown) {
				        selectIndexs.firstSelectRowIndex = index; 

				    }
				    if (inputFlags.isShiftDown) {
				        $('#EasyGrid_cUser').datagrid('clearSelections');
				        selectIndexs.lastSelectRowIndex = index;
				        var tempIndex = 0;
				        if (selectIndexs.firstSelectRowIndex > selectIndexs.lastSelectRowIndex) {
				            tempIndex = selectIndexs.firstSelectRowIndex;
				            selectIndexs.firstSelectRowIndex = selectIndexs.lastSelectRowIndex;
				            selectIndexs.lastSelectRowIndex = tempIndex;
				        }
				        for (var i = selectIndexs.firstSelectRowIndex ; i <= selectIndexs.lastSelectRowIndex ; i++) {
				            $('#EasyGrid_cUser').datagrid('selectRow', i);
				        }
				    }
				    //-------------for TEST 结合SHIFT,CTRL,ALT键实现单选或多选----------------  
				},
				striped: true,
				frozenColumns: [[
            { field: 'ck', checkbox: true },
            //{title:'cel02',field:'code',width:80,sortable:true}  
				]],
				columns: [[
					  { field: 'USERID', title: '登录名', width: 100 },
				{
					field: 'USERNAME',
					title: '姓名',
					width: 100
				}
				]],
			    onLoadSuccess:function(data){     
			        $('#EasyGrid_cUser').datagrid('clearSelections');
			}
			})

			getDataByAjax_cUser("");

		}

	}

	//selected上下移动
	function UpOrDown(direct, selectId) {//direct : 1:Up, -1:Down
		var obj = document.getElementById(selectId);
		var len = obj.length;
		var index = obj.selectedIndex;

		//如果：1.没有选中的项; 2.向上，但已是最上; 3.向下，但是最下，不作处理
		if ((index == -1) || (direct == -1 && index == 0) || (direct == 1 && index >= len - 1))
			return;

		var swapIndex = index + direct;
		var tempOptions = new Array();
		for (var i = 0; i < len; i++) {
			tempOptions[tempOptions.length] = obj.options[i == index ? swapIndex : (i == swapIndex ? index : i)];
		}
		obj.options.length = 0;
		for (var i = 0; i < len; i++)
			obj.options.add(tempOptions[i]);
	}

	//关闭Form
	function closecUser() {
	    $("#Select1").empty();
		$('#Dlg_Userchoose').window('close');
	}
	// 获取人员数据
	function getDataByAjax_cUser(pDeptCode) {

		// showProcess(true, '温馨提示', '数据加载中...');
		var randomNu = (new Date().getTime()) ^ Math.random();
		$.ajax({
			url: '/User/InitUser/' + pDeptCode + "?_=" + randomNu,
			cache: false,
			dataType: "json",
			success: function (data) {
				$('#EasyGrid_cUser').datagrid('loadData', data);
				//   showProcess(false);
			}
		})
	}
	//获取部门数据
	function getDataByAjax_cDepartment() {

		showProcess(true, '温馨提示', '数据加载中...');

		var randomNu = (new Date().getTime()) ^ Math.random();
		$.ajax({
			url: '/Person/InitTree/' + "?_=" + randomNu,
			cache: false,
			dataType: "json",
			success: function (data) {
				$('#EasyTree_Department_cUser').tree('loadData', data);
				//      $('#DEPCODE').combotree('loadData', data);
				showProcess(false);
			}
		})
	}
	//通过部门选人
	function cshowUserByDepCode(pDepCode) {
		if (pDepCode == "00") {
			getDataByAjax_cUser("");
		} else {
			getDataByAjax_cUser(pDepCode);
		}
	}

    //单击选择人员(ctrl + 多选)
    //添加人员到流程
	function addcuser() {
	    var flag = true;
	    var selectObj = document.getElementById("Select1");
	    var checkedItems = $('#EasyGrid_cUser').datagrid('getChecked');
	    //如果选中的人为空
	   
	    if (checkedItems.length==0) {
	        $.messager.alert('系统提示', '请选择要编辑的记录1！', 'warning');
	    }
       //如果选中的人不为空
	    else {
	        $.each(checkedItems, function (index, item) {
	            //循环判断重复
	            for (var j = 0; j < selectObj.length; j++) {
	                if (item.USERID == selectObj.options[j].value) {
	                    alert(item.USERNAME + "不能重复选择");
	                    flag = false;
	                    $('#EasyGrid_cUser').datagrid('clearSelections');
	                    return;
	                }
	            }
	        });
	        if (flag) {
	            //循环添加多选的人员到右侧区域
	            $.each(checkedItems, function (index, item) {
	                var selectObj = document.getElementById("Select1");
	                selectObj.options[selectObj.length] = new Option(item.USERNAME, item.USERID);

	            });
	            $('#EasyGrid_cUser').datagrid('clearSelections');
	        }
	       
	    }
	}

	
	//双击选择人员
	function selecs() {
	    var selectObj = document.getElementById("Select1");
		var selected = $('#EasyGrid_cUser').datagrid('getSelected');
		for (var j = 0; j < selectObj.length; j++) {
		   
		    if (selected.USERID == selectObj.options[j].value) {
		        alert(selected.USERNAME + "不能重复选择");
		        $('#EasyGrid_cUser').datagrid('clearSelections');
		        return;

		    }
		}
		if (selected) {

			var selectObj = document.getElementById("Select1");

			selectObj.options[selectObj.length] = new Option(selected.USERNAME, selected.USERID);


		} else {
			$.messager.alert('系统提示', '请选择要编辑的记录1！', 'warning');
		}
	}

	//删除选择用户
	
	function dbdel() {
		var objSelect = document.getElementById("Select1");
		var length = objSelect.length;
		for (var i = length - 1; i > -1; i--) {

		    var o = objSelect.options[i];

		    if (o.selected == true) {

		        objSelect.remove(i)

		    }

		}
		//objSelect.remove(objSelect.selectedIndex);

	}
	
	// 保存选择用户
	function savecUser() {
		var selectObj = document.getElementById("Select1");
		var rylx = $("input[name='rylx']:checked").val();
		
		if (rylx == "" || rylx == undefined || rylx == null) {
		    alert("请选择发起方式");
		}
		else {
            //发起方式
		    $("#rylx1").val(rylx);


		    var textu = "";

		    for (var i = 0; i < selectObj.length; i++) {
		        if (i < selectObj.length - 1) {
		            textu = textu + selectObj.options[i].value + "，";
		        }

		        else {
		            textu = textu + selectObj.options[i].value;
		        }

		    }
            //接受者
		    $("#LClab").text(textu);
		    $("#RECEIVERlc").val(textu);
		    $("#Select1").empty(); 
		    $('#Dlg_Userchoose').window('close');
          
		}
		
	}
  
	/*编辑参数开始*/

	function SaveFormXJXT() {

		var SXBT = $("input[name=SXBT]").val();

		if (SXBT == "") {
			alert("请输入标题！");
			return;
		}
		var ZDRQ = $("input[name=ZDRQ]").val();

		if (ZDRQ == "") {
			alert("请选择时间！");
			return;
		}
		var RECEIVERlc = $("input[name=RECEIVERlc]").val();

		if (RECEIVERlc == "") {
			alert("请选择流程！");
			return;
		}
		var rylx1 = $("input[name=rylx1]").val();

		if (rylx1 == "") {
			alert("请选择人员发送关系！");
			return;
		}
		var ZYCD = $("input[name=ZYCD]").val();

		if (ZYCD == "") {
			alert("请选择重要度！");
			return;
		}

		//ckeditor内容进行编码
		//var myEditor = CKEDITOR.instances.CONTENT8901
		//myEditor.setData(CKEDITOR.tools.htmlEncode(myEditor.getData()));
		//myEditor.setData(HtmlEncode(myEditor.getData()));
		//  var randomNu = (new Date().getTime()) ^ Math.random();
		showProcess(true, '温馨提示', '正在提交数据...');
		$('#form_XJXT').form('submit', {
			//  url: $('#form8901').form.url + "?_=" + randomNu,
			url: '/XJXT/FAQI/',
			onSubmit: function () {
				showProcess(false);

			},
			data: $("#form_XJXT").serialize(),
			success: function (pdata) {
				showProcess(false);
				if (pdata == "1") {
					$.messager.alert('系统提示', '操作成功', 'info');
					// getDataByAjax8901(1);
					// $('#grd8901').datagrid('loadData', eval("(" + pdata + ")"));
					window.location.href = "/main/index";
				}
				else {
					//保存出错
					$.messager.alert('系统提示', pdata, 'info');

				}

			}
		})

	}
	//进度条
	function showProcess(isShow, title, msg) {
		if (!isShow) {
			$.messager.progress('close');
			return;
		}
		var win = $.messager.progress({
			title: title,
			msg: msg
		});
	}

</script>
    </body>