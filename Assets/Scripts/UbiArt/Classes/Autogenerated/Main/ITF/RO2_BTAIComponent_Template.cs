using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTAIComponent_Template : BTAIComponent_Template {
		public int health;
		public CArray<uint> damageLevels;
		public bool useHealth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				health = s.Serialize<int>(health, name: "health");
				damageLevels = s.SerializeObject<CArray<uint>>(damageLevels, name: "damageLevels");
				useHealth = s.Serialize<bool>(useHealth, name: "useHealth");
			} else {
				health = s.Serialize<int>(health, name: "health");
				damageLevels = s.SerializeObject<CArray<uint>>(damageLevels, name: "damageLevels");
				damageLevels = s.SerializeObject<CArray<uint>>(damageLevels, name: "damageLevels");
				useHealth = s.Serialize<bool>(useHealth, name: "useHealth");
			}
		}
		public override uint? ClassCRC => 0x3100A2DA;
	}
}

