using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{

    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/carInsert.php";

    public InputField Car;
    public Text WebInfoTextField;

    private string webInfo;

    void Update()
    {
        if (Car.text == "")
        {
            WebInfoTextField.text = "";
            webInfo = "";
        }
        WebInfoTextField.text = webInfo;
    }

    public void AddCarToDatabase()
    {
        StartCoroutine(AddCar(Car.text));
    }


    IEnumerator AddCar(string nr_rej)
    {
        WWWForm form = new WWWForm();
        form.AddField("addNrRej", nr_rej);

        WWW www = new WWW(URL, form);

        yield return www;
        if (www.text == "0")
        {
            webInfo = "Pomyślnie dodano pojazd";
        }
        else
        {
           webInfo = www.text;
        }
    }
}
