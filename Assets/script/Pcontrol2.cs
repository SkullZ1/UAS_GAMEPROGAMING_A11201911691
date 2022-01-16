using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pcontrol2 : MonoBehaviour {
	bool isJump = true;
	bool isDead = false;
	int idMove = 0;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A))
		{
			MoveLeft();
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			Jump();
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			MoveRight();
		}
			if (Input.GetKeyUp(KeyCode.A))
		{
			Idle();
		}
		if (Input.GetKeyUp(KeyCode.D))
		{
			Idle();
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			quit();
		}
		Move();
		Dead();
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
		if(isJump)
		{
			anim.ResetTrigger("jump");
			if(idMove == 0) anim.SetTrigger("idle");
			isJump = false;
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		// Kondisi ketika menyentuh tanah
		anim.SetTrigger("jump");
		anim.ResetTrigger("run");
		anim.ResetTrigger("idle");
		isJump = true;

	}

	public void MoveRight()
	{
		idMove = 1;
	}

	public void MoveLeft()
	{
		idMove = 2;
	}

	private void Move()
	{
		if (idMove == 1 && !isDead)
		{
			// Kondisi ketika bergerak ke kekanan
			if (!isJump) anim.SetTrigger("run");
			transform.Translate(1 * Time.deltaTime * 5f, 0, 0);
			transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		if (idMove == 2 && !isDead)
		{
			// Kondisi ketika bergerak ke kiri
			if (!isJump) anim.SetTrigger("run");
			transform.Translate(-1 * Time.deltaTime * 5f, 0, 0);
			transform.localScale = new Vector3(1f, 1f, 1f);
		}
	}

	public void Jump()
	{
		if (!isJump)
		{
			// Kondisi ketika Loncat           
			gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 700f);
		}
	}

	public void Idle()
	{
		// kondisi ketika idle/diam
		if (!isJump)
		{
			anim.ResetTrigger("jump");
			anim.ResetTrigger("run");
			anim.SetTrigger("idle");
		}
		idMove = 0;
	}

	void quit()
	{
		SceneManager.LoadScene("menu");
	}

	private void Dead()
	{
		if (!isDead)
		{
			if (transform.position.y < -10f)
			{
				// kondisi ketika jatuh
				isDead = true;
			}
		}
	}



}
