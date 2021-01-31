using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Target;
    private Vector3 Pos;
    public float CamSpeed;
    //Camera Zoom controller variables
    private Camera cam;
    private float zoom;
    private float zmultiplier=3;
    public float zspeed;
    private float yVelocity = 0.0f;
    private static bool cameraexists;
    void Start()
    {
        cam = Camera.main;
        zoom = cam.orthographicSize;
        if (!cameraexists)
        {
            cameraexists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Pos = new Vector3 (Target.transform.position.x,Target.transform.position.y,transform.position.z);
        transform.position = Vector3.Lerp(transform.position, Pos, CamSpeed * Time.deltaTime);

        float zoomc;
        zoomc = Input.GetAxis("Mouse ScrollWheel");
        zoom -= zoomc * zmultiplier;
        zoom = Mathf.Clamp(zoom,2f,4f);
        cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref yVelocity, Time.deltaTime * zspeed);
    }
}
