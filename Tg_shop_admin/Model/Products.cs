﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tg_shop_admin.Model
{
    internal class Products
    {
        public int id { get; set; }
        public byte[] img { get; set; } 
        public string Name { get; set; }
        public int Cost { get; set; }
        //public override string ToString()
        //{
        //    return Name;
        //}
        public override string ToString()
        {
            return string.Format("id: {0}\timg: {1}\tName: {2}\tCost: {3}", id, img, Name, Cost);
        }
        public Products(int iD ,byte[] image, string name,int cost)
        {
            id = iD;
            img = image;
            Name = name;
            Cost = cost;
        }
    }
    
}
