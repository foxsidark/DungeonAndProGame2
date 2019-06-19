using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockOneRand : MonoBehaviour {

    // Use this for initialization
    public GameObject[] Spr;
    public int count_Block;
    public float Smes = 0.2f;
    public bool[] UpDownLeftRight;

	void Start () {
        for (int i = 0; i < count_Block; ++i)
        {
            for (int j = 0; j < count_Block; ++j)
            {
                GameObject g;
                g = Instantiate(Spr[(i + j + Random.Range(0, Spr.Length))%Spr.Length]);
                g.SetActive(true);
                Vector3 v = gameObject.transform.position;
                v.x += i * Smes;
                v.y += j * Smes;
                g.transform.position = v;

            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
