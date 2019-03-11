using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AnglerFishBTAIComponent : RO2_EnemyBTAIComponent {
		[Serialize("LightRadiusCoeff")] public float LightRadiusCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LightRadiusCoeff));
		}
		public override uint? ClassCRC => 0xB5AA3B09;
	}
}

