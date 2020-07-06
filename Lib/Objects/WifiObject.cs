﻿using System;
namespace AttackSurfaceAnalyzer.Objects
{
    public class WifiObject : CollectObject
    {
        public override string Identity
        {
            get
            {
                return SSID;
            }
        }

        public string SSID { get; }

        public string? Password { get; set; }

        public WifiObject(string SSID)
        {
            this.SSID = SSID;
        }

    }
}
