using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyAI EnemyPrefab;
    public Transform spawnPoint;
    private float TimeToNextSpawn;
    public float DefaultTime;
    public static int spawnedEnemy;
    public PlayerController _player;
    public List<Transform> _patrolPoints;
    // public List<EnemyAI> Enemies;
    
    void Update()
    {
        if(TimeToNextSpawn > 0)
        {
            TimeToNextSpawn--;
        }
        else if(TimeToNextSpawn <= 0 && spawnedEnemy < 1)
        {
            var enemy = Instantiate(EnemyPrefab);
            enemy.transform.position = spawnPoint.position;
            TimeToNextSpawn = DefaultTime;
            spawnedEnemy++;
            enemy.player = _player;
            enemy.patrolPoints = _patrolPoints;
        } 
    }

}
