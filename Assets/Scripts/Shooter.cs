using System.Collections;
using UnityEngine;

public abstract class Shooter : MonoBehaviour
{
    [SerializeField] protected ObjectPool<Bullet> _bulletPool;
    [SerializeField] protected Transform _shotPoint;
    [SerializeField] protected float _fireRate;

    private bool _canShoot = true;
    private float _cooldown = 15f;

    protected void Shoot(Vector2 direction)
    {
        Bullet bullet = _bulletPool.GetObject();
        bullet.transform.position = _shotPoint.position;
        bullet.Init(direction);
    }

    protected bool CanShoot()
    {
        return _canShoot;
    }

    protected IEnumerator Cooldown()
    {
        _canShoot = false;
        yield return new WaitForSeconds(_cooldown);
        _canShoot = true;
    }
}
