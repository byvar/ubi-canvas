using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_RewardsUserData : CSerializable {
		[Serialize("blackQueenName"      )] public StringID blackQueenName;
		[Serialize("bigSpiderName"       )] public StringID bigSpiderName;
		[Serialize("partnersLevelToReach")] public uint partnersLevelToReach;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(blackQueenName));
			SerializeField(s, nameof(bigSpiderName));
			SerializeField(s, nameof(partnersLevelToReach));
		}
		public override uint? ClassCRC => 0x76AE36B2;
	}
}

