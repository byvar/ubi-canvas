using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ShooterStimComponent_Template : CSerializable {
		public Ray_BasicBullet_Template basicBullet;
		public float fxDelayBeforeDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			basicBullet = s.SerializeObject<Ray_BasicBullet_Template>(basicBullet, name: "basicBullet");
			fxDelayBeforeDestroy = s.Serialize<float>(fxDelayBeforeDestroy, name: "fxDelayBeforeDestroy");
		}
		public override uint? ClassCRC => 0xD87DCE99;
	}
}

