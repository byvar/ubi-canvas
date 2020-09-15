using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.COL)]
	public partial class BusMix : CSerializable {
		public StringID name;
		public uint priority;
		public float duration;
		public float fadeIn;
		public float fadeOut;
		public CList<BusDef> busDefs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				name = s.SerializeObject<StringID>(name, name: "name");
				priority = s.Serialize<uint>(priority, name: "priority");
				duration = s.Serialize<float>(duration, name: "duration");
				fadeIn = s.Serialize<float>(fadeIn, name: "fadeIn");
				fadeOut = s.Serialize<float>(fadeOut, name: "fadeOut");
				busDefs = s.SerializeObject<CList<BusDef>>(busDefs, name: "busDefs");
			} else {
				priority = s.Serialize<uint>(priority, name: "priority");
				duration = s.Serialize<float>(duration, name: "duration");
				fadeIn = s.Serialize<float>(fadeIn, name: "fadeIn");
				fadeOut = s.Serialize<float>(fadeOut, name: "fadeOut");
				busDefs = s.SerializeObject<CList<BusDef>>(busDefs, name: "busDefs");
			}
		}
	}
}

