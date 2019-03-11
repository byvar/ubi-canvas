using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_RewardTrigger_FinishLevel : CSerializable {
		[Serialize("worldTag")] public StringID worldTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(worldTag));
		}
		public override uint? ClassCRC => 0x914154F5;
	}
}

