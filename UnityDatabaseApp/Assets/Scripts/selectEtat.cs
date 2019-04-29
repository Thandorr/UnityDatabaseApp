using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectEtat : MonoBehaviour {

    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/etatSelect.php";

    public string[] etatData;
    public Dropdown dropdown;
    public List<string> dropList;

    void PopulateList()
    {
        for(int i=0;i<etatData.Length;i++)
        {
            dropList.Add(etatData[i]);
        }
        dropdown.AddOptions(dropList);
        

    }

    

    IEnumerator Start()
    {
        WWW etat = new WWW(URL);
        yield return etat;
        string etatDataString = etat.text;
        etatData = etatDataString.Split(';');
        PopulateList();
    }

}
