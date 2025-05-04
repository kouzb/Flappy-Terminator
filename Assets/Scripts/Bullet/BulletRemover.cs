using UnityEngine;

public class BulletRemover : ObjectRemover<Bullet>
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Bullet bullet))
        {
            _pool.PutObject(bullet);
        }
    }
}
