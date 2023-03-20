using UnityEngine;

namespace DefaultNamespace
{
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
}