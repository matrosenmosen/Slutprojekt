using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class checkAnswer : MonoBehaviour
{
    // Script som kollar dina svar p� fr�gorna, inte det mest effektiva but it will do
    
    public TMP_InputField inputField;
    public TMP_Text resulttext;
    public GameObject button;
    public GameObject nextbutton;

   
    public void VanGoghAnswer()
    {   
        string input = inputField.text;

        if (inputField.text == "VINCENT VAN GOGH")     
        {
            resulttext.text = "R�tt!";                  
            button.SetActive(false);                  
            nextbutton.SetActive(true);                 
        }

        else if(inputField.text == "Vincent van gogh")
        {
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "vincent  van gogh")
        {
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "Vincent Van Gogh")
        {
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "Vincent Van Gogh")
        {
            resulttext.text = "R�tt!";
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
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "de fem")
        {
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "DE FEM")
        {
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "De fem")
        {
            resulttext.text = "R�tt!";
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
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "JURIDIK")
        {
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else if (inputField.text == "Juridik")
        {
            resulttext.text = "R�tt!";
            button.SetActive(false);
            nextbutton.SetActive(true);
        }

        else
        {
            resulttext.text = "Fel!";
        }
    }
}
