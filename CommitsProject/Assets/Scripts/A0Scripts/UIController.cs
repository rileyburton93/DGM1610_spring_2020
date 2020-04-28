using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    
    public Text coinText;
    public CoinData data = new CoinData();
    public DollarData dollarData = new DollarData();
    public Text dollarText;

    // Start is called before the first frame update
    void Start()
    {

        UpdateCoinText();
        UpdateDollarText();

    }
    public void MultiplyCoins()
    {

        data.Multiply();
        UpdateCoinText();

    }

    public void DivideDollars()
    {

        dollarData.Divide();
        UpdateDollarText();

    }

    void UpdateCoinText()
    {
        coinText.text = $"Coins: {data.coins}";
    }

    void UpdateDollarText()
    {
        dollarText.text = $"Dollars: {dollarData.dollars}";
    }
}
