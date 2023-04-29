using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField]
    private GameObject _canvas;
    [SerializeField]
    private Button _button;

    void Start()
    {
        _canvas.SetActive(false);
        _button.onClick.AddListener(Click);
    }

    void Click()
    {
        if (_canvas != null)
        {
            bool isActive = _canvas.activeSelf;
            _canvas.SetActive(!isActive);
        }
    }
}
