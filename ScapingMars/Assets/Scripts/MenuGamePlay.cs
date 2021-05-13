using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuGamePlay : MonoBehaviour
{
    [SerializeField] private GameObject menuDesplegable;
    void Start()
    {
        menuDesplegable.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShowMenu()
    {
        menuDesplegable.gameObject.SetActive(true);
    }
    public void HideMenu()
    {
        menuDesplegable.gameObject.SetActive(false);
    }
}
