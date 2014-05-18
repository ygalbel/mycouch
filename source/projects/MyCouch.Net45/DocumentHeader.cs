using System;

namespace MyCouch
{
#if !PCL
    [Serializable]
#endif
    public class DocumentHeader
    {
        public string Id { get; private set; }
        public string Rev { get; private set; }

        public DocumentHeader(string id, string rev)
        {
            Id = id;
            Rev = rev;
        }
    }
}