using UnityEngine;

public class Item : MonoBehaviour
{
    private Color normalColor;
    private Color highlightColor;


    void Start()
    {

    }


    void Update()
    {

        /* if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            gameObject.GetComponent<SpriteRenderer>().color = highlightColor;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = normalColor;
        }*/
    }

    public bool survived()
    {
        float i = Random.Range(1, 100);
        Debug.Log(i);
        if (i >= (100 * 1 / 6f))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
