using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareController : MonoBehaviour
{
    
         float direction = 1f;
         public float speed = 1f;

        public List<Color> Colors; 

    // Start is called before the first frame update
    void Start()
    {

        Vector3 centerPosition = new Vector3(0, 0, 0);

        //Transform squareTransform = GetComponent<Transform>();


        //squareTransform.transform.position = centerPosition;
        gameObject.transform.position = centerPosition;


    }

    // Update is called once per frame
    void Update()
    {

        Move();

        if (gameObject.transform.position.x > 5 || gameObject.transform.position.x < -5)
        {
            changeDirection();
            changeColor();
        }


    }

    private void changeDirection()
    {
        Debug.Log("byt riktning");
        direction *= -1;
        changeColor();
    }

    private void Move()
    {
        Vector3 position = gameObject.transform.position;

        position.x += direction * speed;

        gameObject.transform.position = position;

    }

    private void changeColor()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        int random = Random.Range(0, Colors.Count);

        spriteRenderer.color = Colors[random];

    }

}
