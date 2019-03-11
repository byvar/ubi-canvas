using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIUtensilTrapBehavior_Template : CSerializable {
		[Serialize("stickOffset"            )] public float stickOffset;
		[Serialize("speed"                  )] public float speed;
		[Serialize("trapAction"             )] public Placeholder trapAction;
		[Serialize("launchAction"           )] public Placeholder launchAction;
		[Serialize("flyAction"              )] public Placeholder flyAction;
		[Serialize("stickAction"            )] public Placeholder stickAction;
		[Serialize("platformAction"         )] public Placeholder platformAction;
		[Serialize("assignRewardToActivator")] public bool assignRewardToActivator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stickOffset));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(trapAction));
			SerializeField(s, nameof(launchAction));
			SerializeField(s, nameof(flyAction));
			SerializeField(s, nameof(stickAction));
			SerializeField(s, nameof(platformAction));
			SerializeField(s, nameof(assignRewardToActivator));
		}
		public override uint? ClassCRC => 0x555DE807;
	}
}

