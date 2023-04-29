using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Off : MonoBehaviour
{
    [SerializeField]
    private Image _image;
    [SerializeField]
    private Button _button;

    void Start()
    {
        _image.enabled = false;
        _button.onClick.AddListener(Click);
    }

    void Click()
    {
        if (_image.enabled == false)
        {
            _image.enabled = true;
        }
        else
        {
            _image.enabled = false;
        }
    }
}
