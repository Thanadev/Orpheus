using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Thanagames.Damocles.Controllers {
	
	public class DeadZoneController : MonoBehaviour {

		void OnTriggerEnter (Collider other) {
			if (other.CompareTag ("Player")) {
				Debug.Log ("Player dead");
				FindObjectOfType<GameController> ().PlayerDeadHandler ();
			}

			Destroy (other.gameObject);
		}
	}
}