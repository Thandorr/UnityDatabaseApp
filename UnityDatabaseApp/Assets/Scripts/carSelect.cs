using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSelect : MonoBehaviour {
    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/carSelect.php";

    public string[] carsData;
   
    IEnumerator Start()
    {
        WWW cars = new WWW(URL);
        yield return cars;
        string carsDataString = cars.text;
        carsData = carsDataString.Split(';');
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
