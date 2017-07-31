using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyblock : MonoBehaviour {

	public Transform boomObj;
	public Transform powerUpSpeedObj;
	public Transform powerUpSizeObj;

	public int whichpowerup;


	void OnCollisionEnter2D(Collision2D other)
	{
		whichpowerup = Random.Range (1, 15);

		if (whichpowerup == 1) 
		{ 
			Instantiate (powerUpSizeObj, transform.position, powerUpSizeObj.rotation);
		}

		if (whichpowerup == 2) 
		{ 
			Instantiate (powerUpSpeedObj, transform.position, powerUpSpeedObj.rotation);
		}

		Destroy (gameObject, .05f);
		Instantiate (boomObj, transform.position, boomObj.rotation);
	}
}
