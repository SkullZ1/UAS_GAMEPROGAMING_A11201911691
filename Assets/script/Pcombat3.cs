using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pcombat3 : MonoBehaviour 
{

	Animator animator;
	public Transform attackPoint;
	public float attackRange = 0.5f;
	public LayerMask enemyLayers;
	public float attackdamage;
	

	private void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.U))
		{
			Attack();
		}
	}

	void Attack()
	{
		animator.SetTrigger("attack");
		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
		foreach(Collider2D enemy in hitEnemies)
		{
			enemy.GetComponent<Enemy>().TakeDamage(attackdamage);
		}

	}


}
