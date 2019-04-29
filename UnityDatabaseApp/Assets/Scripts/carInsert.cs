using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carInsert : MonoBehaviour {

    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/carInsert.php";

    public string InputNrRej;
    public string info;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddCar(string nr_rej)
    {
        StartCoroutine(Add(nr_rej));
    }
    public string Text()
    {
        return info;
    }

    IEnumerator Add(string nr_rej)
    {
        WWWForm form = new WWWForm();
        form.AddField("addNrRej", nr_rej);

        WWW www = new WWW(URL, form);
        
        yield return www;
        if (www.text == "0")
        {
            info = "Pomyślnie dodano pojazd";
        }
        else
        {
            info = www.text;
        }

    }
}
