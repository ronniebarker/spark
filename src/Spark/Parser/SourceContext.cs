// Copyright 2008-2009 Louis DeJardin - http://whereslou.com
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
namespace Spark.Parser
{
    public class SourceContext
    {
        public SourceContext(string content)
        {
            Content = content;
        }
        public SourceContext(string content, long lastModified)
        {
            Content = content;
            LastModified = lastModified;
        }

        public SourceContext(string content, long lastModified, string fileName)
        {
            Content = content;
            LastModified = lastModified;
            FileName = fileName;
        }


        public string Content { get; set; }
        public long LastModified { get; set; }
        public string FileName { get; set; }
    }
}
