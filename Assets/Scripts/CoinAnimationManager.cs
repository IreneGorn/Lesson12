using DefaultNamespace.UI;
using UnityEngine;

namespace DefaultNamespace
{
    public class CoinAnimationManager : SingletonMonoBehavior<CoinAnimationManager>
    {
        [SerializeField] private AnimatedScoreDisplay _scoreDisplay;
        [SerializeField] private GameObject _coinPrefab;
        [SerializeField] private Canvas _canvas;
        [SerializeField] private float _animationDuration = 1f;
        
        public void Animate(int amount, Vector3 startPosition)
        {
            //анимация через task
            var coin = Instantiate(_coinPrefab, _canvas.transform);

            var startScreenPosition = Camera.main.WorldToScreenPoint(startPosition);
            var targetPosition = _scoreDisplay.transform.position;
        }

        private async void AnimateTask(Transform animatedTransform, Vector3 startPos, Vector3 endPos)
        {
            var direction = startPos - endPos;
            var step = _animationDuration / direction;
        }
    }
}