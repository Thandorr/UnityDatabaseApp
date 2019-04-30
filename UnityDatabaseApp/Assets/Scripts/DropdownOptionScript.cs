using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownOptionScript : MonoBehaviour
{
    public string URL;

    public string[] tabData;
    public Dropdown dropdownList;
    private List<string> dropList = new List<string>();

    void GenerateDropdownOptions()
    {
        for (int i = 0; i < tabData.Length - 1; i++)
        {
            dropList.Add(tabData[i]);
        }
        dropdownList.AddOptions(dropList);


    }
    IEnumerator Start()
    {
        WWW page = new WWW(URL);
        yield return page;
        string dataString = page.text;
        tabData = dataString.Split(';');
        GenerateDropdownOptions();
    }





}
