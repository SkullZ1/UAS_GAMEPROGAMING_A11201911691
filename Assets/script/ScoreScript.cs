using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour {

	public Text MyscoreText;
	private int ScoreNum;

	// Use this for initialization
	void Start () 
	{
		ScoreNum = 0;
		MyscoreText.text = "Score : " + ScoreNum;
	}

	private void OnTriggerEnter2D(Collider2D Coin)
	{
		if(Coin.tag == "Coin")
		{
			ScoreNum += 1;
			Destroy(Coin.gameObject);
			MyscoreText.text = "Score : " + ScoreNum;
			if(ScoreNum == 2)
			{
				SceneManager.LoadScene("menang");
			}
		}
	}
	
	
}
