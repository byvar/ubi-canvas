using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventBossMorayFireMissile : Event {
		[Serialize("bodyPartIndex")] public uint bodyPartIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bodyPartIndex));
		}
		public override uint? ClassCRC => 0x749AD6ED;
	}
}

