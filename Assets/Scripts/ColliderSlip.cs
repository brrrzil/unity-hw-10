using UnityEngine;
using UnityEngine.UI;

public class ColliderSlip : MonoBehaviour
{
    [SerializeField] private Text totalScore;
    int score;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void GetScore()
    {
        score = int.Parse(totalScore.text) + 1;
        totalScore.text = score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Ball"))
        {
            GetScore();
            audioSource.Play();
        }
    }
}