using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenuController : MonoBehaviour {

	public TimeRecordEntity timeRecord;
	public Text timeLabel;

	void Awake () {
		float time = timeRecord.timeSurvived;
		string minutes = (Math.Truncate (time / 60)).ToString ();
		string secondes = Math.Truncate ((time % 60)).ToString ();
		string minutesLabel = " minute";
		string secondesLabel = " seconde";

		if (secondes == "60") {
			secondes = "00";
		}

		if (Math.Truncate (time / 60) > 1) {
			minutesLabel += "s";
		}

		if ((time % 60) > 1) {
			secondesLabel += "s";
		}

		timeLabel.text = minutes + minutesLabel + " et " + secondes + secondesLabel;
	}

	public void BackToMenuHandler () {
		SceneManager.LoadScene ("menu");
	}
}
