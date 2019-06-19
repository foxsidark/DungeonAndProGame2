using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpellsControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SpellAttack;
    public Image imng;

    
    private CharcterStats st;
    private int Mul = 3;
    void Start()
    {
        st = gameObject.GetComponent<CharcterStats>();
        
    }
    
    public void FAttack()
    {
        if (I > st.SpeedAttack)
        {
            I = 0;
            GameObject g = Instantiate(SpellAttack);
            Vector2 v = gameObject.GetComponent<Rigidbody2D>().velocity;
            //Возможно понадобится;
            
            g.transform.position = gameObject.transform.position;
            g.transform.localScale = new Vector3(v.x > 0 ? 1 : -1, 1);
            if (v.x==0 && v.y == 0)
            {
                v.y = (float)gameObject.GetComponent<CharcterStats>().speed * (-1);
            }
            v.x *= Mul;
            v.y *= Mul;
            if (v.y != 0)
            {
                g.transform.rotation = Quaternion.Euler(0, 0, 90 * (v.y > 0 ? -1 : 1));
            }
            g.GetComponent<Rigidbody2D>().velocity = v;
            g.GetComponent<SpellsStats>().Attack = gameObject.GetComponent<CharcterStats>().Attack;


        }
    }

    // Update is called once per frame
    private int I = 0;
    void FixedUpdate()
    {
        I++;
        if (st.SpeedAttack == 0) return;
        imng.fillAmount = I / st.SpeedAttack;
    }
}
