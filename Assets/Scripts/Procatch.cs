using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procatch : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public CharcterStats st;
    public void UpHp() {
        if (st.score <= 0) return;
        
            st.HpMax += 1;
            st.score -= 1;
        
    }
    public void DownHp()
    {
        //if (st.score <= 0) return;
        st.HpMax -= 1;
        st.score += 1;
    }
    public void UpAttack()
    {
        if (st.score <= 0) return;
        st.Attack += 1;
        st.score -= 1;
    }
    public void DownAttack()
    {
       // if (st.score <= 0) return;
        st.Attack -= 1;
        st.score += 1;
    }
}
