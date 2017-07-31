using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour {

	public Vector2 currentVel;
	public Vector2 ballVel;

	public KeyCode start;
	public Transform ball;

	public GameController text;
	public SoundManager soundManager;


	// Use this for initialization
	void Start () 
	{
		ballVel = new Vector2 (0, 0);
		GetComponent<Rigidbody2D> ().velocity = ballVel;
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentVel = GetComponent<Rigidbody2D> ().velocity;

		if (currentVel.y > 6) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (currentVel.x, 6);
		}

		if (currentVel.y < -6) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (currentVel.x, -6);
		}

		if (currentVel.x > 6)
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (6, currentVel.y);
		}

		if (currentVel.x < -6)
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-6, currentVel.y);
		}

		if ((Input.GetKey (start)) && (currentVel.x == 0) && (currentVel.y == 0) && (text.Lives != 0))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (3, -3);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "left wall") 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 ((currentVel.x * -1), (currentVel.y));

			SoundManager.sharedInstance.PlayPaddle();
		}

		if (other.gameObject.name == "right wall") 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 ((currentVel.x * -1), (currentVel.y));

			SoundManager.sharedInstance.PlayPaddle();
		}

		if (other.gameObject.name == "top wall")
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 ((currentVel.x), (currentVel.y * -1));

			SoundManager.sharedInstance.PlayPaddle();
		}

		if (other.gameObject.name == "block") 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 ((currentVel.x), (currentVel.y * -1));
			text.Score += 10;

			SoundManager.sharedInstance.PlayBlock();
		}

		if (other.gameObject.name == "paddle") 
		{
			text.Score += 5;

			SoundManager.sharedInstance.PlayPaddle();
		}

		if (other.gameObject.name == "floor")
		{
			text.Lives--;

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);

			SoundManager.sharedInstance.PlayDead();

			if (text.Lives != 0) 
			{
				transform.position = new Vector2 (-5, 0);
			}
		}
	}
}
