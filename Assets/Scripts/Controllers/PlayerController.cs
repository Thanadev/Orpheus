using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Thanagames.Damocles.Controllers {

	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	public class PlayerController : MonoBehaviour {

		public Vector2 maxXAxisMotion;
		public float xMotionValue = 1;

		[Header("Player Effects")]
		public float minYOscillation;
		public float oscillationValue;
		private float oscillationFactor;

		private Rigidbody rb;
		private bool hit = false;
		Vector3 nextPos;

		// Use this for initialization
		void Awake () {
			rb = GetComponent<Rigidbody> ();
		}

		void FixedUpdate () {
			if (!hit) {
				nextPos = transform.position;
				transform.RotateAround (transform.position, Vector3.up, 2);

				if (nextPos.y <= minYOscillation) {
					oscillationFactor = 1;
				} else if (nextPos.y >= 0) {
					oscillationFactor = -1;
				}

				nextPos.y += oscillationValue * oscillationFactor;

				transform.position = nextPos;
			}
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

		void OnCollisionEnter (Collision collision) {
			hit = true;
			rb.velocity = collision.rigidbody.velocity;
		}
	}
}