using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_CreatureTreeTier : CSerializable {
		[Serialize("NbFamilySmall")] public uint NbFamilySmall;
		[Serialize("NbfamilyBig"  )] public uint NbfamilyBig;
		[Serialize("TreeIN"       )] public TreeInOut TreeIN;
		[Serialize("TreeOUT"      )] public TreeInOut TreeOUT;
		[Serialize("TreeTierStyle")] public TreeStyle TreeTierStyle;
		[Serialize("TreeTierPath" )] public Path TreeTierPath;
		[Serialize("TreeTierSize" )] public float TreeTierSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(NbFamilySmall));
			SerializeField(s, nameof(NbfamilyBig));
			SerializeField(s, nameof(TreeIN));
			SerializeField(s, nameof(TreeOUT));
			SerializeField(s, nameof(TreeTierStyle));
			SerializeField(s, nameof(TreeTierPath));
			SerializeField(s, nameof(TreeTierSize));
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

