using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	Rigidbody2D myrigidbody2d;

	public float power = 5f;
	public float turnpower = 3f;

	// Reibung - Widerstand mit der Straße
	public float friction = 2f;

	// Steuerung
	public KeyCode beschleunigen;
	public KeyCode bremsen;
	public KeyCode linkslenken;
	public KeyCode rechtslenken;

	// Use this for initialization
	void Start () {
		myrigidbody2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (beschleunigen)) {
			// taste W gedrückt
			// auto gas geben 
			myrigidbody2d.AddForce (transform.up * power);
			myrigidbody2d.drag = friction;
		}

		if (Input.GetKey (bremsen)) 
		{
			// taste S für bremsen
			myrigidbody2d.AddForce(-(transform.up) * power/2);
			myrigidbody2d.drag = friction;
		}
		if (Input.GetKey (linkslenken)) 
		{
			// lenken nach links
			transform.Rotate(Vector3.forward * turnpower);
		}
		if (Input.GetKey (rechtslenken)) 
		{
			// lenken nach rechts
			transform.Rotate(Vector3.forward * -turnpower);
		}
	}
}
