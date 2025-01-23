using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charStats : MonoBehaviour
{
    public int damage = 10;
    public int gold = 0;
    public int currHp;


    // Start is called before the first frame update
    void Start()
    {
        currHp = gold;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHp(int hpPlus)
    {
        currHp += hpPlus;
    }
}
