using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour {

	public bool flying = true;
	private Vector3 spawnPoint;

	void Start(){
		spawnPoint = transform.position;
	}
	// Update is called once per frame
	void Update () {
		while (flying == true) {
			transform.position = transform.position + Camera.main.transform.forward * 5f * Time.deltaTime;
		}
		///
		if (transform.position.x > 125f) {
			transform.position = spawnPoint;
		}
		if (transform.position.x < -125f) {
			transform.position = spawnPoint;
		}
		if (transform.position.y > 150f) {
			transform.position = spawnPoint;
		}
		if (transform.position.y < 0f) {
			transform.position = spawnPoint;
		}
		if (transform.position.z > 120f) {
			transform.position = spawnPoint;
		}
		if (transform.position.z < -120f) {
			transform.position = spawnPoint;
		}
	}
}
