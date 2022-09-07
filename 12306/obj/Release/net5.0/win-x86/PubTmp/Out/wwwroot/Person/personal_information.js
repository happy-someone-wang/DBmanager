// JavaScript Document

// JavaScript Document

//获取邮箱地址         
var emailInp = document.getElementById('email');
//获取手机号码               
var mobileNoInp = document.getElementById('mobileNo');

//获取邮箱地址提示
var emailPrompt = document.getElementById('emailPrompt');
//获取手机号码提示
var phonePrompt = document.getElementById('phonePrompt');

//检查邮箱
function checkEmail() {
  //当点击输入框时，隐藏错误信息
  emailInp.onclick = function () {
    emailPrompt.style.display = 'none';
  }

  //当输入框失去焦点时，如有错误，则显示错误信息
  emailInp.onblur = function () {
    var email = emailInp.value; //获取用户输入的邮箱的值
    var exp = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/; //正则表达式
    if (!exp.test(email)) {
      emailPrompt.style.display = 'block';
    }
  }
}
checkEmail();

//检查手机号码
function checkMobileNo() {
  //当点击输入框时，隐藏错误信息
  mobileNoInp.onclick = function () {
    phonePrompt.style.display = 'none';
  }

  mobileNoInp.onblur = function () {
    var mobileNo = mobileNoInp.value; //获取用户输入的手机号码的值
    var exp = /^(13[0-9]|14[01456879]|15[0-35-9]|16[2567]|17[0-8]|18[0-9]|19[0-35-9])\d{8}$/; //正则表达式

    //当输入框失去焦点时，如有错误，则显示错误信息
    if (!mobileNo || !exp.test(mobileNo)) {
      phonePrompt.style.display = 'block';
    }
  }
}
checkMobileNo();

// 更改信息按钮
document.getElementById('bt1').addEventListener('click', changeInfo);

function changeInfo() {
  // 隐藏界面
  document.getElementById('relation_way_view').style.setProperty('display', 'none');
  document.getElementById('bt1').style.setProperty('display', 'none');
  // 展示界面
  document.getElementById('relation_way_change').style.setProperty('display', 'block');
}

// 取消按钮
document.getElementById('bt2').addEventListener('click', cancel);

function cancel() {
  // 隐藏界面
  document.getElementById('relation_way_change').style.setProperty('display', 'none');
  // 展示界面
  document.getElementById('relation_way_view').style.setProperty('display', 'block');
  document.getElementById('bt1').style.setProperty('display', 'block');
}

// 乘车人信息以及个人信息展示按钮

// 个人信息按钮
var personalInfoBtn = document.getElementById('box1_1_1');
// 乘车人信息按钮
var partnerInfoBtn = document.getElementById('box1_1_2');

// 个人信息
var personalInfo = document.getElementById('myInfo');
// 乘车人信息
var partnerInfo = document.getElementById('partnerInfo');

personalInfoBtn.addEventListener('click', showPersonal);
function showPersonal(){
	//更改按钮样式
	personalInfoBtn.className="box1_1_1";
	partnerInfoBtn.className="box1_1_2";
	//展示个人信息
	personalInfo.style.setProperty('display', 'block');
	partnerInfo.style.setProperty('display', 'none');
}

partnerInfoBtn.addEventListener('click', showPartner);
function showPartner(){
	//更改按钮样式
	personalInfoBtn.className="box1_1_2";
	partnerInfoBtn.className="box1_1_1";
	//展示个人信息
	personalInfo.style.setProperty('display', 'none');
	partnerInfo.style.setProperty('display', 'block');
}

// 删除乘车人按钮
function deletePartner(id){
	var partenerId="partner-"+id.substr(id.length - 1);
	document.getElementById(partenerId).remove();
}


    let oMenu = my$('nav');
    let oUL = getFirstElementChild(oMenu);
    // 获取 id
    function my$(id) {
        return document.getElementById(id);
    }
    // 获取第一个元素
    function getFirstElementChild(element) {
        let node;
        let nodes = element.childNodes;
        let i=0;
        //遍历返回元素节点，当元素节点为空时返回null
        while (node = nodes[i++]){
            if (node.nodeType === 1){
                return node;
            }
        }
        return null;
    }
    // 添加注册事件
    for (let i=0;i<oUL.children.length;i++){
        let oLi = oUL.children[i];
        oLi.onclick = LiClick;
    }
    function LiClick() {
        for (let i=0;i<oUL.children.length;i++){
            let oLi = oUL.children[i];
            oLi.className = 'nav-item';
        }
        this.className = 'current';
        return false;
    }

// 添加乘车人按钮
var addPartnerInfoBtn = document.getElementById('createPartner');
// 新乘车人信息
var addPartnerInfo = document.getElementById('addPartnerInfo');

// 添加乘车人按钮响应事件
function addPartener(){
	window.console.log("成功");
	addPartnerInfoBtn.style.setProperty('display', 'none');
	addPartnerInfo.style.setProperty('display', 'block');
}

// 取消添加乘车人按钮响应事件
function cancelAddPartener(){
	addPartnerInfoBtn.style.setProperty('display', 'block');
	addPartnerInfo.style.setProperty('display', 'none');
}

// 确认添加乘车人按钮响应事件（前后端相连）
function confirmAddPartener(){
	
}
