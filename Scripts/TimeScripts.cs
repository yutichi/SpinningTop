using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimeScripts : MonoBehaviour
{
    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;

    //�O��Update�̎��̕b��
    private float oldSeconds;
    //�^�C�}�[�\���p�e�L�X�g
    private Text timerText;

    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }
        //�@�l���ς�����������e�L�X�gUI���X�V
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            minute = 0;
            seconds = 0f;
            oldSeconds = 0f;
            timerText = GetComponentInChildren<Text>();
        }
    }

    public void Retry()
    {
        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            minute = 0;
            seconds = 0f;
            oldSeconds = 0f;
            timerText = GetComponentInChildren<Text>();
        }));
    }

    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }
}
