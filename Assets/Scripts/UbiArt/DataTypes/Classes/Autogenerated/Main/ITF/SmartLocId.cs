using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class SmartLocId : CSerializable {
		public string defaultText;
		public LocalisationId locId;
		public bool useText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultText = s.Serialize<string>(defaultText, name: "defaultText");
			locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
			useText = s.Serialize<bool>(useText, name: "useText");
		}
	}
}

