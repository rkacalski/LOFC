using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class glowRotate : MonoBehaviour
{
    public GameObject glow;
    public float speed = 75;

    // Update is called once per frame
    void Update()
    {
        glow.transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
