// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class enemyattack : MonoBehaviour 
// {

	
// 	public Transform attackPoint;
// 	public float attackRange = 0.5f;
// 	public LayerMask playerLayers;
// 	public float attackdamage;
	

	

// 	// Update is called once per frame
	
// 	void Attack()
// 	{
// 		Collider2D[] hitplayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);
// 		foreach(Collider2D Player in hitplayer)
// 		{
// 			Player.GetComponent<PlayerController>().TakeDamage(attackdamage);
// 		}

// 	}


// }
