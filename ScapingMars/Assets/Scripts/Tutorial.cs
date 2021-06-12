using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    [Header("Tutorials")]
    [SerializeField] private GameObject tutorial;
    [SerializeField] private GameObject wasd;
    [SerializeField] private GameObject space;
    [SerializeField] private GameObject f;


    [Header("UI")]
    [SerializeField] private GameObject firstDialog;

    private int count = 0;
    void Start()
    {
        tutorial.SetActive(false);   
    }

    void Update()
    {
         if(firstDialog.activeInHierarchy == false)
        {
            StartCoroutine(ShowTutorials());
        }
    }

    IEnumerator ShowTutorials()
    {
        tutorial.SetActive(true);
        wasd.SetActive(true);
        space.SetActive(true);
       // f.SetActive(true);

        yield return new WaitUntil(()=> Input.GetKeyDown(KeyCode.Space));

        Destroy(tutorial);
        /*
        tutorial.GetComponent<Image>().enabled = false;
        wasd.GetComponent<Image>().enabled = false;
        space.GetComponent<Image>().enabled = false;*/

    }
}
