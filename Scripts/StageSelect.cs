using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StageSelect : MonoBehaviour
{
    [SerializeField]
    public GameObject timmer;

    [SerializeField]
    public GameObject goldSpace1, goldSpace2, goldSpace3;

    [SerializeField]
    public GameObject stageSelect, rule, rule2;

    [SerializeField]
    public GameObject _player;

    public AudioClip _selectSE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(_selectSE);

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            stageSelect.SetActive(!stageSelect.activeSelf);
        }));
    }

    // Update is called once per frame
    void Update()
    {

    }

    //ルール
    public void Rule()
    {
        rule.SetActive(!rule.activeSelf);

        CommonRule();
    }
    public void Rule2()
    {
        rule2.SetActive(!rule2.activeSelf);

        CommonRule();
    }

    public void NextBackRule()
    {
        rule.SetActive(!rule.activeSelf);
        rule2.SetActive(!rule2.activeSelf);

        audioSource.PlayOneShot(_selectSE);
    }

    public void CommonRule()
    {
        stageSelect.SetActive(!stageSelect.activeSelf);

        audioSource.PlayOneShot(_selectSE);
    }

    //ステージ1
    public void NextStage1()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () => 
        {
            GameObject obj = (GameObject)Resources.Load("Stage1");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ2
    public void NextStage2()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage2");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ3
    public void NextStage3()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage3");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ4
    public void NextStage4()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage4");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ5
    public void NextStage5()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage5");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ6
    public void NextStage6()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage6");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ7
    public void NextStage7()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage7");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ8
    public void NextStage8()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage8");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ9
    public void NextStage9()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage9");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ10
    public void NextStage10()
    {
        NoClroutine();

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            GameObject obj = (GameObject)Resources.Load("Stage10");
            Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            UISet();
        }));

        Time.timeScale = 1f;
    }

    //ステージ選択したら即座にUIを表示する(共通)
    private void NoClroutine()
    {
        //SE
        audioSource.PlayOneShot(_selectSE);
    }

    //ステージ選択したら1.5秒後にUIを表示する(共通)
    private void UISet()
    {
        //タイマー
        timmer.SetActive(!timmer.activeSelf);

        //コイン
        goldSpace1.SetActive(!goldSpace1.activeSelf);
        goldSpace2.SetActive(!goldSpace2.activeSelf);
        goldSpace3.SetActive(!goldSpace3.activeSelf);

        stageSelect.SetActive(!stageSelect.activeSelf);

        //プレイヤー
        _player.SetActive(!_player.activeSelf);

    }

    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }

}
