using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public SaveStatsAndLoad sv;
    void OnCollisionEnter2D(Collision2D col)
    {
       if (col.gameObject.tag == "Player")
        {
            sv.SaveStatsChar();
            Application.LoadLevel(1);
        }
    }
}
