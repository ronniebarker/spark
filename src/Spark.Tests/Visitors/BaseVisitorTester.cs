﻿// Copyright 2008 Louis DeJardin - http://whereslou.com
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spark.Compiler.NodeVisitors;
using Spark.Parser;
using Spark.Parser.Markup;

namespace Spark.Tests.Visitors
{
    public class BaseVisitorTester
    {
        MarkupGrammar _grammar = new MarkupGrammar();
        protected IEnumerable<Paint> _paint;
        

        public IList<Node> ParseNodes(string content, params AbstractNodeVisitor[] visitors)
        {
            var result = _grammar.Nodes(new Position(new SourceContext(content)));
            _paint = result.Rest.GetPaint();
            var nodes = result.Value;
            foreach(var visitor in visitors)
            {
                visitor.Accept(nodes);
                nodes = visitor.Nodes;
            }
            return nodes;
        }
    }
}