//统计博客开创日期
window.onload = function() {　　
	showtime();
}

function showtime() {
	var timedate = new Date("February 17,2015"); //自定义开始时间  February（二月） var born = new Date("July 21, 1983 01:15:00")
	　　
	var now = new Date(); //获取当前时间
	var now2 = now.getFullYear() + "/" + (now.getMonth() + 1) + "/" + now.getDate() + " " + now.getHours() + ":" + now.getMinutes() + ":" + now.getSeconds();
	var date = now.getTime() - timedate.getTime(); //得出的为毫秒
	　　
	var time = Math.ceil(date / (1000 * 60 * 60 * 24)); //1000 * 60 * 60 * 24一天的秒数
	if (time > 0) {
		document.getElementById('timeShow').innerHTML = time;
		document.getElementById('now2').innerHTML = now2;
		document.getElementById('nowyear').innerHTML = now.getFullYear();
		document.getElementById('nowmonth').innerHTML = (now.getMonth() + 1);
	}
	setTimeout(showtime, 500);
}