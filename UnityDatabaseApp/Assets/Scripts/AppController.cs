using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour {

    public string buttonSend;

    public InputField input;
    public Dropdown dropdown;
    public string etat;
    public string win;
    private employeeInsert employee;
    private carInsert car;
    private employeeSelect employeeList;
    public string[] list;
    public Text success;
    public Text success2;
    public bool check = false;
    public bool check2 = false;
    void Start()
    {
        gameObject.AddComponent<employeeInsert>();
        employeeInsert a = gameObject.GetComponent<employeeInsert>();

        gameObject.AddComponent<carInsert>();
        carInsert b = gameObject.GetComponent<carInsert>();

        gameObject.AddComponent<employeeSelect>();
        employeeSelect c = gameObject.GetComponent<employeeSelect>();


        employee = a;
        car = b;

        c.IDK();
        employeeList = c;
       
    }
    
    
    void Update()
    {
        if(!check2)
        {
            list = employeeList.employeeData;
            foreach (var a in list)
            {
                success2.text += a + "\n";
            }
            check2 = true;
        }

        list = employeeList.employeeData;
        foreach(var a in list)
        {
            success.text += a;
        }

        if (check)
        {
            if (employee.Text() != null)
            {
                win = employee.Text();
            }
            else
                win = car.Text();
            
        }
        if(success != null)
        {
            success.text = win;
        }
        
        
        if(input != null)
        {
            if (input.text == "")
            {
                success.text = "";
                check = false;
                win = "";
            }
        }
        
       
    }
    
   
    public void LoadScene(int number)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(number);
    }

    public void AddCar()
    {
        
        car.AddCar(input.text);
        win = car.Text();
        check = true;
    }

    public void AddEmploye()
    {
        List<Dropdown.OptionData> menuOptions = dropdown.GetComponent<Dropdown>().options;
        etat = menuOptions[dropdown.value].text;
        
        

       employee.Add(input.text, etat);
       win = employee.Text();
       check = true;
    }

    public void SetWin(string txt)
    {
        win = txt;
        success.text = txt;
    }
   
}
