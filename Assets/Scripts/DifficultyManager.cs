using UnityEngine;

public enum DifficultyType { Easy = 1, Normal, Hard}

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager instance;

    public DifficultyType difficulty;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }


    public void SetDifficulty(DifficultyType newDifficulty) => difficulty = newDifficulty;
    public void LoadDifficulty(int difficultyIndex)
    {
        difficulty = (DifficultyType)difficultyIndex;
    }
}
