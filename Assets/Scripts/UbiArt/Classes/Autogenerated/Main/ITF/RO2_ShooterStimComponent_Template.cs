using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ShooterStimComponent_Template : ActorComponent_Template {
		[Serialize("basicBullet"         )] public RO2_BasicBullet_Template basicBullet;
		[Serialize("fxDelayBeforeDestroy")] public float fxDelayBeforeDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(fxDelayBeforeDestroy));
		}
		public override uint? ClassCRC => 0xEBA11379;
	}
}

