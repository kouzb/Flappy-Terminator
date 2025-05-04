using UnityEngine;

public class EnemyRemover : ObjectRemover<Enemy>
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
        {
            _pool.PutObject(enemy);
        }
    }
}
