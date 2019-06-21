using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;
    public MapCreateBlock cr;
    void Start()
    {
        
    }

    // Update is called once per frame
    int i = 0;
    int Hz = 100;
    void FixedUpdate()
    {
        i++;
        if (i < Hz) return;
        i = 0;
        GameObject G = Instantiate(Enemy);
        int rnd = Random.Range(0, cr.Pos.Count-1);
        Vector3 v= cr.Pole[cr.Pos[rnd].I][cr.Pos[rnd].J].transform.position;
       
        G.transform.position = v;
    }
}
