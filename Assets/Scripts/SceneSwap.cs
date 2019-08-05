using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwap : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogActive;

    private void Update()
    {
        if(dialogActive && Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene(1);
        }
    }
}
