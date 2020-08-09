﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooter.PlayerController;
using System;

namespace Shooter.PlayerController
{
    public class CreateWeapon : MonoBehaviour
    {
        [SerializeField] private Transform weaponPoint;
        [SerializeField] private Weapon weaponPrefab0, weaponPrefab1, weaponPrefab2;
        private Dictionary<Slot, Weapon> libraryOfWeapons = new Dictionary<Slot, Weapon>();
        public void Create()
        {
            Weapon weapon0 = Instantiate(weaponPrefab0, weaponPoint);
            weapon0.InitializeWeapon();
            Weapon weapon1 = Instantiate(weaponPrefab1, weaponPoint);
            weapon1.InitializeWeapon();
            Weapon weapon2 = Instantiate(weaponPrefab2, weaponPoint);
            weapon2.InitializeWeapon();
            libraryOfWeapons.Add(Slot.First, weapon0);
            libraryOfWeapons.Add(Slot.Second, weapon1);
            libraryOfWeapons.Add(Slot.Third, weapon2);
            weapon1.gameObject.SetActive(false);
            Switch(Slot.First);
            
        }

        Weapon currentWeapon;
        
        public void Switch(Slot slot)
        {
            if (currentWeapon != null) { currentWeapon.gameObject.SetActive(false); }
            Weapon weapon = libraryOfWeapons[slot];
            currentWeapon = weapon;
            currentWeapon.gameObject.SetActive(true);
            //weapon.gameObject.SetActive(false);

            //Debug.Log(currentWeapon == weapon);

            //currentWeapon.gameObject.SetActive(true);
            Debug.Log(slot);
            
            
        }


        public enum Slot
        {
            First, Second, Third
        }
    }
}