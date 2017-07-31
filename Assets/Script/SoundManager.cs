using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager sharedInstance;

	public AudioSource paddle;
	public AudioSource block;
	public AudioSource dead;


	void Start () {
		sharedInstance = this;
	}
	
	public void PlayPaddle() {
		this.paddle.Play();
	}

	public void PlayBlock() {
		this.block.Play();
	}

	public void PlayDead() {
		this.dead.Play();
	}
}

