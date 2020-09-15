using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreatureTreeTier : CSerializable {
		public uint NbFamilySmall;
		public uint NbfamilyBig;
		public TreeInOut TreeIN;
		public TreeInOut TreeOUT;
		public TreeStyle TreeTierStyle;
		public Path TreeTierPath;
		public float TreeTierSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			NbFamilySmall = s.Serialize<uint>(NbFamilySmall, name: "NbFamilySmall");
			NbfamilyBig = s.Serialize<uint>(NbfamilyBig, name: "NbfamilyBig");
			TreeIN = s.Serialize<TreeInOut>(TreeIN, name: "TreeIN");
			TreeOUT = s.Serialize<TreeInOut>(TreeOUT, name: "TreeOUT");
			TreeTierStyle = s.Serialize<TreeStyle>(TreeTierStyle, name: "TreeTierStyle");
			TreeTierPath = s.SerializeObject<Path>(TreeTierPath, name: "TreeTierPath");
			TreeTierSize = s.Serialize<float>(TreeTierSize, name: "TreeTierSize");
		}
		public enum TreeInOut {
			[Serialize("TreeInOut::Left" )] Left = 0,
			[Serialize("TreeInOut::Mid"  )] Mid = 1,
			[Serialize("TreeInOut::Right")] Right = 2,
		}
		public enum TreeStyle {
			[Serialize("TreeStyle::Normal")] Normal = 1,
			[Serialize("TreeStyle::Winter")] Winter = 2,
			[Serialize("TreeStyle::Burned")] Burned = 4,
		}
		public override uint? ClassCRC => 0xFED37AA2;
	}
}

