using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTAIComponent_Template : BTAIComponent_Template {
		[Serialize("health"      )] public int health;
		[Serialize("damageLevels")] public CArray<uint> damageLevels;
		[Serialize("useHealth"   )] public bool useHealth;
		[Serialize("health"      )] public bool health;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(damageLevels));
				SerializeField(s, nameof(useHealth));
			} else {
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(damageLevels));
				SerializeField(s, nameof(useHealth));
			}
		}
		public override uint? ClassCRC => 0x3100A2DA;
	}
}

