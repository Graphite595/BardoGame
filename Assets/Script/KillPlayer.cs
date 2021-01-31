using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject spawnpoint;
    public AudioSource muerte;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Jugador")
        {
            collision.transform.position = spawnpoint.transform.position;
            muerte.Play();
        }
    }
}
