using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thanagames.Damocles.Services;

namespace Thanagames.Damocles.Controllers {
	
	public class GameController : MonoBehaviour {

		public GameObject spawnerContainer;
		public ObstacleService obstacleServ;
		public float secondsBetweenSpawns = 3;

		private SpawnerController[] spawners;
		private bool gameStopped = false;

		// Use this for initialization
		void Awake () {
			spawners = spawnerContainer.GetComponentsInChildren<SpawnerController> ();

			if (spawners.Length == 0 || spawners == null) {
				Debug.LogError ("No spawners found");
			}
		}

		void Start () {
			StartCoroutine (SpawnObstacles ());
		}

		IEnumerator SpawnObstacles () {
			while (!gameStopped) {
				yield return new WaitForSeconds (secondsBetweenSpawns);

				int spawnerIndex = Random.Range (0, spawners.Length - 1);
				spawners [spawnerIndex].Spawn (obstacleServ.GetObstacleByElapsedTime ());
			}
		}
	}
}