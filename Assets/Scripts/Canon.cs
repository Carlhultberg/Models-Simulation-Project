using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed left click.");

			GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

			// Add euler angles
			sphere.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+3);

			sphere.AddComponent<Ball>(); 
			sphere.GetComponent<Ball>().initialVelocity = transform.up;
			//Instantiate(sphere);

		}
			
	}
}
