using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectRemover<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected ObjectPool<T> _pool;
}
