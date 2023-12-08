using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogue;

    public void Close() 
    { 
        dialogue.SetActive(false);
    }
}
