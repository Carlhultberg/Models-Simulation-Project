using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Vector3 initialVelocity;
	public Vector3 gravityForce;
	float mass = 23323;
	// Use this for initialization
	void Start () {
		// Rigidbody body = new Rigidbody ();
		gameObject.AddComponent<Rigidbody>();
		gameObject.GetComponent<Rigidbody> ().useGravity = false;

		gravityForce = new Vector3 (0f, 1f, 0f);
	}
	
	// Update is called once per frame
	void Update () {

	//	transform.position = 
		transform.position += initialVelocity * Time.deltaTime * 5;
		transform.position -= gravityForce * Time.deltaTime * 1;

	}
}
