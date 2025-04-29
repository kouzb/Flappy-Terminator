using UnityEngine;

public class Bullet : MonoBehaviour, IInteractable
{
    [SerializeField] private float _lifeTime = 2f;
    [SerializeField] private float _speed = 10f;

    private Vector2 _direction;

    private void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    private void Update()
    {
        transform.Translate(_direction*_speed * Time.deltaTime);
    }

    public void Init(Vector2 direction)
    {
        _direction = direction;
    }
}
