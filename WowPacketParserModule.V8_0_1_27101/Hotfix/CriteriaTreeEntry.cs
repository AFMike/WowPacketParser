using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CriteriaTree, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_3_0_33062, HasIndexInData = false)]
    public class CriteriaTreeEntry
    {
        public string Description { get; set; }
        public uint Parent { get; set; }
        public uint Amount { get; set; }
        public sbyte Operator { get; set; }
        public uint CriteriaID { get; set; }
        public int OrderIndex { get; set; }
        public short Flags { get; set; }
    }
}
