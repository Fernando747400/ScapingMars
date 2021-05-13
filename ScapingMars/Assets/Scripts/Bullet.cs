using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Bullet Properties")]
    public float speed = 20f;
    public int damage = 35;
    public Rigidbody2D rb;

    [Header("Bullet Actions")]
    public GameObject player;
    public GameObject impact;
    public GameObject impactContainer;
    
    Player playerScript;
    private Animator animComponent;



    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D (Collider2D hitInfo)
    {

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            
        }
       
        Instantiate(impact,transform.position,transform.rotation);
        Destroy(gameObject);
    }

}
