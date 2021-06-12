using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [Header("Player")]
    [SerializeField] GameObject playerGO;
    private Player playerScript;


    [Header("UI")]
    [SerializeField] GameObject narrative;
    [SerializeField] GameObject firstDialog;
    
    [SerializeField] private GameObject diePanel;
   

    [Header("Game Status")]

    public bool GameStart;
    public bool GameFinished;
    public bool finalStage;
    
    [Header("Enemies)")]
    public bool insEnemies;


    [Header ("Ship")]
    [SerializeField] private GameObject ship;
    private Collider2D colShip;




    void Start()
    {
        diePanel.SetActive(false);
        //firstDialog.SetActive(false);
        colShip = ship.GetComponent<Collider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        GamePass();
    }

    public void GameOver()
    {
        diePanel.SetActive(true);

    }
    public void GamePass()
    {
        if(GlobalVariables.NumberOfItems == 5 && GlobalVariables.NumberOfEnemies == 0)
        {
            // Llamar a la escena de victoria. 
            //colShip.isTrigger = true;
            Debug.Log("Ship is triger");
        }
    }

    public void CloseNarrative()
    {
        narrative.gameObject.SetActive(false);
       
    }
   


}
