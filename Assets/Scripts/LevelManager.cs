
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public int killCount = 0;
    public TextMeshProUGUI killText;

    public int currentCoin = 0;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateKillText();
    }

    public void AddKill()
    {
        killCount++;
        UpdateKillText();
    }

    private void UpdateKillText()
    {
        if (killText != null)
        {
            killText.text = "Kills: " + killCount;
        }
    }

    public void AddCoin()
    {
        currentCoin++;
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + currentCoin;
        }
    }
}
