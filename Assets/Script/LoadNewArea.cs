using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour
{
    
    public string newZone;
    public string ZoneEntered;
    private PlayerController player;
    
    void Start(){
        player = FindObjectOfType<PlayerController>();
    }
    
    void Update() {}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Jugador")
        {
            SceneManager.LoadScene(newZone);
            player.startPoint = ZoneEntered;
        }
    }
}
