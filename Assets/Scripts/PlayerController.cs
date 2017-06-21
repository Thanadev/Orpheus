using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Thanagames.Damocles.Controllers {

	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	public class PlayerController : MonoBehaviour {

		public Vector2 maxXAxisMotion;
		public float xMotionValue = 1;

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		public void MoveOnXAxis (bool toRight) {
			Vector3 newPos = transform.position;

			if (toRight) {
				newPos.x += xMotionValue;
			} else {
				newPos.x -= xMotionValue;
			}

			if (newPos.x > maxXAxisMotion.x && newPos.x < maxXAxisMotion.y) {
				transform.position = newPos;
			}
		}

		void OnCollisionEnter(Collision collision) {
			Debug.Log ("Collision");
		}
	}
}