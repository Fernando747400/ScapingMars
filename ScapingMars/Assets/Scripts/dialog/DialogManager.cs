using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace DialogSystem
{
    public class DialogManager : MonoBehaviour
    {

        public bool finished { get; private set; }
        
        
        
        private void Awake()
        {
            
        }


        protected IEnumerator WriteText(string input, Text textHolder, Color textColor, Font textFont, float delay, AudioClip sound, float delayBetween)
        {

            textHolder.color = textColor;
            textHolder.font = textFont;

            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                SoundManager.instace.PlaySound(sound);
                yield return new WaitForSeconds(delay);
            }
            
           // yield return new WaitUntil(() => Input.GetMouseButton(0));
           yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
            finished = true;

        }
        
        
        
    
    }
}


