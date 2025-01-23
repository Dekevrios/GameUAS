using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Text HpTx;
    public static gameManager instance;
    public float delay = 0.1f;

    public Image image,image2,image3;

    public int enemyType1Kills = 0;
    public int enemyType2Kills = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
 

    public void hpDisplay(string value)
    {
        HpTx.text = "" + value;
    }

    public void AddEnemyType1()
    {
        enemyType1Kills++;
        Debug.Log("" + enemyType1Kills);
    }

    public void AddEnemyType2()
    {
        enemyType2Kills++;
        Debug.Log("" + enemyType2Kills);
    }
}
