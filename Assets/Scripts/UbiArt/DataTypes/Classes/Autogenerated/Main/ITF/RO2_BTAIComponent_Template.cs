using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTAIComponent_Template : BTAIComponent_Template {
		public int health;
		public CArrayP<uint> damageLevels;
		public bool useHealth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			health = s.Serialize<int>(health, name: "health");
			damageLevels = s.SerializeObject<CArrayP<uint>>(damageLevels, name: "damageLevels");
			useHealth = s.Serialize<bool>(useHealth, name: "useHealth");
		}
		public override uint? ClassCRC => 0x3100A2DA;
	}
}

