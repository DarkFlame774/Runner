using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnRate = 1;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        obstacleSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            obstacleSpawn();
        }

        
    }
    private void obstacleSpawn()
    {
        int typeOfObstacle = Random.Range(0, 3);

        Instantiate(obstacles[typeOfObstacle], new Vector3(transform.position.x, obstacles[typeOfObstacle].transform.position.y, 0), transform.rotation);
        Instantiate(obstacles[3], new Vector3(obstacles[3].transform.position.x, obstacles[3].transform.position.y, 0), transform.rotation);

        timer = 0;
    }
}
