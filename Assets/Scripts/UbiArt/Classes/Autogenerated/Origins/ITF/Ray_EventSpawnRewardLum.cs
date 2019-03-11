using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventSpawnRewardLum : Event {
		[Serialize("forceYellow")] public bool forceYellow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(forceYellow));
		}
		public override uint? ClassCRC => 0x306D9812;
	}
}

