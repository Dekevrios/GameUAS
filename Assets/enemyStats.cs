using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public int hp = 1;
    public string enemyType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (string.IsNullOrEmpty(enemyType))
        {
            Debug.LogError("EnemyType belum diatur!");
        }
    }

    public void TakeDamage()
    {
        hp--;
        if(hp <= 0)
        {
            enemyKill();
        }
    }
   
    void enemyKill()
    {
        if(enemyType == "Skeleton")
        {
            gameManager.instance.AddEnemyType1();
        }
        else if(enemyType == "Slime")
        {
            gameManager.instance.AddEnemyType2();
        }

        Destroy(gameObject);
    }
}
