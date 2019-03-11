using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_CreatureTreeTierComponent : ActorComponent {
		[Serialize("isTrunk")] public bool isTrunk;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isTrunk));
		}
		public override uint? ClassCRC => 0x23EA5FC6;
	}
}

