using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables 
{
    private static bool itemOne, itemTwo, itemThree, itemFour, gunPickup;
    private static bool hordeOne, hordeTwo, hordeThree, hordeFour, hordeFive;
    private static int numberOfItems;
    private static bool isInside;
    
   public static bool ItemOne
    {
        set
        {
            itemOne = value;
        }

        get
        {
            return itemOne;
        }
    }

    public static bool ItemTwo
    {
        set
        {
            itemTwo = value;
        }

        get
        {
            return itemTwo;
        }
    }
    public static bool ItemThree
    {
        set
        {
            itemThree = value;
        }

        get
        {
            return itemThree;
        }
    }
    public static bool ItemFour
    {
        set
        {
            itemFour = value;
        }

        get
        {
            return itemFour;
        }
    }

    public static bool GunPickup
    {
        set
        {
            gunPickup = value;
        }

        get
        {
            return gunPickup;
        }
    }

    public static bool HordeOne
    {
        set
        {
            hordeOne = value;
        }

        get
        {
            return hordeOne;
        }
    }

    public static bool  HordeTwo
    {
        set
        {
            hordeTwo = value;
        }

        get
        {
            return hordeTwo;
        }
    }

    public static bool HordeThree
    {
        set
        {
            hordeThree = value;
        }

        get
        {
            return hordeThree;
        }
    }

    public static bool HordeFour
    {
        set
        {
            hordeFour = value;
        }

        get
        {
            return hordeFour;
        }
    }

    public static bool HordeFive
    {
        set
        {
            hordeFive = value;
        }

        get
        {
            return hordeFive;
        }
    }

    public static int NumberOfItems
    {
        set
        {
            numberOfItems = value;
        }

        get
        {
            return numberOfItems;
        }
    }

    public static bool IsInside
    {
        set
        {
            isInside = value;
        }

        get
        {
            return isInside;
        }
    }

}
