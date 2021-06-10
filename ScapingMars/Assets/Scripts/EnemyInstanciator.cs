using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class EnemyInstanciator : MonoBehaviour
{

    [SerializeField] GameObject gameMG;
     GameManager gameManagerScirpt;

    [SerializeField] private GameObject enemyPrefab;


    // Start is called before the first frame update
    void Start()
    {
       gameManagerScirpt = gameMG.GetComponent<GameManager>();
    }


    void Update()
    {
        if(gameManagerScirpt.insEnemies) SpawnEnemies();
    }


    void SpawnEnemies()
    {
        LeanPool.Spawn(enemyPrefab,this.transform.position,this.transform.rotation);
        LeanPool.Spawn(enemyPrefab,this.transform.position-GameObject.Find("Player").transform.position,this.transform.rotation);  
    }


}
