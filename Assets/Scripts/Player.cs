using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class Player : MonoBehaviour {
    private float PlayerMaxHealth = 1000;
    public float PlayerHealth = 1000;
    public Image PlayerHealthBar;
    private float playermaxstamina = 100;
    public float PlayerStamina = 100;
    public Image PlayerStaminaBar;
    public bool canmove;


    // Use this for initialization
    void Start() {
        canmove = true;
        

    }

    // Update is called once per frame
    void Update() {
        
        PlayerStaminaBar.fillAmount = PlayerStamina / playermaxstamina;

        
        if (PlayerStamina > 0)
        {
            canmove = true;
        }
        if (Input.GetKey(KeyCode.W) && canmove == true && PlayerStamina > 0)
        {
            transform.Translate(0.1f, 0, 0);
            decreasestamina();

        }
       else if (Input.GetKey(KeyCode.S) && canmove == true && PlayerStamina > 0)
        {
            transform.Translate(-0.1f, 0, 0);
            decreasestamina();

        }
       else if (Input.GetKey(KeyCode.D) && canmove == true && PlayerStamina > 0)
        {
            transform.Translate(0, 0, 0.1f);
            decreasestamina();

        }
      else  if (Input.GetKey(KeyCode.A) && canmove == true && PlayerStamina > 0)
        {
            transform.Translate(0, 0, -0.1f);
            decreasestamina();

        }
        else if (PlayerStamina != 100)
        {
            canmove = false;
            PlayerStamina++;
        }



    }
   
    private void decreasestamina()
    {
        PlayerStamina-=2;
        PlayerStaminaBar.fillAmount = PlayerStamina / playermaxstamina;

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("enemy_attack"))
        {

            PlayerHealth -= 50;
            PlayerHealthBar.fillAmount = PlayerHealth / PlayerMaxHealth;


        }
            else if (PlayerHealth <= 0)
            {


                Debug.Log("death");
            }
        }
    }






