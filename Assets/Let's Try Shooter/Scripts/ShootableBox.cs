﻿using UnityEngine;
using System.Collections;

public class ShootableBox : MonoBehaviour
{
    public int currentHealth = 5;

    public void Damage(int damageAmount)

    {

        //subtract damage amount when Damage function is called

        currentHealth -= damageAmount;

        //Check if health has fallen below zero

        if (currentHealth <= 0)

        {
            //if health has fallen below zero, deactivate it 

            gameObject.SetActive(false);

        }

    }

}