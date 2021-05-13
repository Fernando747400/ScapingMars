using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private int enemyLife = 100;
    
    [Header("Weapon")]
    //[SerializeField] Transform moveIdle;
    //[SerializeField] private int animDuration;


    //[SerializeField] private GameObject enmyScript;
    SpriteRenderer enemySpriteRenderer;
    private Animator animator;

     private void Start() 
    {
       // moveIdle.DOMoveX(3,animDuration).SetLoops(-1,LoopType.Yoyo);
        animator = GetComponent<Animator>();
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
    } 


    public void TakeDamage (int damage)
    {
        enemyLife -= damage;
        StartCoroutine(TakingDamage());
        if (enemyLife<=0)
           { 
               Die();
           }
    }   
    IEnumerator TakingDamage()
    {
        animator.SetBool("damage",true);
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("damage",false);
    }

    void Die()
    {
        Destroy(this.gameObject);
    }


    
}
