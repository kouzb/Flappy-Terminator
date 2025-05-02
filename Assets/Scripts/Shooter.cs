using UnityEngine;

public abstract class Shooter : MonoBehaviour
{
    [SerializeField] protected ObjectPool _bulletPool;
    [SerializeField] protected Transform _shotPoint;
    [SerializeField] protected float _fireRate;

    protected abstract void TryShoot();

    protected void Shoot(Vector2 direction)
    {
        BulletSpawner.
        Bullet bullet = _bulletPool.GetBullet(_shotPoint.position);
        bullet.Init(direction);
    }
}
