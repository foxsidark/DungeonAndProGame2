using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStatsAndLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public CharcterStats st;
    static int FirstFlag = 0;
    void Start()
    {
        FirstFlag=PlayerPrefs.GetInt("FirstFlag");
        if (FirstFlag==1)
        {
            LoadStatsChar();
        }
        else
        {
            FirstFlag = 1;
            PlayerPrefs.SetInt("FirstFlag",1);
        }

    }
    public void SaveStatsChar()
    {
        
        PlayerPrefs.SetFloat("HpMax" + "", st.HpMax);
        PlayerPrefs.SetFloat("HpCur" + "", st.HpCur);
        PlayerPrefs.SetFloat("HpRegen" + "", st.HpRegen);
        PlayerPrefs.SetFloat("Attack" + "", st.Attack);
        PlayerPrefs.SetFloat("SpeedAttack" + "", st.SpeedAttack);
        PlayerPrefs.SetFloat("speed" + "", st.speed);
        PlayerPrefs.SetFloat("score" + "", st.score);

    }
    public void LoadStatsChar()
    {

        st.HpMax = PlayerPrefs.GetFloat("HpMax" + "");
        st.HpCur = PlayerPrefs.GetFloat("HpCur" + "");
        st.HpRegen = PlayerPrefs.GetFloat("HpRegen" + "");
        st.Attack = PlayerPrefs.GetFloat("Attack" + "");
        st.SpeedAttack = PlayerPrefs.GetFloat("SpeedAttack" + "");
        st.speed = PlayerPrefs.GetFloat("speed" + "");
        st.score = (int)PlayerPrefs.GetFloat("score" + "");

    }
    int I = 0;
   


}
