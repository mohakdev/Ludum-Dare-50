using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Player Settings :")]
    private Rigidbody2D mybody;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        //This will move the player right or left depending on the key pressed
        transform.position += new Vector3(inputX, 0f, 0f) * Time.deltaTime * Values.PlayerSpeed;
        //Now for the jump
        if (Input.GetButtonDown("Jump") && Values.JumpEnergy >= 0)
        {
            //This runs when player presses space
            //This code will make player jump
            mybody.AddForce(new Vector2(0f, Values.JumpHeight), ForceMode2D.Impulse);
            Values.SubtractEnergy(20);
        }
    }
}
