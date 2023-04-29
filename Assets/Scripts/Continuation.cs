using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Continuation : MonoBehaviour
{
    [SerializeField]
    private Button _button;

    void Start()
    {
        _button.onClick.AddListener(Click);
    }

    void Click()
    {
        SceneManager.LoadScene("Game");
    }
}
