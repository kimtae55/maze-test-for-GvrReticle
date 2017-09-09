using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoWalk : MonoBehaviour {
	public int speed = 2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + Camera.main.transform.forward * Time.deltaTime;

	}

	public void OnTriggerEnter (Collider collide) {

		if (collide.gameObject.CompareTag("Trophytag")) {
			SceneManager.LoadScene("End");
		}
	}
}
