using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    float time = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            Instantiate(enemy, new Vector3(Random.Range(571.18f, 589.05f), 0, Random.Range(381.55f, 403.52f)), enemy.transform.rotation);
            time = 2;
        }
    }
}
