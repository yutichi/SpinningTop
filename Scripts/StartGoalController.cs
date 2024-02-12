using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartGoalController : MonoBehaviour
{
    [SerializeField]
    public GameObject gameClear;

    [SerializeField]
    public GameObject gameOverTrap;

    [SerializeField]
    public GameObject _gold1, _gold2, _gold3;

    [SerializeField]
    public GameObject getGold1, getGold2, getGold3;

    public AudioClip _goldSE, _gameOverSE, _goalSE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //ゴール
        if (other.gameObject.tag == "Goal")
        {
            //デバッグログ
            Debug.Log("Goal");

            audioSource.PlayOneShot(_goalSE);

            gameClear.SetActive(!gameClear.activeSelf);

            if (gameClear.activeSelf)
            {
                Time.timeScale = 0f;
            }
        }

        //スタート
        if (other.gameObject.tag == "Start")
        {
            //デバッグログ
            Debug.Log("Start");
        }

        //トラップ
        if(other.gameObject.tag == "Trap")
        {
            audioSource.PlayOneShot(_gameOverSE);

            gameOverTrap.SetActive(!gameOverTrap.activeSelf);

            if (gameOverTrap.activeSelf)
            {
                Time.timeScale = 0f;
            }
        }

        //コイン関連
        //1枚目
        if (other.gameObject.tag == "Gold1")
        {
            GameObject gold1 = GameObject.Find("Gold (1)");

            //デバッグ
            Debug.Log("Gold1");

            Destroy(gold1);

            audioSource.PlayOneShot(_goldSE);

            //コイン取得表示
            getGold1.SetActive(!getGold1.activeSelf);
        }
        //2枚目
        if (other.gameObject.tag == "Gold2")
        {
            GameObject gold2 = GameObject.Find("Gold (2)");

            //デバッグ
            Debug.Log("Gold2");

            Destroy(gold2);

            audioSource.PlayOneShot(_goldSE);

            //コイン取得表示
            getGold2.SetActive(!getGold2.activeSelf);
        }
        //3枚目
        if (other.gameObject.tag == "Gold3")
        {
            GameObject gold3 = GameObject.Find("Gold (3)");

            //デバッグ
            Debug.Log("Gold3");

            Destroy(gold3);

            audioSource.PlayOneShot(_goldSE);

            //コイン取得表示
            getGold3.SetActive(!getGold3.activeSelf);
        }


    }

    public void Retry()
    {
        Time.timeScale = 1f;

        StartCoroutine(DelayCoroutine(3.0f, () =>
        {
            gameClear.SetActive(!gameClear.activeSelf);
        }));
    }

    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }
}
