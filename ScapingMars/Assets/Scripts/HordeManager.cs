using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeManager : MonoBehaviour
{
    [SerializeField] private GameObject enemySpawnerOne;
    [SerializeField] private GameManager enemyPredab;
    [SerializeField] private float hordeOneSize = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkForHorde();
    }

    void checkForHorde()
    {
        if (GlobalVariables.ItemOne == true && GlobalVariables.HordeOne == false)
        {
            GlobalVariables.HordeOne = true;
            for (int i =0; i < hordeOneSize; i++)
            {
                Instantiate(enemyPredab, enemySpawnerOne.transform, false);
            }
           
        }
    }
}
