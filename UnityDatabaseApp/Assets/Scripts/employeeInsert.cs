using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class employeeInsert : MonoBehaviour {

    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/employeeInsert.php";
    public AppController appController;
    

    public string lastname, etat;
    string info;
    public void SetGameControllerReference(AppController controller)
    {
        appController = controller;
    }
    public void Add(string _lastname, string _etat)
    {
        lastname = _lastname;
        etat = _etat;

        StartCoroutine(AddEmployee());

        
        
    }
    public string Text()
    {
        return info;
    }
    IEnumerator AddEmployee()
    {
        WWWForm form = new WWWForm();
        form.AddField("addLastname", lastname);
        form.AddField("etat", etat);
        WWW www = new WWW(URL, form);
        yield return www;
        if(www.text == "0")
        {
            info = "Pomyślnie dodano pracownika";
        }
        else
        {
            info = www.text;
        }
    }

    }

