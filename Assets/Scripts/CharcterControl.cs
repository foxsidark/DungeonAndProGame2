using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterControl : MonoBehaviour
{
    // Start is called before the first frame update
    private AnimationControl C;
    private Rigidbody2D rb;
    private CharcterStats st;
    void Start()
    {
        C = gameObject.GetComponent<AnimationControl>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        st = gameObject.GetComponent<CharcterStats>();
       
    }

    // Update is called once per frame
    bool flag = true;
    private float speedX=0, speedY=0;
    public void Stand()
    {
        C.StartAnimationStand();
        speedX = 0;
        speedY = 0;


    }
    public void Up()
    {
        C.StartAnimationUp();
        speedX = 0;
        speedY = st.speed;


    }
    public void Down()
    {
        C.StartAnimationDown();
        speedX = 0;
        speedY = -st.speed;


    }
    public void Left()
    {
        C.StartAnimationLeftRight();
        speedX = -st.speed;
        speedY = 0;

        Vector3 V = gameObject.transform.localScale;
        V.x = Mathf.Abs(V.x);
        gameObject.transform.localScale = V;


    }
    public void Right()
    {
        C.StartAnimationLeftRight();
        speedX = st.speed;
        speedY = 0;
        Vector3 V = gameObject.transform.localScale;
        V.x = Mathf.Abs(V.x)*(-1);
        gameObject.transform.localScale = V;




    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            Up();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Down();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Left();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Right();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<SpellsControl>().FAttack();
        }
        rb.velocity=new Vector2(speedX, speedY);
    }
}
