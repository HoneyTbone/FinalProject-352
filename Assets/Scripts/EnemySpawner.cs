using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    private int enemyCount = 0;

    public Transform[] points;
    
    private float timeToWait = 3f;

    private void Start()
    {
         StartCoroutine(WaitTime());    
    }


    private void SpawnEnemy()
    {
        Instantiate(enemy, points[0].transform.position, Quaternion.identity);
        enemyCount++;
        if(enemyCount < 10)
        {
            StartCoroutine(WaitTime());
        }
    }

    IEnumerator WaitTime()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(timeToWait);
        SpawnEnemy();
    }
}
