using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore = 0;
    public TextMeshProUGUI ScoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        PlayerScore += scoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }
}
