using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyPurchase : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private Text _energyText;
    [SerializeField]
    private Text _energyCount;

    void Start()
    {
        _button.onClick.AddListener(Click);
    }

    void Click()
    {
        int energy = int.Parse(_energyText.text);
        energy += int.Parse(_energyCount.text);
        _energyText.text = $"{energy}";
    }
}
