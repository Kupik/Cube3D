

using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Text score;
    public Text hightScore;

    private void Start()
    {
        hightScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void RollDice ()
    {
      int number =   Random.RandomRange(1, 7);
        score.text = number.ToString();

        if(number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            hightScore.text = number.ToString();
        }
    }


    public void Reset()
    {
        {
            PlayerPrefs.DeleteAll();
            hightScore.text = "0";
        }
    }
}
