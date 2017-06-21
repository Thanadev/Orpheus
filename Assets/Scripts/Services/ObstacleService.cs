using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Thanagames.Damocles.Services {
	
	public class ObstacleService : MonoBehaviour {

		public GameObject[] obstaclePrefabs;

		public GameObject GetObstacleByElapsedTime () {
			GameObject toReturn = null;

			if (obstaclePrefabs.Length > 0) {
				toReturn = obstaclePrefabs [0];
			}

			return toReturn;
		}
	}
}