function team1Fumble() { //increments team1 fumble count by 1
	let lbl = document.getElementById('team1FumbleLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team1FumbleLbl").innerHTML = current_count_int.toString();
}

function team1FumbleLost() { //increments team1 fumble lost count by 1
	let lbl = document.getElementById('team1FumblesLostLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team1FumblesLostLbl").innerHTML = current_count_int.toString();
}

function team2Fumble() { //increments team2 fumble count by 1
	let lbl = document.getElementById('team2FumbleLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team2FumbleLbl").innerHTML = current_count_int.toString();
}

function team2FumbleLost() { //increments team2 fumble lost count by 1
	let lbl = document.getElementById('team2FumblesLostLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team2FumblesLostLbl").innerHTML = current_count_int.toString();
}

function team1PassIntercepted() { //increments team1 intercepted passes
	let lbl = document.getElementById('team1PassIntLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team1PassIntLbl").innerHTML = current_count_int.toString();
}

function team1PassCompleted() { //increments team1 completed passes
	let lbl = document.getElementById('team1PassComLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team1PassComLbl").innerHTML = current_count_int.toString();
}

function team2PassIntercepted() { //increments team2 intercepted passes
	let lbl = document.getElementById('team2PassIntLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team2PassIntLbl").innerHTML = current_count_int.toString();
}

function team2PassCompleted() { //increments team2 completed passes
	let lbl = document.getElementById('team2PassComLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team2PassComLbl").innerHTML = current_count_int.toString();
}

function team1FirstDown() { //increments teamfirst downs
	let lbl = document.getElementById('team1FirstDownLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team1FirstDownLbl").innerHTML = current_count_int.toString();
}

function team2FirstDown() { //increments team2 first downs
	let lbl = document.getElementById('team2FirstDownLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team2FirstDownLbl").innerHTML = current_count_int.toString();
}

function team1Score() { //adds score to team1 current score, and score in current quarter
	let score = document.getElementById('team1ScoreAmt').value;
	var score_int = parseFloat(score, 10);

	let ScoreLbl = document.getElementById('team1CurrentScore');
	var current_score = ScoreLbl.innerText;
	var current_score_int = parseFloat(current_score, 10) + score_int;
	document.getElementById("team1CurrentScore").innerHTML = current_score_int.toString();

	if (QRButton1.checked) {
		let quarter_score = document.getElementById('team1Q1Score').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarter1_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team1Q1Score").innerHTML = quarter1_score_int.toString();
	}
	if (QRButton2.checked) {
		let quarter_score = document.getElementById('team1Q2Score').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarter2_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team1Q2Score").innerHTML = quarter2_score_int.toString();
	}
	if (QRButton3.checked) {
		let quarter_score = document.getElementById('team1Q3Score').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarter3_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team1Q3Score").innerHTML = quarter3_score_int.toString();
	}
	if (QRButton4.checked) {
		let quarter_score = document.getElementById('team1Q4Score').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarter4_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team1Q4Score").innerHTML = quarter4_score_int.toString();
	}
	if (QRButtonO.checked) {
		let quarter_score = document.getElementById('team1OTScore').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarterO_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team1OTScore").innerHTML = quarterO_score_int.toString();
	}
}

function team2Score() { //adds score to team1 current score, and score in current quarter
	let score = document.getElementById('team2ScoreAmt').value;
	var score_int = parseFloat(score, 10);

	let ScoreLbl = document.getElementById('team2CurrentScore');
	var current_score = ScoreLbl.innerText;
	var current_score_int = parseFloat(current_score, 10) + score_int;
	document.getElementById("team2CurrentScore").innerHTML = current_score_int.toString();

	if (QRButton1.checked) {
		let quarter_score = document.getElementById('team2Q1Score').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarter1_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team2Q1Score").innerHTML = quarter1_score_int.toString();
	}
	if (QRButton2.checked) {
		let quarter_score = document.getElementById('team2Q2Score').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarter2_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team2Q2Score").innerHTML = quarter2_score_int.toString();
	}
	if (QRButton3.checked) {
		let quarter_score = document.getElementById('team2Q3Score').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarter3_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team2Q3Score").innerHTML = quarter3_score_int.toString();
	}
	if (QRButton4.checked) {
		let quarter_score = document.getElementById('team2Q4Score').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarter4_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team2Q4Score").innerHTML = quarter4_score_int.toString();
	}
	if (QRButtonO.checked) {
		let quarter_score = document.getElementById('team2OTScore').innerText;
		if (quarter_score === "") {
			quarter_score = 0;
		}
		var quarterO_score_int = parseFloat(quarter_score, 10) + score_int;
		document.getElementById("team2OTScore").innerHTML = quarterO_score_int.toString();
	}
}
function team1Rush() { //broken returns NaN to label
	let yards = document.getElementById('team1RushYardsInput').value;
	var yards_int = parseFloat(yards, 10);

	let YardsLbl = document.getElementById('team1TotalYardsLbl');
	var current_yards = YardsLbl.innerText;
	var current_yards_int = parseFloat(current_yards, 10) + yards_int;
	document.getElementById("team1TotalYardsLbl").innerHTML = current_yards_int.toString();
}

function team2Rush() { //broken
	let yards = document.getElementById('team2RushYardsInput').value;
	var yards_int = parseFloat(yards, 10);

	let YardsLbl = document.getElementById('team2TotalYardsLbl');
	var current_yards = YardsLbl.innerText;
	var current_yards_int = parseFloat(current_yards, 10) + yards_int;
	document.getElementById("team2TotalYardsLbl").innerHTML = current_yards_int.toString();
}

function team1PassYards() { //doesnt clear
	let yards = document.getElementById('team1PassYardsInput').value;
	var yards_int = parseFloat(yards, 10);

	let totalYardsLbl = document.getElementById('team1TotalYardsLbl');
	var current_yards = totalYardsLbl.innerText;
	var current_yards_int = parseFloat(current_yards, 10) + yards_int;
	document.getElementById("team1TotalYardsLbl").innerHTML = current_yards_int.toString();

	let passYardsLbl = getElementById('team1PassYardsLbl');
	var current_pass_yards = passYardsLbl.innerText;
	var current_pass_yards_int = parseFloat(current_pass_yards, 10) + yards_int;
	document.getElementById("team1PassYardsLbl").innerHTML = current_pass_yards_int.toString();
}

function team2PassYards() { //broken, doesnt add to label or clear
	let yards = document.getElementById('team2PassYardsInput').value;
	var yards_int = parseFloat(yards, 10);

	let totalYardsLbl = document.getElementById('team2TotalYardsLbl');
	var current_yards = totalYardsLbl.innerText;
	var current_yards_int = parseFloat(current_yards, 10) + yards_int;
	document.getElementById("team2TotalYardsLbl").innerHTML = current_yards_int.toString();

	let passYardsLbl = document.getElementById('team2PassYardsLbl');
	var current_pass_yards = passYardsLbl.innerText;
	var current_pass_yards_int = parseFloat(current_pass_yards, 10) + yards_int;
	document.getElementById("team2PassYardsLbl").innerHTML = current_pass_yards_int.toString();
}

function clearPassYards() {
	document.getElementById("team1PassYardsInput").value = null;

}

function clearInput() {
	document.getElementById("team1ScoreAmt").value = null;
	document.getElementById("team2ScoreAmt").value = null;
	document.getElementById("team1RushYardsInput").value = null;
	document.getElementById("team2RushYardsInput").value = null;
	document.getElementById("team1PassYardsInput").value = null;

}