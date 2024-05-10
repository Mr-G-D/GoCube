using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text score;

    private void Start()
    {
        score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().game)
        {
            score.text = (player.position.z/10).ToString("0");
        }

    }
}
