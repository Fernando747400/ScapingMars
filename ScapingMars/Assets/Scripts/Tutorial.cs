using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [Header("Tutorials")]
    [SerializeField] private GameObject tutorial;
    [SerializeField] private GameObject wasd;
    [SerializeField] private GameObject space;
    [SerializeField] private GameObject f;

    private int select;
    void Start()
    {
        tutorial.SetActive(true);
        
        StartCoroutine(ShowTutorials());
    }

    IEnumerator ShowTutorials()
    {
       
        wasd.SetActive(true);
        space.SetActive(true);
        f.SetActive(true);

        yield return new WaitUntil(()=> Input.GetMouseButtonDown(0));
        wasd.SetActive(false);
        space.SetActive(false);
        f.SetActive(false);

    }
}
