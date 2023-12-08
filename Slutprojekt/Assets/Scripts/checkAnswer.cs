using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class checkAnswer : MonoBehaviour
{
    // Script som kollar dina svar på frågorna, inte det mest effektiva but it will do
    
    public TMP_InputField inputField;
    public TMP_Text resulttext;
    public GameObject button;
    public GameObject nextbutton;

   
    public void VanGoghAnswer()
    {   
        string input = inputField.text;

        if (inputField.text == "VINCENT VAN GOGH")     
        {
            resulttext.text = "Rätt!";                  
            button.SetActive(false);                  
            nextbutton.SetActive(true);                 
        }

        else if(inputField.text == "Vincent van gogh")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "vincent  van gogh")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "Vincent Van Gogh")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "Vincent Van Gogh")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else
        {
            resulttext.text = "Fel!";
        }
    }

    public void AfKlintAnswer()
    {

        if (inputField.text == "De Fem")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "de fem")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "DE FEM")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "De fem")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else
        {
            resulttext.text = "Fel!";
        }
    }

    public void MatisseAnswer()
    {

        if (inputField.text == "juridik")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "JURIDIK")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "Juridik")
        {
            resulttext.text = "Rätt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else
        {
            resulttext.text = "Fel!";
        }
    }
}
