using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public AudioSource sonido;
    public float fadeintime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeintime > 0)
        {
            sonido.volume += 0.01f;
            fadeintime -= Time.deltaTime;
        }
    }
}
