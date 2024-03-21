using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyAI EnemyPrefab;
    public Transform spawnPoint;
    private float TimeToNextSpawn;
    public float DefaultTime;
    public int enemyToSpawn;
    public static int spawnedEnemy;
    public PlayerController _player;
    public List<Transform> _patrolPoints;
   
    void Update()
    {
        if(TimeToNextSpawn > 0) TimeToNextSpawn-=Time.deltaTime;
        else if(TimeToNextSpawn <= 0 && spawnedEnemy < enemyToSpawn) CreateEnemy();
    }
    void CreateEnemy()
    {
        var enemy = Instantiate(EnemyPrefab);
        enemy.transform.position = spawnPoint.position;
        TimeToNextSpawn = DefaultTime;
        spawnedEnemy++;
        enemy.patrolPoints = _patrolPoints;
    }
}
