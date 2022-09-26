using UnityEngine;
using UnityEngine.UI;

public class LivesRem : MonoBehaviour
{
    public Text livesText;
    
    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + PlayerStats.Lives.ToString();
    }
}
