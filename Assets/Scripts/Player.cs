using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float ySpeed;
    public float yTarget;
    public GameObject soundBounce;
    public Rigidbody rb;
    public Text scoreText;

    void Start()
    {
        rb.GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        transform.Translate(0, ySpeed, 0);
        ySpeed = Mathf.Lerp(ySpeed, yTarget, 0.25f);

        // press space to make player fly //
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(soundBounce, transform.position, transform.rotation);
            ySpeed = 0.5f;
            rb.AddForce(new Vector3(0, 150, 0));
            thisAnimation.Play();
        }

        // check if player is above screen //
    }
}
