using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Thanagames.Damocles.Controllers.Gui {
	
	public class GameGuiController : MonoBehaviour {
		public GameController gameController;
		public Text timer;

		private PlayerController player;

		// Use this for initialization
		void Awake () {
			player = FindObjectOfType<PlayerController> ();
		}
		
		// Update is called once per frame
		void Update () {
			ActualizeTimer ();
		}

		public void DirectionButtonClickedHandler (bool right) {
			player.MoveOnXAxis (right);
		}

		private void ActualizeTimer () {
			float time = gameController.TimeElapsed;
			string minutes = (Math.Truncate (time / 60)).ToString ("00");
			string secondes = (time % 60).ToString ("00");

			if (secondes == "60") {
				secondes = "00";
			}

			timer.text = minutes + ":" + secondes;
		}
	}
}