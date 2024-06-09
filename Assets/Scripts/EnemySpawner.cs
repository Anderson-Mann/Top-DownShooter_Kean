using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject swarmers;

    [SerializeField] private float interval = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy(interval, swarmers));
    }

    private IEnumerator SpawnEnemy(float Interval, GameObject Enemy)
    {
        yield return new WaitForSeconds(Interval);
        GameObject newEnemy = Instantiate(Enemy, new Vector3(Random.Range(-25f, 25f), Random.Range(-10f, 10f), 0), Quaternion.identity);
        StartCoroutine(SpawnEnemy(Interval, Enemy));
    }
}
