using System;
namespace WordUnscrambler.Data
{
    /* Structs look like classes but they're value types and they're used to
     * organize variables together. */

    public struct MatchedWord
    {
        public string ScrambledWord { get; set; }
        public string Word { get; set; }
    }
}
