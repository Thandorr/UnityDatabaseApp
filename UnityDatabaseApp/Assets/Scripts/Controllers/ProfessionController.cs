using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfessionController : MonoBehaviour {

    public string URL;

    public InputField Profession;
    public Text WebInfoTextField;

    private string webInfo;

    void Update()
    {
        if (Profession.text == "")
        {
            WebInfoTextField.text = "";
            webInfo = "";
        }
        WebInfoTextField.text = webInfo;
    }

    public void AddProfessionToDatabase()
    {
        StartCoroutine(AddProfession(Profession.text));
    }


    IEnumerator AddProfession(string profession_name)
    {
        WWWForm form = new WWWForm();
        form.AddField("profession", profession_name);

        WWW www = new WWW(URL, form);

        yield return www;
        if (www.text == "0")
        {
            webInfo = "Pomyślnie dodano etat";
        }
        else
        {
            webInfo = www.text;
        }
    }
}
