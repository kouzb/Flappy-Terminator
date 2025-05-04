using UnityEngine;

public class Bullet : Poolable, IInteractable
{
    [SerializeField] private float _lifeTime = 2f;
    [SerializeField] private float _speed = 10f;

    private Vector2 _direction;

    private void OnEnable()
    {
        Invoke(nameof(Despawn), _lifeTime);
    }

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void Init(Vector2 direction)
    {
        _direction = direction;
        CancelInvoke();
        Invoke(nameof(Despawn), _lifeTime);
    }

    public void Despawn()
    {
        base.OnDespawn();
        CancelInvoke();
    }

    public override void OnSpawn()
    {
        base.OnSpawn();
    }
}
