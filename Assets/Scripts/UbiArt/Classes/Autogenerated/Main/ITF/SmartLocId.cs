using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class SmartLocId : CSerializable {
		[Serialize("defaultText")] public string defaultText;
		[Serialize("locId"      )] public LocalisationId locId;
		[Serialize("useText"    )] public bool useText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultText));
			SerializeField(s, nameof(locId));
			SerializeField(s, nameof(useText));
		}
	}
}

