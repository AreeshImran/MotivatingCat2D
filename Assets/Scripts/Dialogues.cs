using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogues : MonoBehaviour
{
    public TMP_Text dialoguetext;

    public string[] dialogue;

    public int step;

    public GameObject Conversation;

    public GameObject cupcake;

    public GameObject HappyCat;

    public GameObject idleCat;

    public GameObject oreo;


    public void inDial()
    {
        dialoguetext.text = dialogue[step];
        step += 1;

        if (step == 5)
        {
            cupcake.SetActive(true);
        }

        if (step == 6)
        {
            HappyCat.SetActive(true);
            idleCat.SetActive(false);
        }

        if (step == 13)
        {
            HappyCat.SetActive(false);
            idleCat.SetActive(true);
            oreo.SetActive(true);
        }

        if (step >= dialogue.Length)
        {
            SceneManager.LoadScene(0);
        }
    }
}
