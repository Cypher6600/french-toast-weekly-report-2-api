﻿using System;

namespace CM.WeeklyTeamReport.Domain
{
    public class Company
    {
        public string Name { get; set; }

        public Company(string name)
        {
            Name = name;
        }
    }
}
