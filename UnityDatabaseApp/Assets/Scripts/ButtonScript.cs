using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    public Button button;
    public Text buttonText;

    public AppController appController;

    public void SetGameControllerReference(AppController controller)
    {
        appController = controller;
    }

    public void ButtonClick()
    {
        if(buttonText.text == "Dodaj pojazd")
        {
            appController.LoadScene(1);
        }
        if(buttonText.text == "Dodaj samochód")
        {
            appController.AddCar();
        }
        if (buttonText.text == "Dodaj pracowników")
        {
            appController.LoadScene(2);
        }
        if (buttonText.text == "Dodaj pracownika")
        {
            appController.AddEmploye();
        }
        if (buttonText.text == "Powrót")
        {
            appController.LoadScene(0);
        }
        if (buttonText.text == "Pracownicy")
        {
            appController.LoadScene(3);
        }

    }

   
}
