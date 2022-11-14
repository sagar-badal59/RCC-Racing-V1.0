using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    public int sceneGap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelBtnClicked(int _level)
    {
        Application.LoadLevel(_level+sceneGap);
    }
    public void playBtnClicked()
    {

    }
    public void exitBtnClicked()
    {

    }
}
