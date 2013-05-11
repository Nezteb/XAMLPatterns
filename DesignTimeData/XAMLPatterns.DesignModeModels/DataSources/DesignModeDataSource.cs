﻿using System;
using XAMLPatterns.DesignModeModels.Models;
using XAMLPatterns.DesignModeModels.ViewModels;

namespace XAMLPatterns.DesignModeModels.DataSources
{
    public class DesignModeDataSource
    {
        private Track _track;

        public DesignModeDataSource()
        {
            _track = new Track { Name = "Web" };
            var thePapasan = new Room { Name = "The Papasan" };
            _track.AddSession(new Session(new Speaker { Name = "Brian Sullivan" })
            {
                Title = "Real-Time Web Programming with SignalR",
                Room = thePapasan,
                Time = new DateTime(2013, 3, 15, 16, 0, 0),
                Description =
                    "Web programming has always been a one-way conversation; " +
                    "a client calls a server and the server sends a response. " +
                    "But what if you could go the other direction? What if your " +
                    "server could call your client directly? No more inefficient " +
                    "polling. No more waiting for the next server poll to get your " +
                    "data; the server sends it as soon as it has it. Using a " +
                    "variety of techniques behind the scenes to smooth over the " +
                    "rough edges of dealing with variously capable browsers and " +
                    "web servers, SignalR makes real-time client-server communication " +
                    "ridiculously easy. Come see how this new library opens up a ton " +
                    "of possibilities for interactive and collaborative web " +
                    "applications."
            });
            _track.AddSession(new Session(new Speaker { Name = "Eric Sowell" })
            {
                Title = "Touchy Browser Applications",
                Room = thePapasan,
                Time = new DateTime(2013, 3, 15, 9, 0, 0)
            });
            _track.AddSession(new Session(new Speaker { Name = "Rob Vettor" })
            {
                Title = "Getting Started with ASP.NET MVC4",
                Room = thePapasan,
                Time = new DateTime(2013, 3, 15, 10, 30, 0)
            });
        }
    }
}
