using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_AutomaticPopupCondition : CSerializable {
		[Serialize("timeSinceLastShown"    )] public online.TimeInterval timeSinceLastShown;
		[Serialize("sessionsSinceLastShown")] public uint sessionsSinceLastShown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeSinceLastShown));
			SerializeField(s, nameof(sessionsSinceLastShown));
		}
	}
}

