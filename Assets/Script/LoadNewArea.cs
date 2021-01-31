using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour
{
    
    public string newZone;
    public string ZoneEntered;
    private PlayerController player;
    public AudioSource sonido;
    public float wait;
    public bool loaded,triggered;
    
    void Start(){
        player = FindObjectOfType<PlayerController>();
    }
    
    void Update() {
        if (triggered)
        {
            wait -= Time.deltaTime;
            sonido.volume -= 0.01f;
            if (wait <= 0f)
            {
                loaded = true;
            }
            if (loaded)
            {
                SceneManager.LoadScene(newZone);
                player.startPoint = ZoneEntered;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Jugador")
        {
            triggered = true;           
        }
    }
}
