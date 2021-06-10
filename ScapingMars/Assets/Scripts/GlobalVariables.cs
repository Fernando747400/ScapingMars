using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables 
{
    private static bool itemOne, itemTwo, itemThree, itemFour;
    private static bool hordeOne;

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

}
