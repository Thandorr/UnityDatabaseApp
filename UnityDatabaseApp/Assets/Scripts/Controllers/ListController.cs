using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListController : MonoBehaviour {

    public string URL;

    public string[] listData;

    public Text list;

    


    IEnumerator Start()
    {
        WWW list = new WWW(URL);
        yield return list;
        string employeeDataString = list.text;
        listData = employeeDataString.Split(';');
    }


    void Update()
    {
        if (listData != null)
        {
            foreach (var item in listData)
            {
                list.text += item + "\n";
            }
            listData = null;
        }
    }


}
