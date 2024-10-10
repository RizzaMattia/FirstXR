using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    #region Variabili ----
    //Variabili per gestire lo score
    private float score;
    private float bestScore;
    private float secondScore;
    private float thirdScore;
    #endregion

    #region Metodi Default
    // Start is called before the first frame update
    void Start()
    {
        //Imposto le variabili
        score = 0;
        bestScore =  PlayerPrefs.GetFloat("bestScoreValue", 0);
        secondScore =  PlayerPrefs.GetFloat("secondScoreValue", 0);
        thirdScore =  PlayerPrefs.GetFloat("thirdScoreValue", 0);

        //imposto il testo sul panel dello Score
        GameObject.Find("bestScore").GetComponent<TextMeshProUGUI>().text = "Best: " + bestScore;
        GameObject.Find("secondScore").GetComponent<TextMeshProUGUI>().text = "Second Score: " + secondScore;
        GameObject.Find("thirdScore").GetComponent<TextMeshProUGUI>().text = "Third Score: " + thirdScore;
        GameObject.Find("currentScore").GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    }
    #endregion

    #region Metodi Public ----
    //Metodo per controllare lo Score e impostare lo score migliore in fila
    //Param obj l oggetto da distruggere
    public void SetScore(GameObject obj) {
        //Aumento lo Score
        score += 100;

        //Controlli per erificare il best Score e successivi
        if (score > bestScore)
        {
            PlayerPrefs.SetFloat("bestScoreValue", score);
            PlayerPrefs.SetFloat("secondScoreValue", bestScore);
            PlayerPrefs.SetFloat("thirdScoreValue", secondScore);
        }
        else if (score > secondScore && score < bestScore)
        {
            PlayerPrefs.SetFloat("secondScoreValue", score);
            PlayerPrefs.SetFloat("thirdScoreValue", secondScore);
        }
        else if (score > thirdScore && score < secondScore) {
            PlayerPrefs.SetFloat("thirdScoreValue", score);
        }

        //Imposto lo score attuale
        GameObject.Find("currentScore").GetComponent<TextMeshProUGUI>().text = "Score: " + score.ToString();

        //Distruggo l oggetto
        Destroy(obj);
    }

    //Metodo per tornare al menu alla fine
    public void Finish() {
        SceneManager.LoadScene("Menu");
    }
    #endregion
}
