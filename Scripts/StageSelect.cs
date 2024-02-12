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

    //���[��
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

    //�X�e�[�W1
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

    //�X�e�[�W2
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

    //�X�e�[�W3
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

    //�X�e�[�W4
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

    //�X�e�[�W5
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

    //�X�e�[�W6
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

    //�X�e�[�W7
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

    //�X�e�[�W8
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

    //�X�e�[�W9
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

    //�X�e�[�W10
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

    //�X�e�[�W�I�������瑦����UI��\������(����)
    private void NoClroutine()
    {
        //SE
        audioSource.PlayOneShot(_selectSE);
    }

    //�X�e�[�W�I��������1.5�b���UI��\������(����)
    private void UISet()
    {
        //�^�C�}�[
        timmer.SetActive(!timmer.activeSelf);

        //�R�C��
        goldSpace1.SetActive(!goldSpace1.activeSelf);
        goldSpace2.SetActive(!goldSpace2.activeSelf);
        goldSpace3.SetActive(!goldSpace3.activeSelf);

        stageSelect.SetActive(!stageSelect.activeSelf);

        //�v���C���[
        _player.SetActive(!_player.activeSelf);

    }

    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }

}
