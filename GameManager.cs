using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
   {
    
    public GameObject titleScreen;
    public Button restartButton;
    public Button playButton;
    public Button aboutButton;
    public Dropdown difficultyDropdown;
    public Button exitButton;
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    private void Awake()
   {
       if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    public enum Difficulty{Easy,Medium,Hard}
    public Difficulty gameDifficulty = Difficulty.Easy;

    private void Start()
    {
        // Menghubungkan tombol-tombol dengan fungsi yang sesuai
        playButton.onClick.AddListener(Play);
        aboutButton.onClick.AddListener(About);
        exitButton.onClick.AddListener(Exit);

        //menambahkan listener pada dropdown

        //inisialisasi dropdown
       
    }

    public void Play()
    {
        // Kode untuk masuk ke dalam game
        SceneManager.LoadScene("GetActiveScene");
    }

    public void About()
    {
        // Kode untuk menampilkan informasi tentang game
        SceneManager.LoadScene("AboutScene");
    }

    public void ChangeDifficulty(int value){
        gameDifficulty = (Difficulty)value;
        //logic untuk mengubah kesulitan game sesuai dengan yang dipilih
    }

    public void Exit()
    {
        // Kode untuk keluar dari game
        Application.Quit();
    }

    public void EndGame()
    {
        // kode untuk mengakhiri game
        SceneManager.LoadScene("GameOver");
    }
}