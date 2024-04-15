﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artJam
{
    internal class Packet
    {
        public int Code { get; set; }
        public string Username { get; set; }
        public string RoomID { get; set; }
        public string PenColor { get; set; }
        public float PenWidth { get; set; }
        public int ShapeTag {  get; set; }
        public List<Point> Points_1 { get; set; }
        public List<Point> Points_2 { get; set; }
        public float[] Position { get; set; }
    }
}
