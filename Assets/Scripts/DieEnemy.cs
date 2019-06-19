using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public CharcterStats st;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (st.HpCur < 0)
        {
            Destroy(gameObject);
            
        }
    }
}
