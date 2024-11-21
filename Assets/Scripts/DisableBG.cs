using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableBG : MonoBehaviour
{
    public GameObject BG;
    public GameObject Plane2;
    public GameObject StartButton;
    public GameObject Cat;
    public GameObject speech;

    public void DisBG()
    {
        BG.SetActive(false);
        Plane2.SetActive(true);
        StartButton.SetActive(false);
        Cat.SetActive(true);
        speech.SetActive(true);
    }
}
