using UnityEngine;

public class EnemyShooter : Shooter
{
    [SerializeField] private Player _target;

    private void Update()
    {
        if (CanShoot())
        {
            Vector2 direction = (_target.transform.position - transform.position).normalized;
            Shoot(direction);
        }
    }
}