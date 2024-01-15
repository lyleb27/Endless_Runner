using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedValue = 10;
    float timePressed = 0f;
    bool spacePressed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis("Jump");

        Vector2 move = new Vector2(0, moveY*2) * Time.deltaTime * speedValue;

        transform.Translate(move);

        if ((transform.position.y > 0) && Input.GetAxis("Jump") == 0)
        {
            transform.Translate(Vector2.down * (speedValue*2) * Time.deltaTime);
        }
        if ((transform.position.y >= 4))
        {
            transform.Translate(Vector2.down * (speedValue * 2) * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            timePressed += Time.deltaTime;
            if (timePressed > 0.5f)
            {
                spacePressed = true;
            }
        }
        else
        {
            timePressed = 0f;
            spacePressed = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            spacePressed = false;
            timePressed = 0f;
        }

        if (spacePressed)
        {
            if (transform.position.y > 0)
            {
                transform.Translate(Vector2.down * (speedValue * 4) * Time.deltaTime);
            }
        }
    }

}
