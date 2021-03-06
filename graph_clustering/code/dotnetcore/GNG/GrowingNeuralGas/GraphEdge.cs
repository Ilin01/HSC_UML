﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNG
{
    public class GraphEdge
    {
        private GraphNode head = null;
        private GraphNode tail = null;
        private int age = 0;


        public GraphEdge(GraphNode head, GraphNode tail)
        {
            this.head = head;
            this.tail = tail;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public void incAge()
        {
            this.age += 1;
        }

        public GraphNode[] getEnds()
        {
            GraphNode[] ends = new GraphNode[2];
            ends[0] = this.head;
            ends[1] = this.tail;
            return ends;
        }

        public GraphNode getTail()
        {
            return this.tail;
        }

        public GraphNode getHead()
        {
            return this.head;
        }
    }
}
