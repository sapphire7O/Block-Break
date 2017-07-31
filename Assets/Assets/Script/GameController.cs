using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour 
{

	int lives = 3;
	int score = 0;

	public Text scoreText;
	public Text livesText;

	public int Lives
	{
		get { return lives; }
		set
		{
			lives = value;
			UpdateUI ();
		}
	}

	public int Score
	{
		get { return score; }
		set 
		{
			score = value;
			UpdateUI();
		}
	}

	// Use this for initialization
	void Start () 
	{
		UpdateUI();
	}

	void UpdateUI()
	{
		scoreText.text = string.Format ("Score: {0}", score);
		livesText.text = string.Format ("Lives: {0}", lives);
	}
}
