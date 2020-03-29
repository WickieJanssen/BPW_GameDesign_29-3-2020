using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Generaal
    public bool cursor;
    public float minGold;
    public bool dead;

    //Bewegen en springen
    public float moveSpeed;
    public float jumpForce;
    public float gravityScale;
    public bool doubleJump = false;

    //Dash
    public float maxDashTime = 2f;
    public float dashSpeed = 15f;
    public float dashStoppingSpeed = 0.05f;
    public float normalSpeed = 10f;
    public float dashMeter;
    //public ParticleSystem particle;

    private float currentDashTime;

    //Rest
    private Vector3 moveDirection;
    public Transform player;
    public CharacterController cc;
    
    void Start()
    {
        //Pakt het component CharacterController(voor het bewegen)
        cc = GetComponent<CharacterController>();

        //als de boolean cursor aanstaat dan kan je de cursor niet zien.
        if (cursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        //Je begint met dezelfde currentDashTime als maxDashTime zodat je niet dashent begint.
        currentDashTime = maxDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!cc.isGrounded)
        {
            //de currentDashTime word verhoogt met 2*Time.deltaTime wat 2 per seconde betekend
            currentDashTime += 2f * Time.deltaTime;

            moveSpeed = normalSpeed;
            //als je de LeftShift(linker shift) inhoud dan word de currentDashTime 0
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                currentDashTime = 0;
               
            }

            //als de currentDashTime kleiner is dan de maxDashTime dan word de moveSpeed de dashSpeed
            if (currentDashTime < maxDashTime)
            {
                moveSpeed = dashSpeed;
                //particle.Emit(1);
            }
            //anders dus als de currentDashTime groter is dan de maxDashTime dan word de moveSpeed de normalSpeed
            else
            {
                moveSpeed = normalSpeed;
                //particle.Emit(0);
            }
        }
        else
        {
            moveSpeed = normalSpeed;
        }
        //stuur de currentDashTime naar de GameManager
        //FindObjectOfType<GameManager>().CanDash(currentDashTime);

        /* De dash werk zo: de currentDashTime blijft omhoog gaan maar als je shift indrukt word die 0. Zolang die onder de 2 blijft dan ga je sneller, maar na 1seconden kan je niet meer
         * dashen. Het probleem is dat als je hier leftShift spamt dat je dan oneindig kan dashen.
         */

        //-----------------------------------------------------------------------------------------

        // De moveDirection = de input van de muis om te kijken welke kant je opgaat * de movespeed 
        float yStore = moveDirection.y;
        moveDirection = (transform.forward * Input.GetAxis("Vertical"))  + (transform.right * Input.GetAxis("Horizontal"));
        moveDirection = moveDirection * moveSpeed;
        moveDirection.y = yStore;

        /* Als je op de grond staat dan is de doubleJump niet waar en de waarmee je omhoog beweegt 0. als je een Jump knop indrukt dan ga je met de jumpForce kracht omhoog
         * en is de doublejump waar. En als de doubleJump waar is dan kan je in de lucht nog een keer springen.
         */

        //-----------------------------------------------------------------------------------------

        if (cc.isGrounded)
        {
            doubleJump = false;
            moveDirection.y = 0f;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpForce;
                doubleJump = true;
            }
        }
        else
        {
            if (doubleJump && Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
                doubleJump = false;
            }
        }

        //-----------------------------------------------------------------------------------------

        if (cc.transform.position.y < 0)
        {
            gravityScale = 2.5f;
        }

        //-----------------------------------------------------------------------------------------

        // De kracht waarmee je springt word met de Physics van de zwaartekracht, de schaal van de zwaartekracht en hoeveel seconden ervoorbij zijn gegaan sinds het laatste frame.
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        // De character controller beweegt met de moveDirection keer de hoeveel seconden ervoorbij zijn gegaan sinds het laatste frame.
        cc.Move(moveDirection * Time.deltaTime);
    }
    public void Swim (bool swim)
    {
        if (swim)
        {
            gravityScale = 3;
        }
    }
    public void Jump(bool jump) {
        if (!jump)
        {
            jumpForce = 0;
        }
        else
        {
            jumpForce = 15;
        }
    }

    public void Dash(bool dash)
    {
        if (!dash)
        {
            dashSpeed = 10;
        }
        else
        {
            dashSpeed = 20f;
        }
    }
}
