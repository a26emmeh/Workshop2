using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    private const int MaxPoints = 2;
    private int points = 0;

    public TextMeshPro text;

    private void UpdateText()
    {
        int remaining = MaxPoints - points;
        if (remaining <= 0)
        {
            text.text = "You win!";
            return;
        }
        
        string coins = remaining == 1 ? "coin" : "coins";
        text.text = $"Collect {remaining} more {coins} to win";
    }

    public void Start()
    {
        UpdateText();
    }

    public void Collect(int points)
    {
        this.points += points;
        UpdateText();
    }
}
