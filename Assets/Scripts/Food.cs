using System;
using System.Collections;
using UnityEngine;

public class Food : Item
{
    #region Variables
    private bool alive;
    SpriteRenderer spr;
    #endregion

    public void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    public void OnMouseUpAsButton()
    {
        if (survived() == true)
        {
            alive = true;
            nextLevel();
        }
        else if (survived() == false)
        {
            alive = false;
            die();
        }
    }

    private void nextLevel()
    {
        StartCoroutine(timer());
    }

    private void die()
    {
        StartCoroutine(timer());
        //Application.Quit();
    }
    private IEnumerator timer()
    {
        if (alive)
        {
            spr.color = Color.green;
        }
        else if (!alive)
        {
            spr.color = Color.red;
        }
        yield return new WaitForSeconds(0.5f);
        spr.color = Color.white;
    }




}
