using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployeeController : MonoBehaviour
{

    string URL = "http://kjasiurkowski.cln.servizza.it/wsh_projects/employeeInsert.php";

    public InputField LastName;
    public Dropdown Profession;
    public Text WebInfoTextField;

    private string webInfo;

    void Update()
    {
        if(LastName.text == "")
        {
            WebInfoTextField.text = "";
            webInfo = "";
        }
        WebInfoTextField.text = webInfo;
    }

    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void AddEmployeeToDatabase()
    {
        List<Dropdown.OptionData> menuOptions = Profession.GetComponent<Dropdown>().options;
        string profession = menuOptions[Profession.value].text;

        StartCoroutine(AddEmployee(LastName.text, profession));
    }


    IEnumerator AddEmployee(string _lastname, string _profession)
    {
        WWWForm form = new WWWForm();
        form.AddField("addLastname", _lastname);
        form.AddField("etat", _profession);
        WWW www = new WWW(URL, form);
        yield return www;
        if (www.text == "0")
        {
            webInfo = "Pomyślnie dodano pracownika";
        }
        else
        {
            webInfo = www.text;
        }



    }
}

