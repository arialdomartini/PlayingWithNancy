using System;
using Nancy;
using System.Collections.Generic;

namespace PlayingWithNancy
{
    public class ProductModule : NancyModule
    {
        readonly List<string> _products = new List<string>() { "one", "two", "tree"};

        public ProductModule() : base("products")
        {
            Get["list"] = _ => List();
            Get["info/{name}"] = paramters => PrintProductName(paramters.name);
        }

        string List()
        {
            return string.Join(", ", _products);
        }

        string PrintProductName(string name)
        {
            return string.Format("The product name is {0}", name);
        }
    }
}