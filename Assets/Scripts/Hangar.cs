using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hangar : MonoBehaviour
{
    public Sprite[] sceneHangar;
    public static Sprite[] mainHangar;

    public Sprite[] sceneVerticalEnemies;
    public static Sprite[] verticalEnemies;

    public Sprite[] sceneHorizontalEnemies;
    public static Sprite[] horizontalEnemies;

    public int sceneIndex;
    public static int shipIndex = 0;

    public Image shipDisplay;


    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = 0;
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDisplay()
    {
        shipDisplay.sprite = sceneHangar[sceneIndex];
    }

    public void NextShip()
    {
        if(sceneIndex < sceneHangar.Length - 1)
        {
            sceneIndex++;
        }
        else
        {
            sceneIndex = 0;
        }
        UpdateDisplay();
    }

    public void PreviousShip()
    {
        if(sceneIndex > 0)
        {
            sceneIndex--;
        }
        else
        {
            sceneIndex = sceneHangar.Length - 1;
        }
        UpdateDisplay();
    }
    
    public void Launch()
    {
        shipIndex = sceneIndex;
        verticalEnemies = sceneVerticalEnemies;
        horizontalEnemies = sceneHorizontalEnemies;
        mainHangar = sceneHangar;

        SceneManager.LoadScene("MainLevel");

    }

}
