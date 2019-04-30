using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddRepairController : MonoBehaviour
{

    public string URL;
    public InputField dateList;

    public InputField backDateList;

    public DateInputController validDate;
    public DateInputController validBackDate;

    public Dropdown Car;
    public Dropdown Employee;

    public Text WebInfoTextField;
    public string webInfo;


    // Use this for initialization
    void Start()
    {
        var validDate = dateList.GetComponent<DateInputController>();
        var validBackDate = backDateList.GetComponent<DateInputController>();
    }

    public void AddRepairToDatabase()
    {
        if (validDate.dateValid && validBackDate)
        {
            List<Dropdown.OptionData> menuOptions = Car.GetComponent<Dropdown>().options;
            string car = menuOptions[Car.value].text;
            
            List<Dropdown.OptionData> menuOptions2 = Employee.GetComponent<Dropdown>().options;
            string employee = menuOptions2[Employee.value].text;
           
            StartCoroutine(AddRepair(dateList.text, backDateList.text, car, employee));
           
        }
        else
        {
            webInfo = "Nie poprawnie podano datę!";
        }
    }
    IEnumerator AddRepair(string _date, string _backDate, string _car, string _employee)
    {
        WWWForm form = new WWWForm();
        form.AddField("date", _date);
        form.AddField("backDate", _backDate);
        form.AddField("car", _car);
        form.AddField("employee", _employee);
        WWW www = new WWW(URL, form);
        yield return www;
        if (www.text == "0")
        {
            webInfo = "Pomyślnie dodano naprawę";
        }
        else
        {
            webInfo = www.text;
        }
    }

    // Update is called once per frame
    void Update()
    {
        WebInfoTextField.text = webInfo;
    }
}
