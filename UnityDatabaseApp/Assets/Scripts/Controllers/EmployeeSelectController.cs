using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployeeSelectController : MonoBehaviour
{
    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/employeeSelect.php";

    public string[] employeeData;

    public Text employeeList;

   

    IEnumerator Start()
    {
        WWW employee = new WWW(URL);
        yield return employee;
        string employeeDataString = employee.text;
        employeeData = employeeDataString.Split(';');
    }

    void Update()
    {
        if (employeeData != null)
        {
            foreach (var item in employeeData)
            {
                employeeList.text += item + "\n";
            }
            employeeData = null;
        }
    }


}
