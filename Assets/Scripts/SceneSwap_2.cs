using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwap_2 : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogActive;

    private void Update()
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.X))
        {
            Application.Quit();
        }
        else if (dialogActive && Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(0);
        }
    }
}
