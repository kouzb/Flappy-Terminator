using UnityEngine;

public class PlayerShooter : Shooter
{
    [SerializeField] private KeyCode _shotKey = KeyCode.F;

    [SerializeField] private Vector2 _direction;

    private void Update()
    {
        if (Input.GetKey(_shotKey) && CanShoot() == true)
        {
            TryShoot();
        }
    }

    private void TryShoot()
    {
        Shoot(_direction);
        StartCoroutine(Cooldown());
    }
}
