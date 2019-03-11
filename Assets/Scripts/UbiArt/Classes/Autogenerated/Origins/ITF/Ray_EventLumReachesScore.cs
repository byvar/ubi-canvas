using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventLumReachesScore : Event {
		[Serialize("isAccrobatic")] public bool isAccrobatic;
		[Serialize("valueToAdd"  )] public uint valueToAdd;
		[Serialize("playerIndex" )] public uint playerIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isAccrobatic));
			SerializeField(s, nameof(valueToAdd));
			SerializeField(s, nameof(playerIndex));
		}
		public override uint? ClassCRC => 0x70289424;
	}
}

