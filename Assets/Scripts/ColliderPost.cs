using UnityEngine;
using UnityEngine.UI;

public class ColliderPost : MonoBehaviour
{
    [SerializeField] private Text totalScore;
    int score;
    private AudioSource aud;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
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
            Vector3 hitDirection = collision.transform.position - transform.position;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(hitDirection*50, ForceMode.Impulse);
            aud.Play();
        }
    }
}