using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class checkAnswer : MonoBehaviour
{
    public TMP_InputField inputField;
    public string[] answer;

    public void QuestionAndAnswer()
    { 
        string answer = inputField.text;

        if (inputField.text == answer)
        {
            Debug.Log("Rätt!");
        }
        else
        {
            Debug.Log("Fel!");
        }
    }
}
