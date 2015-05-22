using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour
{
    public CanvasRenderer Play;
    public CanvasRenderer Quit;
    private Color playCollor;

    public void PlayDown() 
    {
        playCollor = Play.GetColor();
        Play.SetColor(Color.yellow);
        
    }
    public void PlayUp()
    {
        Play.SetColor(playCollor);
        Application.LoadLevel("LevelSelector");

    }

    public void QuitDown() 
    {
        Quit.SetColor(Color.red);
        Application.Quit();
    } 
}
