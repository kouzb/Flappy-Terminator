using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> : MonoBehaviour where T : Poolable
{
    [SerializeField] protected T _prefab;
    [SerializeField] private Transform _parent;
    [SerializeField] private int _initialSize = 5;

    private Queue<T> _pool;

    private void Awake()
    {
        _pool = new Queue<T>();

        for (int i = 0; i < _initialSize; i++)
        {
            CreateNewObject();
        }
    }

    private void CreateNewObject()
    {
        T newobj = Instantiate(_prefab, _parent);
        newobj.gameObject.SetActive(false);
        newobj.OnDespawn();
        _pool.Enqueue(newobj);
    }

    public T GetObject()
    {
        if(_pool.Count == 0)
        {
            CreateNewObject();
        }

        T obj = _pool.Dequeue();
        obj.OnSpawn();
        return obj;
    }

    public void PutObject(T obj)
    {
        obj.gameObject.SetActive(false);
        _pool.Enqueue(obj);
    }

    public void Reset()
    {
        _pool.Clear();
    }
}
