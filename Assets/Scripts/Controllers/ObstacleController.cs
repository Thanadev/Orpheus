using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Thanagames.Damocles.Controllers {
	
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	public class ObstacleController : MonoBehaviour {

		public float fallingSpeed;

		protected Rigidbody rb;

		// Use this for initialization
		void Awake () {
			rb = GetComponent<Rigidbody> ();
		}

		void Start () {
			rb.velocity = new Vector3 (0, -fallingSpeed, 0);
		}
	}
}
