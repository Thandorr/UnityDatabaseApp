using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelectController : MonoBehaviour {
    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/carSelect.php";

    public string[] carsData;

    public Text carsList;
    // Use this for initialization
    IEnumerator Start()
    {
        WWW cars = new WWW(URL);
        yield return cars;
        string carsDataString = cars.text;
        carsData = carsDataString.Split(';');
    }

    // Update is called once per frame
    void Update ()
    {
        if (carsData != null)
        {
            foreach (var item in carsData)
            {
                carsList.text += item + "\n";
            }
            carsData = null;
        }
    }
}
