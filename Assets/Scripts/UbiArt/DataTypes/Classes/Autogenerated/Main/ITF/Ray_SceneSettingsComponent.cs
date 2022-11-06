using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SceneSettingsComponent : CSerializable {
		public Placeholder players;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				players = s.SerializeObject<Placeholder>(players, name: "players");
			}
		}
		public override uint? ClassCRC => 0x07BE19D2;
	}
}

