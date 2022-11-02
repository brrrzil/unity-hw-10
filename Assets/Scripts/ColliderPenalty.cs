using UnityEngine;
using UnityEngine.UI;

public class ColliderPenalty : MonoBehaviour
{
    [SerializeField] private Text totalScore;
    int score;
    //public Animation anim;

    private void GetScore()
    {
        score = int.Parse(totalScore.text) - 1;
        totalScore.text = score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Ball"))
        {
            //anim.Play();
            GetScore();
            Vector3 hitDirection = collision.transform.position - transform.position;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(hitDirection, ForceMode.Impulse);
        }
    }
}