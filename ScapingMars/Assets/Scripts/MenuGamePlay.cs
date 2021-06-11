using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuGamePlay : MonoBehaviour
{

    [Header("UI")]
    [SerializeField] GameObject warning;
    public static  bool GameIsPause = false;
    [SerializeField] private GameObject menuDesplegable;

    [Header("Change Scene")]
    [SerializeField] GameObject changeGO;
    CambioScene cambioScene;



    void Start()
    {
        cambioScene = changeGO.GetComponent<CambioScene>();
        menuDesplegable.gameObject.SetActive(false);
        warning.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShowMenu()
    {
        menuDesplegable.gameObject.SetActive(true);
        Pause();
    }
    public void HideMenu()
    {
        menuDesplegable.gameObject.SetActive(false);
        Continue();
    }


    void Continue()
    {
        
        Time.timeScale = 1f;
        GameIsPause = false;

    }
     void Pause()
    {
        Time.timeScale = 0f;
        
        GameIsPause = true;
    }


    public void WarningMenu(int choose)
    {
       
       switch (choose)
       {
           case 0: warning.gameObject.SetActive(true); break;
           case 1: warning.gameObject.SetActive(false); break;
           
           case 2:
                Time.timeScale = 1f;
                cambioScene.FadeOut(0); 
           break;
       }
       
    }
    

}
