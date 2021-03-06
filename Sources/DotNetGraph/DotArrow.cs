﻿/*
 * Copyright (c) 2017 DotNetGraph https://github.com/vfrz/DotNetGraph
 *  This file is part of DotNetGraph.
 *
 *     DotNetGraph is free software: you can redistribute it and/or modify
 *     it under the terms of the GNU General Public License as published by
 *     the Free Software Foundation, either version 3 of the License, or
 *     (at your option) any later version.
 *
 *     DotNetGraph is distributed in the hope that it will be useful,
 *     but WITHOUT ANY WARRANTY; without even the implied warranty of
 *     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *     GNU General Public License for more details.
 *
 *     You should have received a copy of the GNU General Public License
 *     along with DotNetGraph.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace DotNetGraph
{
    public class DotArrow : DotElement
    {
        public string StartNodeName { get; }

        public string TargetNodeName { get; }

        [DotAttribute("arrowhead", DotArrowShape.Normal)]
        public DotArrowShape ArrowHeadShape { get; set; } = DotArrowShape.Normal;

        [DotAttribute("color", DotColor.Black)]
        public DotColor ArrowColor { get; set; } = DotColor.Black;

        [DotAttribute("fontcolor", DotColor.Black)]
        public DotColor FontColor { get; set; } = DotColor.Black;

        [DotAttribute("label", "\n")]
        public string ArrowLabel { get; set; } = "\n";

        public DotArrow(string startNodeName, string targetNodeName)
        {
            StartNodeName = startNodeName;
            TargetNodeName = targetNodeName;
        }

        public DotArrow(DotNode startNode, DotNode targetNode) : this(startNode.Name, targetNode.Name)
        {
        }
    }
}