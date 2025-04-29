using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _interval = 3f;
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _distancePlayer;
    private float _nextSpawnTime;

    private void Update()
    {
        if(Time.time > _nextSpawnTime)
        {
            Spawn();
            _nextSpawnTime = Time.time + _interval;
        }
    }

    private void Spawn()
    {
        float distance = transform.position.x + _distancePlayer;
        float randomPositionY = Random.Range(_points[0].position.y, _points[_points.Length -1].position.y);
        Vector2 spawnPos = new Vector2(transform.position.x + distance, randomPositionY);
        Debug.Log(transform.position.x);
        Instantiate(_enemy, spawnPos, Quaternion.identity);
    }
}
