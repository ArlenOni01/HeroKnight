 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;
    public int attackDamage = 20;
    
    void Update()
    {
        if (Input.GetKeyDown("z")){
            Attack();
        }
        
        if (Input.GetKeyDown("x")){
            Attack2();
        }

        if (Input.GetKeyDown("c")){
            Attack3();
        }

        if (Input.GetKeyDown("s")){
            Roll();
        }
                
    }
    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        
        foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            }
    }

    void Attack2()
    {
        animator.SetTrigger("Attack2");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        
        foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            }
    }

    void Attack3()
    {
        animator.SetTrigger("Attack3");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        
        foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            }
    }
    void Roll()
    {
        animator.SetTrigger("Roll");
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        
         Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

    