using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TextBubbleBehavior_Template : CSerializable {
		[Serialize("textBoneName")] public StringID textBoneName;
		[Serialize("sleepAction" )] public Placeholder sleepAction;
		[Serialize("openAction"  )] public Placeholder openAction;
		[Serialize("idleAction"  )] public Placeholder idleAction;
		[Serialize("closeAction" )] public Placeholder closeAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textBoneName));
			SerializeField(s, nameof(sleepAction));
			SerializeField(s, nameof(openAction));
			SerializeField(s, nameof(idleAction));
			SerializeField(s, nameof(closeAction));
		}
		public override uint? ClassCRC => 0x11E52943;
	}
}

