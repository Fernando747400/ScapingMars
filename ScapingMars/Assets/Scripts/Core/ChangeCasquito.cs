using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCasquito : MonoBehaviour
{

    [Header("Detect is Out Or not")]
    public bool isOut;

    [Header("Player GO")]
    [SerializeField] private GameObject playerGO;
    private Player playerScript;

    [Header ("Casquitos G0")]
    [SerializeField] private GameObject CasquitoDer;
    [SerializeField] private GameObject CasquitoIzq;
    [SerializeField] private GameObject CasquitoUp;
    [SerializeField] private GameObject CasquitoDown;

    [Header("Detectors")]
    [SerializeField] private Collider2D room;
    [SerializeField] private Collider2D outside;





    void Start()
    {
        playerScript = playerGO.GetComponent<Player>();
        TurnOFFCasquitos();
    }

    // Update is called once per frame
    void Update()
    {
        if(isOut) TurnON();
        if(isOut == false) TurnOFFCasquitos();
      
    }

    void TurnOFFCasquitos()
    {
        CasquitoDer.SetActive(false);
        CasquitoIzq.SetActive(false);
        CasquitoUp.SetActive(false);
        CasquitoDown.SetActive(false);
    }
    
    void PosCasquito(int i)
    {

        if(i == 1) CasquitoIzq.SetActive(true);
        
    }
    
    void TurnON()
    {
          if(playerScript.move2D.x > 0)
        {
           // Debug.Log("PlAYER YENDO A DERECHA");
            CasquitoDer.SetActive(true);
            CasquitoIzq.SetActive(false);
            CasquitoUp.SetActive(false);
            CasquitoDown.SetActive(false);

        }
        if(playerScript.move2D.x < 0)
        {
            //Debug.Log("PlAYER YENDO A IZQUIERDA");
            CasquitoDer.SetActive(false);
            CasquitoIzq.SetActive(true);
            CasquitoUp.SetActive(false);
            CasquitoDown.SetActive(false);
        }
        if(playerScript.move2D.y < 0)
        {
             //Debug.Log("PlAYER YENDO A DOWN");
             CasquitoDer.SetActive(false);
            CasquitoIzq.SetActive(false);
            CasquitoUp.SetActive(false);
            CasquitoDown.SetActive(true);
        }
        if(playerScript.move2D.y > 0)
        {
             //Debug.Log("PlAYER YENDO A UP");
             CasquitoDer.SetActive(false);
            CasquitoIzq.SetActive(false);
            CasquitoUp.SetActive(true);
            CasquitoDown.SetActive(false);
        }
    }
  
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other == room)
        {
           // Debug.Log("Tocó detect zone room");
            isOut = false;
        }

        if(other == outside)
        {
            //Debug.Log("Detect outside");
            PosCasquito(1);
            isOut = true;
        }


    }


}
