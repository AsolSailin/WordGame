using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Minus : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private Text _hintCount;
    [SerializeField]
    private Text _moneyText;
    [SerializeField]
    private Text _moneyCount;

    void Start()
    {
        _button.onClick.AddListener(Click);
    }

    void Click()
    {
        if (int.Parse(_hintCount.text) > 0)
        {
            _button.interactable = true;
            int hint = int.Parse(_hintCount.text);
            int money = int.Parse(_moneyText.text);
            hint--;
            _hintCount.text = $"{hint}";
            money -= int.Parse(_moneyCount.text);
            _moneyText.text = $"{money}";
            if (int.Parse(_hintCount.text) == 0)
            {
                _button.interactable = false;
            }
        }
        else
        {
            _button.interactable = false;
        }
    }
}
