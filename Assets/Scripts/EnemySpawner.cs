using UnityEngine;
using System.Collections;
public class EnemySpawner : MonoBehaviour
{
    public GameObject[] EnemyPrefab;
    public Transform[] SpawnPoints;
    public int WaveNumber = 1;
    public int EnemyForWave = 10;
    public float spawnDelay = 0.5f;
    public float timeForShop = 20f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnWave());
    }


    private IEnumerator SpawnWave()
    {
        while (true)
        {
            int totalEnemy = EnemyForWave + WaveNumber * 2;
            for (int i = 0; i < totalEnemy; i++)
            {
                SpawnZombie();
                yield return new WaitForSeconds(spawnDelay);
            }
            WaveNumber++;
            yield return new WaitForSeconds(timeForShop);
        }
    }
    void SpawnZombie()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int enemyIndex = Random.Range(0, EnemyPrefab.Length);
        Instantiate(EnemyPrefab[enemyIndex], SpawnPoints[spawnIndex].position, Quaternion.identity);
    }
}