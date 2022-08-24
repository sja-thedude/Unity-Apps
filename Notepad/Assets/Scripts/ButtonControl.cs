using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject theText;
    public AudioSource clearSound;
    public GameObject thePanel;

    public void ClearText()
    {
        theText.GetComponent<InputField>().text = "";
        clearSound.Play();
    }

    public void CancelButton()
    {
        thePanel.SetActive(false);
    }

    public void Closebutton()
    {
        thePanel.SetActive(true);
    }

    public void Quitbutton()
    {
        Application.Quit();
    }
}
