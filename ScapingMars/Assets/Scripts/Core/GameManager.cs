using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [Header("Player")]
    [SerializeField] GameObject playerGO;
    private Player playerScript;


    [Header("UI")]
    [SerializeField] GameObject narrative;
   

    [Header("Game Status")]

    public bool GameStart;
    public bool GameFinished;
    public bool finalStage;
    [Header("Enemies)")]
    public bool insEnemies;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseNarrative()
    {
        StartCoroutine(DoFade());
        
    }

    IEnumerator DoFade()
    {
        Warps warpScript = new Warps();

        warpScript.FadeIn();

        yield return new WaitForSeconds(0.5f);
        warpScript.FadeOut();
        
        narrative.SetActive(false);
    }
}
