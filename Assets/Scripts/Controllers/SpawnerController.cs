using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Thanagames.Damocles.Controllers {
	
	public class SpawnerController : MonoBehaviour {
		public void Spawn (GameObject prefab) {
			Instantiate (prefab, transform.position, prefab.transform.rotation);
		}
	}
}