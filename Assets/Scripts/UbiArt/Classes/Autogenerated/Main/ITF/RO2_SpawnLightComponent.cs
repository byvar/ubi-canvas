using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SpawnLightComponent : ActorComponent {
		[Serialize("LightRadiusCoeff")] public float LightRadiusCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LightRadiusCoeff));
		}
		public override uint? ClassCRC => 0x6C86602A;
	}
}

