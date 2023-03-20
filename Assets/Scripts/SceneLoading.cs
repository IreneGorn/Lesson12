using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    [SerializeField] private Image _loadingImage;
    [SerializeField] private TextMeshProUGUI _progressText;

    private void Start()
    {
        StartCoroutine(AsyncLoad());
    }

    private IEnumerator AsyncLoad()
    {
        var progress = 0;
        while (progress < 100)
        {
            progress++;
            _loadingImage.fillAmount = progress;
            _progressText.text = $"{progress:0}%";
            yield return null;
        }
        SceneManager.LoadSceneAsync(_sceneName);
    }
}
