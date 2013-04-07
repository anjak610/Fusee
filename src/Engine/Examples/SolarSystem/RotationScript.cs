﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Fusee.Engine;
using Fusee.SceneManagement;
using Fusee.Math;

namespace Examples.SolarSystem
{
    class RotationScript : ActionCode
    {
        private String[] _planets = { "Earth", "Moon", "Mercury", "Venus", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun", "Sun"};
        private int _currentTargetId = 0;
        private SceneEntity _target;

        public override void Start()
        {
            _target = SceneEntity.FindSceneEntity(_planets[_currentTargetId]);
        }

        public override void Update()
        {
            if(Input.Instance.IsButtonDown(MouseButtons.Left)){
                float mousemoveX = (float)Input.Instance.GetAxis(InputAxis.MouseX);
                float mousemoveY = (float)Input.Instance.GetAxis(InputAxis.MouseY);

                
                transform.GlobalEulerAngles += new float3(0, -mousemoveX*100, 0);
                transform.GlobalEulerAngles += new float3(-mousemoveY*100, 0, 0);
                Debug.WriteLine("GlobalEulerAngles: "+transform.GlobalEulerAngles);
            }

            if (Input.Instance.IsKeyDown(KeyCodes.Up))
            {
                var _timeadd = Time.Instance.TimeFlow;
                if(Time.Instance.TimeFlow > 2)
                {
                    _timeadd += 0.1f;
                }
                else
                {
                    _timeadd += 0.0025f;
                }
         
                Time.Instance.TimeFlow = _timeadd;
            }
            if (Input.Instance.IsKeyDown(KeyCodes.Down))
            {
                if(Time.Instance.TimeFlow >= 0)
                {
                var _timedec = Time.Instance.TimeFlow;

                if (Time.Instance.TimeFlow > 2)
                {
                    _timedec -= 0.1f;
                }
                else
                {
                    _timedec -= 0.0025f;
                }
                Time.Instance.TimeFlow = _timedec;
                   }
                else
                {
                    Time.Instance.TimeFlow = 0;
                }
                //Debug.WriteLine(Time.Instance.TimeFlow.ToString());
            }

            if (Input.Instance.OnKeyDown(KeyCodes.Right))
            {
                _currentTargetId++;
                if(_currentTargetId >= _planets.Length)
                {
                    _currentTargetId = 0;
                }
                Debug.WriteLine("Current id: "+_currentTargetId);
                
                _target = SceneEntity.FindSceneEntity(_planets[_currentTargetId]);
                
            }

            if (Input.Instance.OnKeyDown(KeyCodes.Left))
            {
                _currentTargetId--;
                if (_currentTargetId <= 0)
                {
                    _currentTargetId = _planets.Length-1;
                }
                Debug.WriteLine("Current id: " + _currentTargetId);

                _target = SceneEntity.FindSceneEntity(_planets[_currentTargetId]);

            }
            transform.GlobalPosition = _target.transform.GlobalPosition;
        }
    }
}