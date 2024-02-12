using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public Transform player;

    [SerializeField]
    public GameObject gameOver;

    [SerializeField]
    private Vector3 _playerPosition;

    [SerializeField]
    private Quaternion _playerRotation;

    [SerializeField]
    private GameObject _stageSelect;

    public bool _fallSwitch;

    public AudioClip _clearGameOverUISE, _gameOverSE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _playerPosition = gameObject.transform.position;
        _playerRotation = gameObject.transform.rotation;

        audioSource = GetComponent<AudioSource>();

        _fallSwitch = true;
    }

    // Update is called once per frame
    void Update()
    {
        //��������Q�[���I�[�o�[
        if (player.position.y <= -15 && Time.timeScale == 1f && _fallSwitch == true)
        {
            GameOver();
        }
    }

    //�Q�[���I�[�o�[����
    private void GameOver()
    {
        audioSource.PlayOneShot(_gameOverSE);

        gameOver.SetActive(!gameOver.activeSelf);

            if (gameOver.activeSelf)
            {
                Time.timeScale = 0f;
            }


    }

    //�X�e�[�W�Z���N�g�Ɉړ�
    public void StageSelect()
    {
        SceneManager.LoadScene("SampleScene");
    }

    //���g���C
    public void Retry()
    {
        audioSource.PlayOneShot(_clearGameOverUISE);

        Time.timeScale = 1f;

        StartCoroutine(DelayCoroutine(3.0f, () =>
        {
            gameOver.SetActive(!gameOver.activeSelf);
        }));

    }

    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }
}
