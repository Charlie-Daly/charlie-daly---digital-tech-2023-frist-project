using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float m_gameTime = 0;

    //Referenced scripts
    //Computer computer;
    public StatSave m_StatSaves;

    //stats
    public float P_money;


    [SerializeField] GameObject MoneyText;

    //Text
    public TMP_Text Txt_money;

    // Start is called before the first frame update
    void Start()
    {
        //Money
        Txt_money.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        m_gameTime += Time.deltaTime;

        //Money
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            P_money += 100;
        }
    
        Txt_money.text = "$" + P_money.ToString(); //ToString converts to string

        // save the stats
        m_StatSaves.AddStat(Mathf.RoundToInt(m_gameTime));
        m_StatSaves.SaveStatsToFile();
    }
    
}
