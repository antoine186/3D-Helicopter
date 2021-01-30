﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_BaseHeli_Input : MonoBehaviour
    {
        #region Variables
        [Header("Base Input Properties")]
        public float vertical = 0f;
        public float horizontal = 0f;
        #endregion

        #region Built-in Methods
        // Update is called once per frame
        void Update()
        {
            HandleInputs();
        }
        #endregion

        #region Custom Methods
        protected virtual void HandleInputs()
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
        }
        #endregion
    }
}
