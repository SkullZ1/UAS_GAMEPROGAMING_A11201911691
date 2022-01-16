using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtomainmenu : MonoBehaviour {

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			QuitGame();
		}
	}

	public void QuitGame()
	{
		SceneManager.LoadScene("menu");
		Debug.Log("Kembali ke menu");
	}
}
