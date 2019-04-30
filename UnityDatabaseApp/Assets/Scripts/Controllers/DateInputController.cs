using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class DateInputController : MonoBehaviour {

    public Text info;
    public InputField inputField;

    public bool dateValid;
    private string stringInfo = "Format daty to: RRRR/MM/DD";
    private string Info = "Data podana prawidłowo";

    // Use this for initialization
    void Start () {
        info.enabled = false;
        info.text = stringInfo;
	}
	
    public void CheckDate(string data)
    {
        Match result = Regex.Match(data, @"^(19[5-9][0-9]|20[0-4][0-9]|2050)[-/](0?[1-9]|1[0-2])[-/](0?[1-9]|[12][0-9]|3[01])$");
        if (result.Success)
        {
            info.text = Info;
            dateValid = true;
        }
        else
        {
            info.text = stringInfo;
            dateValid = false;
        }
    }

	// Update is called once per frame
	void Update () {
		if(inputField.text != "")
        {
            info.enabled = true;
            CheckDate(inputField.text);
        }
        else
        {
            info.enabled = false;
        }
      
    }
}
