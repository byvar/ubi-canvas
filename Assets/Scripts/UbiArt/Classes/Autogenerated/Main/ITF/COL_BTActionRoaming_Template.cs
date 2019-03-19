using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionRoaming_Template : CSerializable {
		[Serialize("name"        )] public StringID name;
		[Serialize("animWalk"    )] public StringID animWalk;
		[Serialize("animUTurn"   )] public StringID animUTurn;
		[Serialize("animIdle"    )] public StringID animIdle;
		[Serialize("idleDuration")] public float idleDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(animWalk));
			SerializeField(s, nameof(animUTurn));
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(idleDuration));
		}
		public override uint? ClassCRC => 0x8FF18741;
	}
}

