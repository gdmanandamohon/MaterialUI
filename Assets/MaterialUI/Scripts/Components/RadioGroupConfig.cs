﻿//  Copyright 2014 Invex Games http://invexgames.com
//	Licensed under the Apache License, Version 2.0 (the "License");
//	you may not use this file except in compliance with the License.
//	You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
//	Unless required by applicable law or agreed to in writing, software
//	distributed under the License is distributed on an "AS IS" BASIS,
//	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//	See the License for the specific language governing permissions and
//	limitations under the License.

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace MaterialUI
{
	public class RadioGroupConfig : MonoBehaviour
	{
		public bool inkBlotEnabled = true;
		public bool autoInkBlotSize = true;
		public int inkBlotSize;
		public float inkBlotSpeed = 8f;
		public Color inkBlotColor = Color.black;
		public float inkBlotStartAlpha = 0.5f;
		public float inkBlotEndAlpha = 0.3f;
		public float animationDuration = 0.5f;
		public Color radioOnColor = Color.black;

		void Start ()
		{
			foreach (RadioConfig config in gameObject.GetComponentsInChildren<RadioConfig> ())
			{
				config.inkBlotEnabled = inkBlotEnabled;
				config.autoInkBlotSize = autoInkBlotSize;
				config.inkBlotSize = inkBlotSize;
				config.inkBlotSpeed = inkBlotSpeed;
				config.inkBlotColor = inkBlotColor;
				config.inkBlotStartAlpha = inkBlotStartAlpha;
				config.inkBlotEndAlpha = inkBlotEndAlpha;
				config.animationDuration = animationDuration;
				config.radioOnColor = radioOnColor;

				config.Setup ();
			}
		}
	}
}