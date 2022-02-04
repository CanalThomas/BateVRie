using UnityEngine;
using UnityEngine.UI;

/*using System.Enum;*/


public class ScoreManager : MonoBehaviour
{
    enum Etat
    {
        MAIN,
        TUTO_MENU,
        TUTO_FOUR_FIRST,
        TUTO_PLAY,
        TUTO_DEMO,
        FREE_MENU,
        FREE_PLAY
    }

    private Image[] notes;
    //private static int bpm = 60;
    public double bpm = 60;
    private double spb;
    private double nextTime;
    public int compteur;
    //public Etat SceneManager.
    
    private bool demo = false; // a changer selon si on choisit demo ou play
    public AudioSource metronome;  

    // Start is called before the first frame update
    void Start()
    {
        metronome.GetComponent<AudioSource>();
        notes = new Image[24];
        Image[] score = GetComponentsInChildren<Image>();
        for (int i = 1; i < score.Length; i++)
        {
            notes[i-1] = score[i];
        }

        //bpm = 60;
        spb = 60 / bpm;
        nextTime = Time.realtimeSinceStartup + spb;//AudioSettings.dspTime + spb;
        
        Invoke("StartMetronome", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (((Etat)SceneManager.state == Etat.TUTO_PLAY || (Etat)SceneManager.state == Etat.TUTO_DEMO) && Time.realtimeSinceStartup >= nextTime)
        {
            if ((Etat)SceneManager.state == Etat.TUTO_FOUR_FIRST)
            {
                compteur++;
                if (compteur == 5) { compteur = 0; SceneManager.state = (SceneManager.Etat)Etat.TUTO_PLAY; }
            }

            if (compteur == 24) MetronomeReset();

            //Jouer un son
            nextTime = Time.realtimeSinceStartup + spb;
            metronome.Play();
            DisplayScore();

            
        }
    }

    void StartMetronome()
    {
        compteur = 0;
        SceneManager.state = (SceneManager.Etat)Etat.TUTO_FOUR_FIRST;
    }

    void DisplayScore()
    {
        if ((Etat)SceneManager.state == Etat.TUTO_PLAY)
        {
            if(compteur%6 == 0)
            {
                notes[compteur].sprite = Resources.Load<Sprite>("HitHatBlue");
                compteur++;
                notes[compteur].sprite = Resources.Load<Sprite>("KickRed");
                compteur++;
                if (demo)
                {
                    ///TODO///
                    //On colorie et active les partie adequat : kick et hithat
                }
            }
            else if (compteur % 6 == 3)
            {
                notes[compteur].sprite = Resources.Load<Sprite>("HitHatBlue");
                compteur++;
                notes[compteur].sprite = Resources.Load<Sprite>("SnareGreen");
                compteur++;
                if (demo)
                {
                    ///TODO///
                    //On colorie et active les partie adequat : snare et hithat
                }
            }
            else if (compteur % 6 == 2 || compteur % 6 == 1)
            {
                notes[compteur].sprite = Resources.Load<Sprite>("HitHatBlue");
                compteur++;
                if (demo)
                {
                    ///TODO///
                    //On colorie et active la partie adequat : kick et hithat
                }
            }
        }
    }

    void MetronomeReset()
    {
        ///TODO///
        ///Carrement appeler la fonction loadtutoscene qui mettra le state a la bonne valeur
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

}

