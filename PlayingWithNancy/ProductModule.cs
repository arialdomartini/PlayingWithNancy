using System;
using Nancy;

namespace PlayingWithNancy
{
    public class ProductModule : NancyModule
    {
        public ProductModule() : base("products")
        {
            Get["list"] = _ => { return "List of values"; };
        }
    }
}