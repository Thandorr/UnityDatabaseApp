using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class LoadSceneController : MonoBehaviour
{
    public void LoadScene(Button button)
    {
        if (button.name.ToString() == "BackButton")
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        else
            UnityEngine.SceneManagement.SceneManager.LoadScene(Int32.Parse(button.name));

    }

}
