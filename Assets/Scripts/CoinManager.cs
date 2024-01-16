using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    private int coinCount = 0;
    public Text coinCountText;

    void Start()
    {
        coinCountText.text = "Pièces ramassées : ";
    }

    public void IncrementCoinCount()
    {
        coinCount++;
        coinCountText.text = "Pièces ramassées : " + coinCount.ToString();
    }
}
