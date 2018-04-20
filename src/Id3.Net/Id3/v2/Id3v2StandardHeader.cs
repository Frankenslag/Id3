#region --- License & Copyright Notice ---
/*
Copyright (c) 2005-2012 Jeevan James
All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion

namespace Id3.v2
{
    public sealed class Id3V2Header
    {
        public Id3V2StandardHeader Header { get; internal set; }

        public Id3V2ExtendedHeader ExtendedHeader { get; internal set; }
    }

    public sealed class Id3V2StandardHeader
    {
        public bool Experimental { get; internal set; }

        public bool ExtendedHeader { get; internal set; }

        public int Revision { get; internal set; }

        public bool Unsyncronization { get; internal set; }
    }

    public sealed class Id3V2ExtendedHeader
    {
        public int Crc32 { get; internal set; }

        public int PaddingSize { get; internal set; }
    }
}