using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellsStats : CharcterStats
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Player" || col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<CharcterStats>().HpCur -= this.Attack;
        }
        Destroy(gameObject);
    }
    
}
