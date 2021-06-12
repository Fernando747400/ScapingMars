using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemsManager : MonoBehaviour
{
    [SerializeField] private Image ItemOne;
    [SerializeField] private Image ItemTwo;
    [SerializeField] private Image ItemThree;
    [SerializeField] private Image ItemFour;


    [Header("UI")]
    [SerializeField] Text textOil;
    [SerializeField] Text textIng;

    private int oilCount;
    int ingCount;
    void Start()
    {
        ItemOne.gameObject.SetActive(false);
        ItemTwo.gameObject.SetActive(false);
        ItemThree.gameObject.SetActive(false);
        ItemFour.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.ItemOne == true)
        {
            ItemOne.gameObject.SetActive(true);
            ingCount = 1;
            UpdateTxt();
        }
        if (GlobalVariables.ItemTwo == true)
        {
            ItemTwo.gameObject.SetActive(true);
            ingCount = 2;
            UpdateTxt();

        }
        if (GlobalVariables.ItemThree == true)
        {
            ItemThree.gameObject.SetActive(true);
             oilCount= 1;
            UpdateTxt();
            
        }
        if (GlobalVariables.ItemFour == true)
        {
            ItemFour.gameObject.SetActive(true);
            oilCount = 2;
            UpdateTxt();
        }
    }


    void UpdateTxt()
    {
        textIng.text = "" + ingCount.ToString();
        textOil.text = "" + oilCount.ToString();
    }
}
