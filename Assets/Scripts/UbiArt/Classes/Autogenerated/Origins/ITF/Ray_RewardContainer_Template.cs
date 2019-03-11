using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_RewardContainer_Template : CSerializable {
		[Serialize("rewards" )] public Placeholder rewards;
		[Serialize("isSilent")] public bool isSilent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rewards));
			SerializeField(s, nameof(isSilent));
		}
		public override uint? ClassCRC => 0xED6F1313;
	}
}

