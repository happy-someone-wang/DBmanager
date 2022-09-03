// 旧密码
var oldPassWord = document.getElementById('oldPassword');
// 新密码
var newPassWord = document.getElementById('newPassword');
// 确认密码
var confirmPassWord = document.getElementById('confirmPassWord');
// 取消和确认按钮
var btn = document.getElementById("input-button");
// 输入错误提示
var prompt = document.getElementById("input-error");
// 取消按钮
var btn1 = document.getElementById('cancel-btn');
// 确认按钮
var btn2 = document.getElementById('certain-btn');

//密码危险
var rankA = document.getElementById('weak');
//密码一般
var rankB = document.getElementById('medium');
//密码安全
var rankC = document.getElementById('strength');

//新密码提示
var newPasswordPrompt = document.getElementById('newPasswordPrompt');
//确认密码提示
var newPasswordConfirm = document.getElementById('newPasswordConfirm');

// 设置密码低强度
function passwordWeak() {
  rankA.style.background = '#82FF85';
  rankB.style.background = '#FFCE9C';
  rankC.style.background = '#FFCE9C';
}

// 设置密码中等强度
function passwordMedium() {
  rankA.style.background = '#82FF85';
  rankB.style.background = '#82FF85';
  rankC.style.background = '#FFCE9C';
}

// 设置密码高强度
function passwordStrength() {
  rankA.style.background = '#82FF85';
  rankB.style.background = '#82FF85';
  rankC.style.background = '#82FF85';
}

// 显示密码长度不足的错误信息
function noEnoughLength() {
  newPasswordPrompt.style.display = 'block';
  newPasswordPrompt.innerText = "密码长度不能少于6个字符！";
  newPasswordPrompt.style.color = '#FF0000';
}

// 显示密码为空的错误信息
function noAnyChar() {
  newPasswordPrompt.style.display = 'block';
  newPasswordPrompt.innerText = "请输入密码！";
  newPasswordPrompt.style.color = '#FF0000';
}

// 显示密码格式的错误信息
function errorForm() {
  newPasswordPrompt.style.display = 'block';
  newPasswordPrompt.innerText = "格式错误，必须且只能包含字母，数字，下划线中的两种或两种以上！";
  newPasswordPrompt.style.color = '#FF0000';
}

// 显示确认密码为空的错误信息
function confirmPassWordNone() {
  newPasswordConfirm.style.display = 'block';
  newPasswordConfirm.innerText = "请输入确认密码！";
  newPasswordConfirm.style.color = '#FF0004';
}

// 显示确认密码与新密码不一致的错误信息
function confirmPassWordWrongErr() {
  newPasswordConfirm.style.display = 'block';
  newPasswordConfirm.innerText = "确认密码与新密码不同！";
  newPasswordConfirm.style.color = '#FF0004';
}

// 恢复新密码与确认密码的正常提示
function recoverPrompt() {
  newPasswordPrompt.style.display = 'block';
  newPasswordConfirm.style.display = 'block';
  newPasswordPrompt.innerText = "需包含字母、数字、下划线中不少于两种且长度不少于6。";
  newPasswordPrompt.style.color = '#999';
  newPasswordConfirm.innerText = "请再次输入密码。";
  newPasswordConfirm.style.color = '#999';
}

//检查新密码
function checkPassWord() {
  var exp = /^[\w]{5,19}$/; //正则表达式：6-20位字母、数字或“_”,字母开头
  passwordWeak();

  // 点击输入框时
  newPassWord.onclick = function () {
    newPasswordPrompt.style.display = 'none';
  }

  //当按键时，隐藏错误信息，实时监测密码强度并显示
  newPassWord.onkeyup = function () {
    var passWord = newPassWord.value; //获取用户输入的新密码的值
    if (!passWord) {
      passwordWeak();
    }
    var flag = true;
    if (!passWord || passWord.length < 6 || !exp.test(passWord)) {
      flag = false;
    }
    if (flag) {
      if ((/[\d]/.test(passWord) && /[\a-zA-Z]/.test(passWord) && !/[\_]/.test(passWord)) || (/[a-zA-Z]/.test(passWord) && /[\_]/.test(passWord) && !/[\d]/.test(passWord)) || (/[_]/.test(passWord) && /[\a-zA-Z]/.test(passWord) && !/[\d]/.test(passWord))) {
        passwordMedium();
      } else if (/[\d]/.test(passWord) && /[\a-zA-Z]/.test(passWord) && /[\_]/.test(passWord)) {
        passwordStrength();
      }
    }
  }

  //当输入框失去焦点时，如有错误，则显示错误信息
  newPassWord.onblur = function () {
    var passWord = newPassWord.value;
    if (!passWord) {
      noAnyChar();
    } else if (passWord.length < 6) {
      noEnoughLength();
    } else if (!exp.test(passWord)) {
      errorForm();
    }
    var confirmPassWordValue = confirmPassWord.value; //获取用户输入的确认密码的值
    if (confirmPassWordValue && confirmPassWordValue != passWord) {
      confirmPassWordWrongErr();
    }
  }
}
checkPassWord();

//检查确认密码
function checkConfirmPassWord() {

  //点击输入框时
  confirmPassWord.onclick = function () {
    newPasswordConfirm.style.display = 'none';
  }

  //当输入框失去焦点时，如有错误，则显示错误信息
  confirmPassWord.onblur = function () {
    // 获取确认密码输入框中的值
    var confirmPassWordValue = confirmPassWord.value;
    // 检验值是否正确
    if (!confirmPassWordValue) {
      newPasswordConfirm.style.display = 'block';
      confirmPassWordNone();
    } else if (confirmPassWordValue != newPassWord.value) {
      newPasswordConfirm.style.display = 'block';
      confirmPassWordWrongErr();
    }
    window.console.log(confirmPassWordValue);
  }
}
checkConfirmPassWord();

// 取消按钮
btn1.addEventListener('click', cancel);

function cancel() {
  recoverPrompt();
  btn.style.setProperty('display', 'block');
  prompt.style.setProperty('display', 'none');
}

// 确认按钮
btn2.addEventListener('click', assure);

function assure() {
  // 检查输入的密码是否正确
  // 输入的密码错误
  btn.style.setProperty('display', 'none');
  prompt.style.setProperty('display', 'block');
  recoverPrompt();
  var inputValue = document.getElementsByClassName('input');
  for (var i = 0; i < inputValue.length; i++) {
    inputValue[i].value = "";
  }
  setTimeout(changePrompt, 3000);
}

// 取消密码错误提示
function changePrompt() {
  btn.style.setProperty('display', 'block');
  prompt.style.setProperty('display', 'none');
}
