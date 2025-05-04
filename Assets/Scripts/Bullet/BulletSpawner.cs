using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public static BulletSpawner Instance { get; private set; }

    private ObjectPool<Bullet> _bulletPool;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Bullet SpawnBullet()
    {
        return _bulletPool.GetObject();
    }

    public void ReturnBullet(Bullet bullet)
    {
        _bulletPool.PutObject(bullet);
    }
}
