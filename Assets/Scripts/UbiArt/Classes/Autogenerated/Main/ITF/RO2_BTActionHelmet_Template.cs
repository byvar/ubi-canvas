using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionHelmet_Template : BTAction_Template {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("anim"               )] public StringID anim;
		[Serialize("useBone"            )] public bool useBone;
		[Serialize("boneName"           )] public StringID boneName;
		[Serialize("debug"              )] public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(useBone));
			SerializeField(s, nameof(boneName));
			SerializeField(s, nameof(debug));
		}
		public override uint? ClassCRC => 0xD074F292;
	}
}

