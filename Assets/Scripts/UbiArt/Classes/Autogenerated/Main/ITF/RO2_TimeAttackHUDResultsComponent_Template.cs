using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TimeAttackHUDResultsComponent_Template : ActorComponent_Template {
		[Serialize("scale"        )] public float scale;
		[Serialize("boneTimer"    )] public StringID boneTimer;
		[Serialize("boneCup"      )] public StringID boneCup;
		[Serialize("boneElectoons")] public StringID boneElectoons;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(boneTimer));
			SerializeField(s, nameof(boneCup));
			SerializeField(s, nameof(boneElectoons));
		}
		public override uint? ClassCRC => 0xB4EE7F00;
	}
}

