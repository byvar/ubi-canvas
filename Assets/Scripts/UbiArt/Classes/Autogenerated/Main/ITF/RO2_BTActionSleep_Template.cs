using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionSleep_Template : BTAction_Template {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("animSleep"          )] public StringID animSleep;
		[Serialize("animWakeUp"         )] public StringID animWakeUp;
		[Serialize("animGotoSleep"      )] public StringID animGotoSleep;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(animSleep));
			SerializeField(s, nameof(animWakeUp));
			SerializeField(s, nameof(animGotoSleep));
		}
		public override uint? ClassCRC => 0xE9104191;
	}
}

