using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    private bool first=false;
    public OnClick script;
    [Header("Стоимость апгрейда")]
    [SerializeField]private float MoneyUpgrade;
    [Header("Стоимость увеличения апгрейда")]
    [SerializeField]private float MoneyPlusUpgrade;
    private float plus;
    [Header("Текст стоимости апгрейда")]
    public Text UpgradeText;
    // Start is called before the first frame update
    void Start()
    {
     plus = MoneyUpgrade;
    }
    void Update()
    {
     UpgradeText.text = "Upgrade " + plus + "$";
    }
    // Update is called once per frame
    private void Load()
    {
        plus += 5;
    }
    public void PlusClick()
    {
        if(first == false)
        {
            if(script.Clicks >= MoneyUpgrade)
            {
                script.Clicks -= MoneyUpgrade;
                script.moneyPlus += 1;
                first = true;
            }
        }
        else if(first == true)
        {
            if(script.Clicks >=plus)
            {
                script.Clicks -= plus;
                plus+=MoneyPlusUpgrade;
                script.moneyPlus += 1;
            }
        }
    }
}
