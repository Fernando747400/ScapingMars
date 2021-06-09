using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCasquito : MonoBehaviour
{
    [Header("Player GO")]
    [SerializeField] private GameObject playerGO;
    private Player playerScript;

    [Header ("Casquitos G0")]
    [SerializeField] private GameObject CasquitoDer;
    [SerializeField] private GameObject CasquitoIzq;
    [SerializeField] private GameObject CasquitoUp;
    [SerializeField] private GameObject CasquitoDown;
    void Start()
    {
        playerScript = playerGO.GetComponent<Player>();
        TurnOFFCasquitos();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.move2D.x > 0)
        {
            Debug.Log("PlAYER YENDO A DERECHA");
            CasquitoDer.SetActive(true);
            CasquitoIzq.SetActive(false);
            CasquitoUp.SetActive(false);
            CasquitoDown.SetActive(false);

        }
        if(playerScript.move2D.x < 0)
        {
            Debug.Log("PlAYER YENDO A IZQUIERDA");
            CasquitoDer.SetActive(false);
            CasquitoIzq.SetActive(true);
            CasquitoUp.SetActive(false);
            CasquitoDown.SetActive(false);
        }
        if(playerScript.move2D.y < 0)
        {
             Debug.Log("PlAYER YENDO A DOWN");
             CasquitoDer.SetActive(false);
            CasquitoIzq.SetActive(false);
            CasquitoUp.SetActive(false);
            CasquitoDown.SetActive(true);
        }
        if(playerScript.move2D.y > 0)
        {
             Debug.Log("PlAYER YENDO A UP");
             CasquitoDer.SetActive(false);
            CasquitoIzq.SetActive(false);
            CasquitoUp.SetActive(true);
            CasquitoDown.SetActive(false);
        }
    }

    void TurnOFFCasquitos()
    {
        CasquitoDer.SetActive(false);
        CasquitoIzq.SetActive(false);
        CasquitoUp.SetActive(false);
        CasquitoDown.SetActive(false);
    }
    
    void TurnONDere()
    {

    }


}
