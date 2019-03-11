using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SpecificBounceComponent_Template : ActorComponent_Template {
		[Serialize("ejectSpeedMultiplier")] public float ejectSpeedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ejectSpeedMultiplier));
		}
		public override uint? ClassCRC => 0x4A60EA60;
	}
}

