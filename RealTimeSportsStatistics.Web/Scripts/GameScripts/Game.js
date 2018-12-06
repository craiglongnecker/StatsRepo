function team1Score() { //adds score to team1 current score, and score in current quarter
	let scoreSelect = document.getElementById('team1ScoreSelect');
	var selected_score = scoreSelect.options[scoreSelect.selectedIndex].text;
	var selected_score_int = parseInt(selected_score, 10);

	let ScoreLbl = document.getElementById('team1CurrentScore');
	var current_score = ScoreLbl.innerText;
	var current_score_int = parseInt(current_score, 10) + selected_score_int;
	document.getElementById("team1CurrentScore").innerHTML = current_score_int.toString();
}

function team1Fumble() { //increments team1 fumble count by 1
	let lbl = document.getElementById('team1FumbleLbl');
	var current_count = lbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team1FumbleLbl").innerHTML = current_count_int.toString();
}

function team1FieldGoal() { //adds 3 to team1 current score, increments team 2 field goal count by 1
	let FGlbl = document.getElementById('team1FieldGoalLbl');
	var current_count = FGlbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team1FieldGoalLbl").innerHTML = current_count_int.toString();

	let ScoreLbl = document.getElementById('team1CurrentScore');
	var current_score = ScoreLbl.innerText;
	var current_score_int = parseInt(current_score, 10) + 3;
	document.getElementById("team1CurrentScore").innerHTML = current_score_int.toString();
}

function team2FieldGoal() { //adds 3 to team2 current score, increments team 2 field goal count by 1
	let FGlbl = document.getElementById('team2FieldGoalLbl');
	var current_count = FGlbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team2FieldGoalLbl").innerHTML = current_count_int.toString();

	let ScoreLbl = document.getElementById('team2CurrentScore');
	var current_score = ScoreLbl.innerText;
	var current_score_int = parseInt(current_score, 10) + 3;
	document.getElementById("team2CurrentScore").innerHTML = current_score_int.toString();
}

function team1FirstDown() { //increments team 1 first down count by 1
	let FDlbl = document.getElementById('team1FirstDownLbl');
	var current_count = FDlbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team1FirstDownLbl").innerHTML = current_count_int.toString();
}

function team2FirstDown() { //increments team 2 first down count by 1
	let FDlbl = document.getElementById('team2FirstDownLbl');
	var current_count = FDlbl.innerText;
	var current_count_int = parseInt(current_count, 10) + 1;
	document.getElementById("team2FirstDownLbl").innerHTML = current_count_int.toString();
}

function validateNumber(id, low, high, errormsgid) {
	var element = document.getElementById(id);
	var input = parseInt(element.value);
	var errormsg = document.getElementById(errormsgid);
	if (input <= high && input >= low) {
		errormsg.style.visibility = "hidden";
		return true;
	}
	else  {
		errormsg.style.visibility = "visible";
	}
	return false;
}