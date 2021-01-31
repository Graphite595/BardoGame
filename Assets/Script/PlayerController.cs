using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Cuerpo;
    public int Velocidad;
    public int AltSalto;
    public AudioSource sonidoa;
    public Animator anim;
    public string startPoint;
    private static bool playerExists;
    private bool IsGrounded;
    void Start()
    {
        anim.SetFloat("LastMovX", Velocidad);
        if (!playerExists)
        {
            playerExists = true;
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
        
        if (Input.GetKey(KeyCode.A))
        {
            Cuerpo.velocity = new Vector2( Velocidad*(-1) , Cuerpo.velocity.y);
            anim.SetFloat("LastMovX", Velocidad*(-1));
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Cuerpo.velocity = new Vector2(0f, Cuerpo.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Cuerpo.velocity = new Vector2(Velocidad , Cuerpo.velocity.y);
            anim.SetFloat("LastMovX",Velocidad);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Cuerpo.velocity = new Vector2(0f, Cuerpo.velocity.y);
        }

        anim.SetFloat("MovX",Cuerpo.velocity.x);

        
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
            {
                Cuerpo.velocity = new Vector2(Cuerpo.velocity.x, AltSalto);
                sonidoa.Play();
                anim.SetBool("IsJumping", true);
                IsGrounded = false;
            }
        
        if (Cuerpo.velocity.y < 0)
        {
            anim.SetBool("IsJumping", false);
            anim.SetBool("IsFalling", true);
        }
        if (Cuerpo.velocity.y >= 0)
        {
            
            anim.SetBool("IsFalling", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsGrounded = true;

    }
}
