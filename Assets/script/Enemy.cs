using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Pathfinding;

public class Enemy : MonoBehaviour {

	public float maxHealth;
	// Animator animator;
	float currentHealth;
	float health;
	public HealthBar Healthbar;

	// Use this for initialization
	void Start () 
	{
		// animator = GetComponent<Animator>();
		currentHealth = maxHealth;
		Healthbar.SetHealth(currentHealth,maxHealth);
	}
	
	public void TakeDamage(float damage)
	{
		currentHealth -= damage;
		Healthbar.SetHealth(currentHealth,maxHealth);
		
		if (currentHealth <= 0)
		{
		// 	animator.SetTrigger("Hurt");
			Die();
			
		}
	}

	void Die()
	{
		// animator.SetBool("isDead",true);
		Debug.Log("Enemy died");
		GetComponent<Collider2D>().enabled = false;
		GetComponent<AIPath>().enabled = false;	
	}

}
