using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SceneSettingsComponent : CSerializable {
		[Serialize("players")] public Placeholder players;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(players));
			}
		}
		public override uint? ClassCRC => 0x07BE19D2;
	}
}

