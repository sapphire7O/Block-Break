﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroypowerup : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "paddle") 
		{
			Destroy (gameObject);
		}
	}
}
