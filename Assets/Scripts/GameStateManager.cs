using System;
using UnityEngine;

namespace DefaultNamespace
{
    //Generic
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