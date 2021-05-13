﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletprefab;

    
    [Header("Weapon")]
    [SerializeField] private int mmoWeapon;
    [SerializeField] private Sprite spriteY;
    [SerializeField] private Sprite spriteDefault;
    [SerializeField] private GameObject weaponGO;
    private SpriteRenderer weaponSpriteRender;

    [Header("Bullet")]
    public Transform firePointposX;
    public Transform firePointnegX;
    public Transform firePointposY;
    public Transform firePointnegY;
    

    public GameObject impactContainer;
    public GameObject[] impactEffectArray;
 
    [Header("Player")]
    public GameObject player;
    Player playerScript;
    private int posRotate;
    
   void Awake()
   {
       playerScript = player.gameObject.GetComponent<Player>();
       weaponSpriteRender = weaponGO.gameObject.GetComponent<SpriteRenderer>();
       if(weaponSpriteRender.sprite == null)
            weaponSpriteRender.sprite = spriteDefault;
       
   }   
    void Update()
    {
        if (playerScript.canShoot == true)
        {
            CanShoot();
        }
        if(playerScript.move2D.x > 0)
        {
            //Debug.Log("PlAYER YENDO A X+");
            posRotate = 1;
            weaponSpriteRender.sprite = spriteDefault;
            weaponSpriteRender.flipX = false;
            
        }
        if(playerScript.move2D.x < 0)
        {
            //Debug.Log("PlAYER YENDO A X-");
            posRotate = 2;      
            weaponSpriteRender.sprite = spriteDefault;
            weaponSpriteRender.flipX = true;
        }
        if(playerScript.move2D.y < 0)
        {
             //Debug.Log("PlAYER YENDO A Y-");
             posRotate = 3;
             weaponSpriteRender.sprite = spriteY;
        }
        if(playerScript.move2D.y > 0)
        {
             //Debug.Log("PlAYER YENDO A Y+");
             posRotate = 4;
             //weaponSpriteRender.sprite = spriteNull;
        }
        FindImpacts(); 
    }
     public void CanShoot()
    {
         if (Input.GetButtonDown("Fire1"))

        {
            Shoot();
        }
    }

    void FindImpacts()
    {
        impactEffectArray = GameObject.FindGameObjectsWithTag("Impact");
       
        for (int i = 0; i < impactEffectArray.Length; i++)
        {  
            impactEffectArray[i].gameObject.transform.parent =  impactContainer.transform;
            if(impactEffectArray.Length == 5)
            {
                Destroy(impactEffectArray[i].gameObject);
            }
        }
    }
  

 
    void Shoot()
    {
        switch(posRotate)
        {
            case 1:
                Instantiate(bulletprefab, firePointposX.position, firePointposX.rotation);     
                        
            break;
            case 2:
                Instantiate(bulletprefab, firePointnegX.position, firePointnegX.rotation);
                
            break;
            case 3:
                Instantiate(bulletprefab, firePointnegY.position, firePointnegY.rotation);
                
            break;  
            case 4:
                Instantiate(bulletprefab, firePointposY.position, firePointposY.rotation);
                
            break;
        }

    }





}
