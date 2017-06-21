using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thanagames.Damocles.Controllers;

namespace Thanagames.Damocles.Services {
	
	public class ObstacleService : MonoBehaviour {

		public GameController gameController;
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