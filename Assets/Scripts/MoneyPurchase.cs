using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPurchase : MonoBehaviour
{
    [SerializeField]
    private Button _button;
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
        int money = int.Parse(_moneyText.text);
        money += int.Parse(_moneyCount.text);
        _moneyText.text = $"{money}";
    }
}
