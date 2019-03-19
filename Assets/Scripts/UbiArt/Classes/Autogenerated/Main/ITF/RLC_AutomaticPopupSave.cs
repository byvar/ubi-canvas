using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AutomaticPopupSave : CSerializable {
		[Serialize("lastShownTimestamp"      )] public online.DateTime lastShownTimestamp;
		[Serialize("nbSessionsSinceLastShown")] public uint nbSessionsSinceLastShown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lastShownTimestamp));
			SerializeField(s, nameof(nbSessionsSinceLastShown));
		}
	}
}

