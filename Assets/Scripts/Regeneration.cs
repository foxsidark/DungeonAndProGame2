using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regeneration : MonoBehaviour
{
    // Start is called before the first frame update
    private CharcterStats st;
    void Start()
    {
        st = gameObject.GetComponent<CharcterStats>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        st.HpCur += st.HpRegen;
        if (st.HpCur > st.HpMax) st.HpCur = st.HpMax;
    }
}
