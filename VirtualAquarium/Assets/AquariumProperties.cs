﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquariumProperties : ScriptableObject {

    public static float aquariumTemperature;
    public static float externalTemperature;
    public static float heaterTemperature;
    public static float aquariumHealth;
    public static float lightIntensity;
    public static float externalLightIntensity;
    public static float sensorLightIntensity;
    public static float foodAvailable;
    public static Wheater currentWheater;
    public static DateTime aquariumHour;
    public static TimeSpeed currentTimeSpeed;
    public static float timeSpeedMultiplier;
    public static float lifeLostPerHour = 33.3f;
    public static float temperatureCoefficient;
    public static float lossLifeCoefficient;
    public static float MAX_TEMPERATURE_SUPPORTED = 25.5f;
    public static float MIN_TEMPERATURE_SUPPORTED = 22.5f;
    public static float MIN_LIGHT_SUPPORTED_NIGHT = 0.0f;
    public static float MAX_LIGHT_SUPPORTED_NIGHT = 1.0f;
    public static float MIN_LIGHT_SUPPORTED = 1.0f;
    public static float MAX_LIGHT_SUPPORTED = 2.0f;
    public enum TimeSpeed
    {
        Slow, Normal, Fast, RealTime        
    }
    public enum Wheater
    {
        Sun = 0,  SunAndCloud = 1, Moon = 2, Rain = 3, Snow = 4
    }
}
