﻿/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;


namespace PriorityQueueProject
{
    class Node
    {
        public int priority;
        public int info;
        public Node link;

        public Node(int i, int pr)
        {
            info = i;
            priority = pr;
            link = null;
        }
    }
}
