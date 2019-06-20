using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Portal;
    public MapCreateBlock cr;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    bool flag = true;
    void Update()
    {
        if (flag)
        {
            flag = false;

            Portal.transform.position = cr.Pole[cr.Pos[cr.Pos.Count - 1].I][cr.Pos[cr.Pos.Count - 1].J].transform.position;
        }
        
    }
}
