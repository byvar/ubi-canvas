using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_AIJanodRoamingBaseBehavior_Template : TemplateAIBehavior {
		[Serialize("uint__0" )] public uint uint__0;
		[Serialize("float__1")] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0x97348F71;
	}
}

