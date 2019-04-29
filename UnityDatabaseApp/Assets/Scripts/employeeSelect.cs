using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class employeeSelect : MonoBehaviour {
    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/employeeSelect.php";

    public string[] employeeData;

   


    public void IDK()
    {
       
        StartCoroutine(Select());

        
    }


    IEnumerator Select()
    {
        WWW  employee = new WWW(URL);
        yield return employee;
        string employeeDataString = employee.text;
        employeeData = employeeDataString.Split(';');
    }

    
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
