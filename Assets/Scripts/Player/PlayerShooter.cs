using System.Collections;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private KeyCode _shotKey = KeyCode.F;
    [SerializeField] private Transform _shotPoint;
    [SerializeField] private float _cooldown = 0.15f;

    private Vector2 _direction;
    private bool _canShoot = true;

    private void Update()
    {
        if (Input.GetKey(_shotKey) && _canShoot == true)
        {
            TryShoot();
        }
    }

    private void TryShoot()
    {
        Bullet newBullet = Instantiate(_bullet, _shotPoint.position, Quaternion.identity);
        _direction = transform.right;
        newBullet.Init(_direction.normalized);
        StartCoroutine(Cooldown());
    }

    private IEnumerator Cooldown()
    {
        _canShoot = false;
        yield return new WaitForSeconds(_cooldown);
        _canShoot = true;
    }
}
