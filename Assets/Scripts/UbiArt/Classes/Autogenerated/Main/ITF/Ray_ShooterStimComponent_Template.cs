using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterStimComponent_Template : CSerializable {
		[Serialize("basicBullet"         )] public Ray_BasicBullet_Template basicBullet;
		[Serialize("fxDelayBeforeDestroy")] public float fxDelayBeforeDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(basicBullet));
			SerializeField(s, nameof(fxDelayBeforeDestroy));
		}
		public override uint? ClassCRC => 0xD87DCE99;
	}
}

