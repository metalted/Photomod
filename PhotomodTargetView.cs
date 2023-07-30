using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Photomod
{
    public class PhotomodTargetView
    {
        private Vector3 previousPosition;
        private float previousTime;
        private float updateDelay = 0.1f;
        private float timer = 0f;

        public bool armsUp = false;
        public bool brake = false;
        public float steering_axis = 0f;
        public float speed;
        public bool wheelLF_dead = false;
        public bool wheelRF_dead = false;
        public bool wheelLR_dead = false;
        public bool wheelRR_dead = false;

        public void Reset()
        {
            previousPosition = Vector3.zero;
            previousTime = Time.time;
            timer = 0f;
        }

        public void Update(SpectatorZeepkistTarget target)
        {
            if (target.ghost == null || target.transform == null)
            {
                Reset();
                return;
            }

            armsUp = target.ghost.armsUp;
            brake = target.ghost.brake;
            steering_axis = target.ghost.steer;
            wheelLF_dead = target.ghost.frontLeftDead;
            wheelRF_dead = target.ghost.frontRightDead;
            wheelLR_dead = target.ghost.rearLeftDead;
            wheelRR_dead = target.ghost.rearRightDead;

            timer += Time.deltaTime;

            if (timer >= updateDelay)
            {
                Vector3 currentPosition = target.transform.position;
                float currentTime = Time.time;
                float distance = Vector3.Distance(currentPosition, previousPosition);
                float timeElapsed = currentTime - previousTime;
                speed = (distance / timeElapsed) * 3.6f;
                previousPosition = currentPosition;
                previousTime = currentTime;
                timer = 0f;
            }
        }
    }
}
