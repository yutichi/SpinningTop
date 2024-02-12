using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _loading;

    [SerializeField]
    private GameObject _title1, _title2, _title3, _title4, _title5;

    [SerializeField]
    private GameObject _cleckText;

    public AudioClip _gameBGM;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //ロード画面
        _loading.SetActive(!_loading.activeSelf);
        StartCoroutine(DelayCoroutine(4.1f, () =>
        {
            _loading.SetActive(!_loading.activeSelf);
            audioSource.PlayOneShot(_gameBGM);

        }));

        //タイトル演出関連
        StartCoroutine(DelayCoroutine(5.0f, () =>
        {
            _title1.SetActive(!_title1.activeSelf);
        }));

        StartCoroutine(DelayCoroutine(6.0f, () =>
        {
            _title2.SetActive(!_title2.activeSelf);
        })); 
 
        StartCoroutine(DelayCoroutine(7.0f, () =>
        {
            _title3.SetActive(!_title3.activeSelf);
        })); 

        StartCoroutine(DelayCoroutine(8.0f, () =>
        {
            _title4.SetActive(!_title4.activeSelf);
        }));

        StartCoroutine(DelayCoroutine(9.0f, () =>
        {
            _title5.SetActive(!_title5.activeSelf);
        }));


        //クリック文章表示
        StartCoroutine(DelayCoroutine(11.0f, () =>
        {
            _cleckText.SetActive(!_cleckText.activeSelf);
        }));

    }

    // Update is called once per frame
    void Update()
    {
        //シーン切り替え
        if(Input.GetMouseButtonDown(0)) 
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }
}
