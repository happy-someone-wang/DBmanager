// JavaScript Document

var changeToUntrip=function() {
	// 切换导航栏
	document.getElementById("order_tab_1").classList.add("active");
	document.getElementById("order_tab_2").classList.remove("active");
	// 切换内容
	document.getElementById("untrip").style.setProperty('display','block');
	document.getElementById("history").style.setProperty('display','none');
}

var changeToHistory=function() {
	// 切换导航栏
	document.getElementById("order_tab_1").classList.remove("active");
	document.getElementById("order_tab_2").classList.add("active");
	// 切换内容
	document.getElementById("untrip").style.setProperty('display','none');
	document.getElementById("history").style.setProperty('display','block');
}

document.getElementById("order_tab_1").addEventListener("click",changeToUntrip);
document.getElementById("order_tab_2").addEventListener("click",changeToHistory);

function ac(){
	document.querySelector('.alert').classList.toggle('active')
}