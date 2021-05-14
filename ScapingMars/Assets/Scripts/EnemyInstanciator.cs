using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class EnemyInstanciator : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        LeanPool.Spawn(enemyPrefab,this.transform.position,this.transform.rotation);
        LeanPool.Spawn(enemyPrefab,this.transform.position-GameObject.Find("Player").transform.position,this.transform.rotation);
    }


}
