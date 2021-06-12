using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [Header("Player")]
    [SerializeField] GameObject playerGO;
    [SerializeField] GameObject[] casquito;
    [SerializeField] GameObject gun;
    
    private Player playerScript;


    [Header("UI")]
    [SerializeField] GameObject narrative;
    [SerializeField] GameObject firstDialog;
    [SerializeField] GameObject finalDialog;
    
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

    Vector2 finalPosCam;

    [Header("GameManager")]
    [SerializeField] GameObject changeSceneGO;
    CambioScene changescene;




    void Start()
    {
        changescene = changeSceneGO.GetComponent<CambioScene>();
        finalPosCam = ship.transform.position;
        diePanel.SetActive(false);
        //firstDialog.SetActive(false);
        colShip = ship.GetComponent<Collider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.NumberOfItems == 5 && GlobalVariables.NumberOfEnemies == 0)
        {
            GamePass();
        }
    }

    public void GameOver()
    {
        diePanel.SetActive(true);

    }
    public void GamePass()
    {
       finalDialog.SetActive(true);
       playerGO.transform.position = finalPosCam;
       playerGO.GetComponent<Player>().enabled = false;
       playerGO.GetComponent<SpriteRenderer>().enabled = false;
       gun.GetComponent<SpriteRenderer>().enabled = false;

       for(int i = 0; i < casquito.Length; i++)
       {
           casquito[i].GetComponent<SpriteRenderer>().enabled = false;
       }

       StartCoroutine(ChangetoCredits());
       


    }

    public void CloseNarrative()
    {
        narrative.gameObject.SetActive(false);
       
    }
   

    IEnumerator ChangetoCredits ()
    {   
        yield return new WaitUntil(()=> Input.GetKeyDown(KeyCode.Space));
        changescene.FadeOut(2);
       

        
    }

    


}
