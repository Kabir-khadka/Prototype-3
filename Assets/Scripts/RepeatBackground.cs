using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    private Vector3 startPos;
    private float repeatWidth;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assigning the default transform position value to startPos variable
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {

        //using offset logic inside IF statement to reset the background running position
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
        
    }
}
