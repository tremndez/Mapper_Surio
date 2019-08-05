using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionScripts : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject HiddenTextBox1;
    public GameObject HiddenTextBox2;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject cont;
    public GameObject NPC1;
    public int ChoiceMade;

    public void Start()
    {
        cont.SetActive(false);
        HiddenTextBox1.SetActive(false);
        HiddenTextBox2.SetActive(false);
    }

    public void ChoiceOption1()
    {
        TextBox.GetComponent<Text>().text = "She stares at you for a few seconds. \"Oh my God, you are the purest thing on this Earth. Thank you so much, you have no idea how much it means to me.\" She gleefully jumps excitedly. You feel good, until you hear a commotion amongst the members of Class-A compartment. Things seem to be getting violent, until you hear a scream. Oh well, not your problem anyways. You shout \"Next!\"";
        ChoiceMade = 1;
    }
    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "Denied";
        ChoiceMade = 2;
    }

    public void ContButton()
    {
        ChoiceMade = 3;
    }

    // Update is called once per frame
    void Update()
    {
     if(ChoiceMade == 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            NPC1.SetActive(false);
            cont.SetActive(true);
        }
        if(ChoiceMade == 2)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            NPC1.SetActive(false);
            cont.SetActive(true);
        }
        if (ChoiceMade == 3)
        {
            TextBox.GetComponent<Text>().text = "Next";
        }

    }
}
