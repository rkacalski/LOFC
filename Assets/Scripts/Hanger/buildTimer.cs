using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildTimer : MonoBehaviour
{
    float timer;

    public GameObject panel1Time;
    public GameObject panel2Time;
    public GameObject panel3Time;
    public GameObject panel4Time;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void getBuildTime()
    {

    }
}
