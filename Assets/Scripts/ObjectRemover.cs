using UnityEngine;

public abstract class ObjectRemover<T> : MonoBehaviour where T : Poolable
{
    [SerializeField] protected ObjectPool<T> _pool;
}
