using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [Header("Health Bar")]
    [SerializeField] Slider slider;

    public void SetMaxHealthBar(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth (int healt)
    {
        slider.value = healt;
    }



    


}
