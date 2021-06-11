using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalVariables.ItemOne = false;
        GlobalVariables.ItemTwo = false;
        GlobalVariables.ItemThree = false;
        GlobalVariables.ItemFour = false;
        GlobalVariables.GunPickup = false;
        GlobalVariables.HordeOne = false;
        GlobalVariables.HordeTwo = false;
        GlobalVariables.HordeThree = false;
        GlobalVariables.HordeFour = false;
        GlobalVariables.HordeFive = false;
        GlobalVariables.NumberOfItems = 0;
        GlobalVariables.IsInside = true;
    }

}
