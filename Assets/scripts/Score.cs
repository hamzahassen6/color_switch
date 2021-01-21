using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int Hgscore = 0;
    public Text scoretxt;
    public Text hgscoretxt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "etoile")
        {
            Debug.Log("etoile masset fina hoooy");
            score += 10;
            
            Destroy(collision.gameObject);
        }
                                   
    }


    private void highscore()
    {
        if (Hgscore < score)
        {
            Hgscore = score;
        }

    }

    private void Start()
    {
       // hgscoretxt.text = PlayerPrefs.GetInt("Highscore",0).ToString();
    }





    private void Update()
    {
        
        scoretxt.text = "Score :" + score.ToString();
        hgscoretxt.text = "HighScore :" + score.ToString();
       // PlayerPrefs.SetInt("Highscore", Hgscore);
    }





}
