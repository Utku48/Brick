using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public TextMeshProUGUI WinYazisi, LoseYazisi;
    public Transform Bricks; //Ekrandaki block sayısını kontrol etmemizi sağlayacak
    int bloksayisi;
    public TextMeshProUGUI ScoreYazisi;
    public static int score, brokeBrick;
    void Start()
    {
        score = 0;
        brokeBrick = 0;
    }


    void Update()
    {
        ScoreYazisi.text = "Skor: " + score;
        bloksayisi = Bricks.childCount; //Bricks içindeki bloksayisi'nin sayısını istedik.
        if (bloksayisi == 0)
        {
            WinYazisi.text = "Tebrikler Kazandiniz\n Skor: " + score + "\n Kirilan Blok: " + brokeBrick + "`\n \n Tekrar Oynamak İçin Bir Tuşa Basiniz";
            Time.timeScale = 0;

            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
        if (Time.timeScale == 0)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }
}
