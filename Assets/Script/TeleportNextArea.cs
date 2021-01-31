using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportNextArea : MonoBehaviour
{
    public AudioSource sonido;
    public GameObject newArea;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name== "Jugador")
        {
            sonido.Stop();
            collision.gameObject.transform.position = newArea.transform.position;
        }
    }
}
