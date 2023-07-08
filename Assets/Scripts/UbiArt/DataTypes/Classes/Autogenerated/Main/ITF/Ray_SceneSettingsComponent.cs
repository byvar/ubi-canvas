namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SceneSettingsComponent : ActorComponent {
		public CListO<Ray_SceneSettingsComponent.PlayerData> players;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				players = s.SerializeObject<CListO<Ray_SceneSettingsComponent.PlayerData>>(players, name: "players");
			}
		}
		public override uint? ClassCRC => 0x07BE19D2;

		[Games(GameFlags.RO)]
		public class PlayerData : CSerializable {
			public bool active;
			public bool invincible;
			public uint HP;
			public uint maxHP;

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				active = s.Serialize<bool>(active, name: "active");
				invincible = s.Serialize<bool>(invincible, name: "invincible");
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					HP = s.Serialize<uint>(HP, name: "HP");
					maxHP = s.Serialize<uint>(maxHP, name: "maxHP");
				}
			}
		}
	}
}

