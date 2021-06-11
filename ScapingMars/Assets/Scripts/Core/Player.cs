
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speedMovPlayer = 1.5f;
    private Animator animComponent;
    private Rigidbody2D rbPlayer;
    public Vector2 move2D;
    public bool  canShoot;
    private bool fireShoot;

    [Header("Weapon")]
    [SerializeField] private GameObject weaponOnGround;
    [SerializeField] private GameObject weaponOnMe;

    [Header("Life")]
    public HealthBar healthBar;
    private int maxHealth = 100;
    [SerializeField] private int currentHealth;





    void Awake()
    {
        InicializeComponents();
        canShoot = false;
    }

    void InicializeComponents()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealthBar(maxHealth);
        animComponent = GetComponent<Animator>();
        rbPlayer = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rbPlayer.MovePosition(rbPlayer.position + move2D * speedMovPlayer * Time.deltaTime);
    }

    void Update()
    {
        move2D = new Vector2 (Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        
        
        if (move2D != Vector2.zero)
        {
            animComponent.SetFloat ("movX",move2D.x);
            animComponent.SetFloat ("movY",move2D.y);
            animComponent.SetBool ("Walk",true);  
        }
        else
        {
            animComponent.SetBool ("Walk",false);
        }

        if ( weaponOnGround.activeInHierarchy == false )
        {
            canShoot = true;
            weaponOnMe.gameObject.SetActive(true);
            fireShoot = Input.GetButtonDown("Fire1");
            //animComponent.SetBool("Fire" , true);
            if (move2D != Vector2.zero)
            {  
               Debug.Log("Cambiar a animShoot");
              animComponent.SetBool ("Walk",false);
              animComponent.SetBool("Fire" , true);
            }  
            else 
            {
                 animComponent.SetBool("Fire",false); 
            }       
        }          
        
    }   
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Weapon1"))
        {
            Debug.Log("PlayerTocaArma");
            weaponOnGround.gameObject.SetActive(false);
            GlobalVariables.GunPickup = true;
            GlobalVariables.NumberOfItems = GlobalVariables.NumberOfItems + 1;
        }

        if (other.CompareTag("Item"))
        {
            GlobalVariables.NumberOfItems = GlobalVariables.NumberOfItems + 1;
            Destroy(other.gameObject);
        }

        switch (other.name)
        {
            case "ItemOne":
                {
                    GlobalVariables.ItemOne = true;
                    Destroy(other.gameObject);
                }
                break;

            case "ItemTwo":
                {
                    GlobalVariables.ItemTwo = true;
                    Destroy(other.gameObject);
                }
                break;

            case "ItemThree":
                {
                    GlobalVariables.ItemThree = true;
                    Destroy(other.gameObject);
                }
                break;

            case "ItemFour":
                {
                    GlobalVariables.ItemFour = true;
                    Destroy(other.gameObject);
                }
                break;
        }
    }

    void RecieveDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    
}
