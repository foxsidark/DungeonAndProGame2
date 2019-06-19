using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpControl : MonoBehaviour
{
    // Start is called before the first frame update
    public CharcterStats st;
    void Start()
    {
              
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (st.HpMax == 0) return;
        gameObject.GetComponent<Image>().fillAmount = st.HpCur / st.HpMax;
    }
}
