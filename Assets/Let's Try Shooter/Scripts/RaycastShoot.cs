﻿using UnityEngine;

using System.Collections;

public class RaycastShoot : MonoBehaviour
{

    public int gunDamage = 1;

    public float fireRate = .25f;

    public float weaponRange = 50f;

    public float hitForce = 100f;

    public Transform gunEnd;





    private Camera fpsCam;

    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);

    private AudioSource gunAudio;

    private LineRenderer laserLine;

    private float nextFire;



    void Start()

    {

        laserLine = GetComponent<LineRenderer>();
        gunAudio = GetComponent<AudioSource>();
        fpsCam = GetComponentInParent<Camera>();


    }

    void Update()

    {



    }

}