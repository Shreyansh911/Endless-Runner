using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<GameObject> _enemy;

    Vector3 newPosition;
    int randonNo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            randonNo = Random.Range(0, _enemy.Count);

            newPosition = new Vector3(Random.Range(-4,4), transform.position.y, 45);

            Instantiate(_enemy[randonNo], newPosition, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
