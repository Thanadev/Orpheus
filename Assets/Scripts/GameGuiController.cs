using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Thanagames.Damocles.Controllers.Gui {
	
	public class GameGuiController : MonoBehaviour {

		private PlayerController player;

		// Use this for initialization
		void Awake () {
			player = FindObjectOfType<PlayerController> ();
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		public void DirectionButtonClickedHandler (bool right) {
			player.MoveOnXAxis (right);
		}
	}
}