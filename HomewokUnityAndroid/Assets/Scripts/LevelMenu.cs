using UnityEngine;
using System.Collections;

public class LevelMenu : MonoBehaviour
{
    public CanvasRenderer[] Levels;
    public int level = 0;
    
    // Use this for initialization
    void Start()
    {
        
        level = PlayerPrefs.GetInt("NowLevel");
        if (level == 0)
        {
            level = 1;
        }
      
        for (int i = level; i < Levels.Length; i++)
        {
            Levels[i].SetColor(Color.red);
        }
        Debug.Log(level);
    }
    public void Level1()
    {
        Application.LoadLevel("Level1");
    }
    public void Level2()
    {
        if (level >= 2)
        {
          Application.LoadLevel("Level2");
          
        }
       
    }
    public void Level3()
    {
        if (level >=3)
        {
            Application.LoadLevel("Level3");
        }    
    }
    public void Level4()
    {
        if (level >= 4)
        {
            Application.LoadLevel("Level4");
        }
       
    }
    public void Level5()
    {
        if (level >= 5)
        {
            Application.LoadLevel("Level5");
        }

    }
    public void Level6()
    {
        if (level >= 6)
        {
            Application.LoadLevel("Level6");
        }

    }
    public void Level7()
    {
        if (level >= 7)
        {
            Application.LoadLevel("Level7");
        }

    }
    public void Level8()
    {
        if (level >= 8)
        {
            Application.LoadLevel("Level8");
        }
    }

    public void Level9()
    {
        if (level >= 9)
        {
            Application.LoadLevel("Level9");
        }
    }

    public void Level10()
    {
        if (level >= 10)
        {
            Application.LoadLevel("Level10");
        }
    }

    public void Level11()
    {
        if (level >= 11)
        {
            Application.LoadLevel("Level11");
        }
    }

    public void Level12()
    {
        if (level >= 12)
        {
            Application.LoadLevel("Level12");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}