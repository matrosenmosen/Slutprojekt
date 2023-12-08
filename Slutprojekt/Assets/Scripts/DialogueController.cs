using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] sentences;
    private int index = 0;
    public float dialoguespeed;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            dialogueText.text = "";
            StartCoroutine(WriteSentence());
        }
    }

    void NextSentence() 
    { 
        if(index <= sentences.Length - 1) 
        { 
            NextSentence();
        }
    }

    IEnumerator WriteSentence() 
    { 
        foreach(char Character in sentences[index].ToCharArray()) 
        {
            dialogueText.text += Character;
            yield return new WaitForSeconds(dialoguespeed);
        }

        index++;
    }
}
