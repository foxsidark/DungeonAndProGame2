using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreateBlock : MonoBehaviour {

    public struct Pair
    {
        public int I;
        public int J;
    }
    public int count_Block;
    public GameObject[] Block;
    public GameObject[] Wall;
    public GameObject[][] Pole;

    public List<Pair> Pos = new List<Pair>();



	// Use this for initialization
	void Start () {
        Pole = new GameObject[count_Block][];
        for (int i = 0; i < Pole.Length; ++i)
        {
            Pole[i] = new GameObject[count_Block];
        }
        Pair p;
        p.I = count_Block / 2;
        p.J = count_Block / 2;
        for (int i=0;i<count_Block/2-2;++i)
        {
            Pos.Add(p);
            GameObject g = Instantiate(Block[Random.Range(0, Block.Length)]);
            Pole[p.I][p.J] = g;
            Vector3 v = gameObject.transform.position;
            v.x += g.GetComponent<SpawnBlockOneRand>().count_Block *
                g.GetComponent<SpawnBlockOneRand>().Smes *
                (p.I - count_Block / 2);
            v.y += g.GetComponent<SpawnBlockOneRand>().count_Block *
               g.GetComponent<SpawnBlockOneRand>().Smes *
               (p.J - count_Block / 2);
            g.transform.position = v;
            int randvalue = Random.Range(0, 4);
            int UpDown = 0;
            int LeftRight = 0;
            if (randvalue == 0) { UpDown = 1; }
            if (randvalue == 1) { UpDown = -1; }
            if (randvalue == 2) { LeftRight = 1; }
            if (randvalue == 3) { LeftRight = -1; }
            bool flag = false;
           
            while (Pole[p.I + UpDown][p.J + LeftRight]!=null)
            {
                UpDown = 0;
                LeftRight = 0;
                randvalue = Random.Range(0, 4);
                
                
                if (randvalue == 0) { UpDown = 1; }
                if (randvalue == 1) { UpDown = -1; }
                if (randvalue == 2) { LeftRight = 1; }
                if (randvalue == 3) { LeftRight = -1; }
                if (Pole[p.I+1][p.J]!=null
                    &&
                    Pole[p.I - 1][p.J] != null
                    &&
                    Pole[p.I ][p.J-1] != null
                    &&
                    Pole[p.I][p.J + 1] != null

                    )
                {
                    flag = true;break;
                }

            }
            if (flag) break;
            p.I += UpDown;
            p.J += LeftRight;
            

        }
        foreach(var p1 in Pos)
        {

            WallSpawn(0, 1, p1);
            WallSpawn(1, 0, p1);
            WallSpawn(-1, 0, p1);
            WallSpawn(0, -1, p1);

        }
		
	}
    private void WallSpawn(int i,int j,Pair p1)
    {
        if (Pole[p1.I + i][p1.J+j] == null)
        {
            Vector3 v = gameObject.transform.position;
            v.x += Pole[p1.I][p1.J].GetComponent<SpawnBlockOneRand>().count_Block *
                   Pole[p1.I][p1.J].GetComponent<SpawnBlockOneRand>().Smes *
                   (p1.I - count_Block / 2 + i);

            v.y += Pole[p1.I][p1.J].GetComponent<SpawnBlockOneRand>().count_Block *
                   Pole[p1.I][p1.J].GetComponent<SpawnBlockOneRand>().Smes *
                   (p1.J - count_Block / 2+j);
            GameObject G = Instantiate(Wall[Random.Range(0, Wall.Length)]);
            Pole[p1.I + i][p1.J + j] = G;
            G.transform.position = v;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
