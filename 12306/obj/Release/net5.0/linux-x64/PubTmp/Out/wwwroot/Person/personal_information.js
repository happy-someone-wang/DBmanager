// JavaScript Document

//获取邮箱地址         
var emailInp = document.getElementById('email');           

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
