using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionGhost_Template : BTAction_Template {
		[Serialize("animFlyOpen"   )] public StringID animFlyOpen;
		[Serialize("animFlyClosed" )] public StringID animFlyClosed;
		[Serialize("sparklesFxName")] public StringID sparklesFxName;
		[Serialize("speed"         )] public float speed;
		[Serialize("distMax"       )] public float distMax;
		[Serialize("isOnFire"      )] public bool isOnFire;
		[Serialize("isStatic"      )] public bool isStatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animFlyOpen));
			SerializeField(s, nameof(animFlyClosed));
			SerializeField(s, nameof(sparklesFxName));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(distMax));
			SerializeField(s, nameof(isOnFire));
			SerializeField(s, nameof(isStatic));
		}
		public override uint? ClassCRC => 0xC0A90EFA;
	}
}

