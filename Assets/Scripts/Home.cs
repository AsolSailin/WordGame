using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(Click);
    }

    void Click()
    {
        SceneManager.LoadScene("Topic");
    }
}
