using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<T>();

                if(_instance == null)
                {
                    GameObject singletonObj = new GameObject();
                    singletonObj.name = typeof(T).Name;
                    _instance = singletonObj.AddComponent<T>();
                }
            }

            return _instance;
        }
    }

    protected virtual void Awake()
    { 
        if(_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    protected virtual void Start()
    {
        
    }

    
    protected virtual void Update()
    {
        
    }
}
