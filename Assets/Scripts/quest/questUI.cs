using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questUI : MonoBehaviour
{

    public AudioSource backgroundAudio;

    // Start is called before the first frame update
    void Start()
    {
        backgroundAudio = GetComponent<AudioSource>();
        backgroundAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
