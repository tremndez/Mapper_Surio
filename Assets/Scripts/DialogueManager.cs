using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogActive;

    public string[] dialogLines;
    public int currentLine;

    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentLine >= dialogLines.Length)
        {
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;
        }
        else if (currentLine == 1 && (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C)))
        {
            NPC2.SetActive(true);
            currentLine += 2;
        }
        else if (currentLine == 2 && (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C)))
        {
            NPC2.SetActive(true);
            currentLine++;
        }
        else if (currentLine == 4 && (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C)))
        {
            NPC3.SetActive(true);
            currentLine += 2;
        }
        else if (currentLine == 5 && (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C)))
        {
            NPC3.SetActive(true);
            currentLine++;
        }
        else if(currentLine == 7 && (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C)))
        {
            SceneManager.LoadScene(2);
        }
        else if(currentLine == 8 && (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C)))
        {
            SceneManager.LoadScene(2);
        }
        else if (dialogActive && Input.GetKeyDown(KeyCode.C))
        {
            NPC1.SetActive(false);
            NPC2.SetActive(false);
            currentLine += 2;
        }
        else if (dialogActive && Input.GetKeyDown(KeyCode.X))
        {
            NPC1.SetActive(false);
            NPC2.SetActive(false);
            currentLine++;
        }
        dText.text = dialogLines[currentLine];


    }
    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }
}
