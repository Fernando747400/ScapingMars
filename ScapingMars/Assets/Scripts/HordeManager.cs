using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeManager : MonoBehaviour
{
    [SerializeField] private GameObject enemySpawnerOne;
    [SerializeField] private GameObject enemySpawnerTwo;
    [SerializeField] private GameObject enemySpawnerThree;
    [SerializeField] private GameObject enemySpawnerFour;
    [SerializeField] private GameObject enemySpawnerFive;
    [SerializeField] private GameObject enemySpawnerSix;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int hordeSizeMultiplier = 6;
    private GameObject[] spawnerList = new GameObject[6];
    // Start is called before the first frame update
    void Start()
    {
        addToList();
        if (hordeSizeMultiplier <= 0)
        {
            hordeSizeMultiplier = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkForHorde();
    }

    void checkForHorde()
    {
        if (GlobalVariables.GunPickup == true && GlobalVariables.HordeOne == false)
        {
            GlobalVariables.HordeOne = true;
                StartCoroutine(slowInstantiate());
        }

        if (GlobalVariables.ItemOne == true && GlobalVariables.HordeTwo == false)
        {
            GlobalVariables.HordeTwo = true;
            StartCoroutine(slowInstantiate());
        }

        if (GlobalVariables.ItemTwo == true && GlobalVariables.HordeThree == false)
        {
            GlobalVariables.HordeThree = true;
            StartCoroutine(slowInstantiate());
        }

        if (GlobalVariables.ItemThree == true && GlobalVariables.HordeFour == false)
        {
            GlobalVariables.HordeFour = true;
            StartCoroutine(slowInstantiate());
        }

        if (GlobalVariables.ItemFour == true && GlobalVariables.HordeFive == false)
        {
            GlobalVariables.HordeFive = true;
            StartCoroutine(slowInstantiate());
        }
    }

    public IEnumerator slowInstantiate()
    {
        WaitForSeconds wait = new WaitForSeconds(1);
        for (int i = 0; i < GlobalVariables.NumberOfItems * hordeSizeMultiplier; i++)
        {
            Instantiate(enemyPrefab, spawnerList[Random.Range(0, 6)].gameObject.transform, false);
            GlobalVariables.NumberOfEnemies = GlobalVariables.NumberOfEnemies + 1;
            Debug.Log("Horde Enemies" + GlobalVariables.NumberOfEnemies);
            yield return wait;
        }     
        //Debug.Log("Spawned an enemy");       
    }

    public void addToList()
    {
        spawnerList[0] = enemySpawnerOne;
        spawnerList[1] = enemySpawnerTwo;
        spawnerList[2] = enemySpawnerThree;
        spawnerList[3] = enemySpawnerFour;
        spawnerList[4] = enemySpawnerFive;
        spawnerList[5] = enemySpawnerSix;
    }
}
