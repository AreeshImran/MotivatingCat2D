using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSound : MonoBehaviour
{
    public AudioSource bubbleclick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        bubbleclick.Play();
    }
}