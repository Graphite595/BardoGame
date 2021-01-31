using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControllerScript : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D mostro;
    public float movespeed;
    private float movingtime;
    public float refmovingtime;
    private float waittime;
    public float refwaittime;
    private bool moving=true;
    private bool facingright = true;
    void Start()
    {
        movingtime = refmovingtime;
        waittime = refwaittime;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            if (facingright)
            {
                movingtime -= Time.deltaTime;
                mostro.velocity = new Vector2(movespeed, mostro.velocity.y);
                anim.SetFloat("MovX", movespeed);
            }
            else
            {
                movingtime -= Time.deltaTime;
                mostro.velocity = new Vector2(movespeed*(-1), mostro.velocity.y);
                anim.SetFloat("MovX", movespeed*(-1));
            }
        }
        else
        {
            waittime -= Time.deltaTime;
            mostro.velocity = new Vector2(0f, mostro.velocity.y);
            anim.SetFloat("MovX", 0f);
        }

        if (movingtime <= 0f)
        {
            moving = false;
            facingright = !facingright;
            movingtime = refmovingtime;
        }
        if (waittime <= 0f)
        {
            moving = true;
            waittime = refwaittime;
        }
        if (mostro.velocity.x != 0f)
        {
            anim.SetFloat("LastMovX",mostro.velocity.x);
        }
    }
}
