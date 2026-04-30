using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnGUI()
    {
        // Instruction in upper-right corner
        GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = 24;
        style.fontStyle = FontStyle.Bold;
        style.normal.textColor = Color.white;
        style.alignment = TextAnchor.UpperRight;

        // Position: upper right
        GUI.Label(new Rect(Screen.width - 320, 20, 300, 40),
                  "Need to reset? Type \"R\"",
                  style);
    }
}