using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField]
    private Button _button;

    void Start()
    {
        _button.onClick.AddListener(Click);
    }

    void Click()
    {
        PlayerPrefs.SetString("Topics", _button.GetComponentInChildren<Text>().text);
        SceneManager.LoadScene("Game");
    }
}
