using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
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
            _loadingImage.fillAmount = progress / 100f;
            _progressText.text = $"{progress:0}%";
            yield return new WaitForSeconds(0.00001f);
        }
        SceneManager.LoadSceneAsync(_sceneName);
    }
}
