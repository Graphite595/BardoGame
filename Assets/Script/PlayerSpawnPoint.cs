using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{
    private PlayerController playersp;
    private CameraController camerasp;
    public string SpawnName;

    void Start()
    {
        playersp = FindObjectOfType<PlayerController>();
        if (playersp.startPoint == SpawnName){
            playersp.transform.position = transform.position;
            camerasp = FindObjectOfType<CameraController>();
            camerasp.transform.position = new Vector3((transform.position.x), (transform.position.y), camerasp.transform.position.z);
        }

    }

    
    void Update()
    {
        
    }
}
