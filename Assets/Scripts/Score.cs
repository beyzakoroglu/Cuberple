using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        scoreText.text = (player.position.z / 5).ToString("0"); //"0" sayesinde decimal kısmı alıyoruz
    }
}
