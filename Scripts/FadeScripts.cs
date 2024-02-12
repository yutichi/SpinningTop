using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeScripts : MonoBehaviour
{
    [SerializeField] 
    private Image _PanelImage;

    [SerializeField] 
    private float _speed;

    [SerializeField]
    public GameObject _fadePanel;

    [SerializeField]
    public GameObject _blackPanel;

    private bool isSceneChange;
    
    private Color PanelColor;

    void Start()
    {

        Blackout();
        StartCoroutine(DelayCoroutine(3.5f, () =>
        {
            _blackPanel.SetActive(!_blackPanel.activeSelf);
        }));
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Blackout();
        }
    }

    private void Awake()
    {
        isSceneChange = false;
        PanelColor = _PanelImage.color;
    }

    public void Blackout()
    {
        _fadePanel.SetActive(!_fadePanel.activeSelf);
        PanelColor.a = 0.0f;

        StartCoroutine(Sceneblackout());
    }

    private IEnumerator Sceneblackout()
    {

        while (!isSceneChange)
        {
            PanelColor.a += 0.1f;

            _PanelImage.color = PanelColor;

            if (PanelColor.a >= 1)
                isSceneChange = true;

            yield return new WaitForSeconds(_speed);
        }

        StartCoroutine(DelayCoroutine(4.7f, () =>
        {
            isSceneChange = false;
            PanelColor.a = 0;

            _fadePanel.SetActive(!_fadePanel.activeSelf);
        }));

    }


    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }

}
