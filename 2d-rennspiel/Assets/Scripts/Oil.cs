using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		// Registrieren, dass Gameobjekt über Ölfleck gefahren ist
		Debug.Log("Etwas ist über den Ölfleck gefahren");
	}
}
