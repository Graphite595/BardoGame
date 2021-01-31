using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRestart : MonoBehaviour
{
    public GameObject CheckPoint;
    public Rigidbody2D Cuerpo;
    public AudioSource murio;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Jugador")
        {
            murio.Play();
            collision.gameObject.transform.position = CheckPoint.transform.position;
            Cuerpo.velocity = new Vector3(0f, 0f, 0f);
        }
    }
}
