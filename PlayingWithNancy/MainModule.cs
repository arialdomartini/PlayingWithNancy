using System;
using Nancy;

namespace PlayingWithNancy
{    
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => { return "Nancy says hello!"; };
        }
    }
}
