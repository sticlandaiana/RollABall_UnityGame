using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverZone : MonoBehaviour
{
    public GameObject winTextObject;
    public Timer timer;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
            if (winTextObject != null)
            {
                winTextObject.SetActive(true);
                winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
            }

            other.gameObject.SetActive(false);
            if (timer != null)
            {
                timer.StopTimer();
            }
        }
    }
}