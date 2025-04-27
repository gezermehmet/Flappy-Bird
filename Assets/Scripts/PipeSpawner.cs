using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipesPrefab;
    public Transform pipesPoint;
    public float speed;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0, 2.5f);
        //StartCoroutine(SpawnPipe());
    }

    void Update()
    {
    }

    public IEnumerator SpawnPipes()
    {
        Instantiate(pipesPrefab, pipesPoint.position, pipesPoint.rotation);
        yield return new WaitForSeconds(2f);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-2f, 2f);
        Vector3 spawnPosition = new Vector3(pipesPoint.position.x, randomY, pipesPoint.position.z);

        GameObject spawnedPipe = Instantiate(pipesPrefab, spawnPosition, pipesPoint.rotation);
        Destroy(spawnedPipe, 10f);
    }
}