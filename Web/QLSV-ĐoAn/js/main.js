const inputs = document.querySelectorAll(".input");


function addcl(){
	let parent = this.parentNode.parentNode;
	parent.classList.add("focus");
}

function remcl(){
	let parent = this.parentNode.parentNode;
	if(this.value == ""){
		parent.classList.remove("focus");
	}
}


inputs.forEach(input => {
	input.addEventListener("focus", addcl);
	input.addEventListener("blur", remcl);
});

// start funtion move form 
		var x = document.getElementById("student");
		var y = document.getElementById("teacher");
		var z = document.getElementById("moveform");
		

        function teacher(){
          x.style.left = "-400px";
          y.style.top =  "-300px";
		  z.style.left = "110px";
		  teacherId.style.color = "white";
		  studentId.style.color = "black";
        }

        function student(){
          x.style.left = "0px";
          y.style.top =  "300px";
		  z.style.left = "0";
		  studentId.style.color = "white";
		  teacherId.style.color = "black";
		}
//end funtion move form login 

function XemDiem(){
	var divPoint = document.getElementById('divPoint');
	divPoint.style.display = "block";
}

// chart
google.charts.load('current', {'packages':['corechart']});
google.charts.setOnLoadCallback(drawChart);

function drawChart() {
  var data = google.visualization.arrayToDataTable([
	['Director (Year)',  'HK1', 'HK2'],
	['Điểm 30%', 8.4,         7.9],
	['Điểm 70%(L1)',     3.9,         6.5],
	['Điểm 70% (L2)',        6.5,         6.4],
	
  ]);

  var options = {
	title: 'Tiến trình học tập',
	vAxis: {title: 'Điểm'},
	isStacked: true
  };

  var chart = new google.visualization.SteppedAreaChart(document.getElementById('chart_div'));

  chart.draw(data, options);
}
