using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionBlowing_Template : BTAction_Template {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("blowingUp"          )] public bool blowingUp;
		[Serialize("modeAuto"           )] public bool modeAuto;
		[Serialize("blowingTime"        )] public float blowingTime;
		[Serialize("coolDown"           )] public float coolDown;
		[Serialize("animStand"          )] public StringID animStand;
		[Serialize("animAnticip"        )] public StringID animAnticip;
		[Serialize("animLoop"           )] public StringID animLoop;
		[Serialize("debug"              )] public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(blowingUp));
			SerializeField(s, nameof(modeAuto));
			SerializeField(s, nameof(blowingTime));
			SerializeField(s, nameof(coolDown));
			SerializeField(s, nameof(animStand));
			SerializeField(s, nameof(animAnticip));
			SerializeField(s, nameof(animLoop));
			SerializeField(s, nameof(debug));
		}
		public override uint? ClassCRC => 0x0E306971;
	}
}

