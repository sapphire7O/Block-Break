using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlecontrol : MonoBehaviour {

	public KeyCode moveL;
	public KeyCode moveR;

	public int xVel = 0;


	void Update () 
	{
		if (Input.GetKey (moveL)) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-5 - xVel, 0);
		}

		if (Input.GetKey (moveR))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (5 + xVel, 0);
		}

		if ((!Input.GetKey (moveL)) && (!Input.GetKey (moveR))) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "bigger paddle(Clone)") {
			GetComponent<Transform> ().localScale = new Vector2 (2, 1);
		}

		if (other.gameObject.name == "faster speed(Clone)") {
			xVel = 5;
		}
	}
}
