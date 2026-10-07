using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public int coins = 0;
    public TMP_Text coinText;

    void Start()
    {
        UpdateUI();
    }

    public void AddCoin()
    {
        coins++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coins;
        }
    }
}