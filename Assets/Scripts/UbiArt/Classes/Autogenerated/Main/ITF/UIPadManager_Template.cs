using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class UIPadManager_Template : TemplateObj {
		[Serialize("snapDistanceWeight")] public float snapDistanceWeight;
		[Serialize("snapDeadAngle"     )] public float snapDeadAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(snapDistanceWeight));
			SerializeField(s, nameof(snapDeadAngle));
		}
		public override uint? ClassCRC => 0x3ED7DB9C;
	}
}

