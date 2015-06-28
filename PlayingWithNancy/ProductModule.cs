using System;
using Nancy;
using System.Collections.Generic;

namespace PlayingWithNancy
{
    public class ProductModule : NancyModule
    {
        List<string> _products = new List<string>() { "one", "two", "tree"};

        public ProductModule() : base("products")
        {
            Get["list"] = _ => string.Join(", ", _products);
        }
    }
}