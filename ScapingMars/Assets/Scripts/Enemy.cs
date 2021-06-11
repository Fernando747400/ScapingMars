using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;
//using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private int enemyLife = 100;

    [Header("Weapon")]
    //[SerializeField] Transform moveIdle;
    //[SerializeField] private int animDuration;

    private Transform target;
    [SerializeField] private float speed;
    private Vector3 lookDirection;


    //[SerializeField] private GameObject enmyScript;
    SpriteRenderer enemySpriteRenderer;
    private Animator animator;


    private void Start() 
    {
        // moveIdle.DOMoveX(3,animDuration).SetLoops(-1,LoopType.Yoyo);
        animator = GetComponent<Animator>();
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
        target = GameObject.Find("Player").transform;
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
        LeanPool.Despawn(this.gameObject);
    }

    public void Move()
    {
        if (GlobalVariables.IsInside == false)
        {
            lookDirection = (target.position - transform.position).normalized;
            transform.Translate(lookDirection * Time.deltaTime * speed);
        }
       
    }

    public void Update()
    {
        Move();
    }



}
