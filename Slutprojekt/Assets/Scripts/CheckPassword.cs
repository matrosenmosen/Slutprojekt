using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour
{

    public InputField inputTextField;
    public GameObject answerButton;

    void Start()
    {
        inputTextField = GetComponent<InputField>();
    }

    public void CheckAnswer() 
    { 
        switch (inputTextField.text) 
        {
            case "hej":
                answerButton.SetActive(true);
                break;

            default:
                inputTextField.text = "";
                break;
        
        }
    
    }
}
