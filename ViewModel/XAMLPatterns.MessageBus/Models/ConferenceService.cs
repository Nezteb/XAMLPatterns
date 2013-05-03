﻿using System.Collections.Generic;

namespace XAMLPatterns.MessageBus.Models
{
    public class ConferenceService
    {
        private List<Session> _sessions;

        public ConferenceService()
        {
            _sessions = new List<Session>
            {
                new Session
                {
                    Id = 1,
                    Speaker = "Brian Sullivan",
                    Title = "Real-Time Web Programming with SignalR"
                },
                new Session
                {
                    Id = 2,
                    Speaker = "Caleb Jenkins",
                    Title = "Coding Naked - TDD on the Edge"
                },
                new Session
                {
                    Id = 3,
                    Speaker = "Casey Watson",
                    Title = "Building Massively Scalable Applications with Windows Azure"
                },
                new Session
                {
                    Id = 4,
                    Speaker = "Eric Sowell",
                    Title = "Touchy Browser Applications"
                },
                new Session
                {
                    Id = 5,
                    Speaker = "Latish Sehgal",
                    Title = "The .NET Ninja's Toolbelt"
                }
            };
        }

        public List<Session> GetSessions()
        {
            return _sessions;
        }
    }
}
