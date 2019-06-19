using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    private AnimationControl C;
    private Rigidbody2D rb;
    private CharcterStats st;
    D[] Met = new D[5];
  
    void Start()
    {
        C = gameObject.GetComponent<AnimationControl>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        st = gameObject.GetComponent<CharcterStats>();
       
        Met[0] = Stand;
        Met[1] = Right;
        Met[2] = Left;
        Met[3] = Down;
        Met[4] = Up;

    }

    // Update is called once per frame
    bool flag = true;
    private float speedX = 0, speedY = 0;
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
        V.x = Mathf.Abs(V.x) * (-1);
        gameObject.transform.localScale = V;




    }
    private int I = 0;
    private int Hz = 100;
    delegate void D();
    void FixedUpdate()
    {
        I++;
        if (I > Hz)
        {
            I = 0;
            Met[Random.Range(0, Met.Length)]();
        }
        rb.velocity = new Vector2(speedX, speedY);

    }
}
