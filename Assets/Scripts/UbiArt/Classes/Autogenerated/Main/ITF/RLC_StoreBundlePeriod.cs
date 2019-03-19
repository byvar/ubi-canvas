using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_StoreBundlePeriod : CSerializable {
		[Serialize("OpeningTime"           )] public online.DateTime OpeningTime;
		[Serialize("ClosingTime"           )] public online.DateTime ClosingTime;
		[Serialize("DisplayIntervalSeconds")] public uint DisplayIntervalSeconds;
		[Serialize("HideIntervalSeconds"   )] public uint HideIntervalSeconds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OpeningTime));
			SerializeField(s, nameof(ClosingTime));
			SerializeField(s, nameof(DisplayIntervalSeconds));
			SerializeField(s, nameof(HideIntervalSeconds));
		}
	}
}

