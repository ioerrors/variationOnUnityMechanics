using UnityEngine;
using UnityEngine.UI;


// changed initial value to muted, rather than starting loud
// this can save people from loud playing music in a game when they didn't
// realize it would have sound
public class MuteMusic : MonoBehaviour
{
    public AudioSource source;
    private Button button;

    private void Start()
    {
        button = this.GetComponent<Button>();
        source.mute = true;
        ChangeText();
    }

    public void Mute()
    {
        source.mute = !source.mute;
        ChangeText();
    }

    private void ChangeText()
    {
        if (source.mute)
        {
            button.GetComponentInChildren<Text>().text = "Muted";

        }
        else
        {
            button.GetComponentInChildren<Text>().text = "Unmuted";
        }
    }
}
