using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuiManager : MonoBehaviour {



	public void Onplay()
	{
		SceneManager.LoadScene("levelselection");
	}
	
	public void OnPanduan()
	{
		SceneManager.LoadScene("panduan");
	}
	public void OnTentang()
	{
		SceneManager.LoadScene("tentang");
	}
	public void OnKeluar()
	{
		SceneManager.LoadScene("menu");
	}
	public void OnEasy()
	{
		SceneManager.LoadScene("gameplay");
	}
	public void OnMedium()
	{
		SceneManager.LoadScene("Medium");
	}
	public void OnMultiplayer()
	{
		SceneManager.LoadScene("guidemultiplayer");
	}
	public void OnPlaymultiplayer()
	{
		SceneManager.LoadScene("Multiplayer");
	}
	
	
}
