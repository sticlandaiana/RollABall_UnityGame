using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;
    public bool isGameActive = true;

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
       
        
    }

    public void StopTimer()
    {
        isGameActive = false;
    }
}
