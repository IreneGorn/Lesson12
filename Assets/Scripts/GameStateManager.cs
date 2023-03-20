using System;
using UnityEngine;

namespace DefaultNamespace
{
    //Generic
    public abstract class SingletonMonoBehavior<T> : MonoBehaviour where T : SingletonMonoBehavior<T>
    {
        private static T _instance;
        // Singleton pattern
        public static T Instance => _instance;
        
        private void Awake()
        {
            if (_instance != null)
            {
                Destroy(_instance.gameObject);
                return;
            }
            
            _instance = (T)this;
        }
    }
    public class GameStateManager : SingletonMonoBehavior<GameStateManager>
    {
        private bool _isDead = false;
        private GameObject _player;
        
        private void Start()
        {
            _player = FindObjectOfType<PlayerKeyboardInput>().gameObject;
        }

        public void Die()
        {
            Destroy(_player);
            _isDead = true;
        }
    }
}