﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter.FollowCamera
{
    public class FollowCamera : MonoBehaviour
    {
        public Transform target;

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}