using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private int _poolSize;

    private ObjectPool<Bullet> _bulletPool;


}
