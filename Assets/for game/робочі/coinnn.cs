using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinnn : MonoBehaviour
{
    public int _coinsPickedUp;
    // Start is called before the first frame update
    void Start()
    {
        _coinsPickedUp = PlayerPrefs.GetInt(key: "Score");
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("coin"))
        {
            coll.gameObject.SetActive(false);
            ++_coinsPickedUp;
        }
        if (coll.gameObject.CompareTag("Finish"))
        {
            PlayerPrefs.SetInt("Score", _coinsPickedUp);
        }
        if (coll.gameObject.CompareTag("lastFinish"))
        {
            PlayerPrefs.SetInt("Score", 0);
            if (PlayerPrefs.HasKey("playerName"))
            {
                for (int i = 0; i < 10; i++)
                {

                    if (PlayerPrefs.HasKey($"Score{i}"))
                    {
                        if (_coinsPickedUp > PlayerPrefs.GetInt($"Score{i}"))
                        {
                            for (int j = 9; j > i; j--)
                            {
                                if (PlayerPrefs.HasKey($"Score{j - 1}"))
                                {
                                    PlayerPrefs.SetInt($"Score{j}", PlayerPrefs.GetInt($"Score{j - 1}"));
                                    PlayerPrefs.SetString($"playerName{j}",
                                        PlayerPrefs.GetString($"playerName{j - 1}"));
                                }
                            }

                            PlayerPrefs.SetInt($"Score{i}", _coinsPickedUp);
                            PlayerPrefs.SetString($"playerName{i}", PlayerPrefs.GetString("playerName"));
                            break;
                        }
                    }
                    else
                    {
                        PlayerPrefs.SetInt($"Score{i}", _coinsPickedUp);
                        PlayerPrefs.SetString($"playerName{i}", PlayerPrefs.GetString("playerName"));
                        break;
                    }


                }
            }
        }
    }
}
