using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionInstantDeath_Template : BTAction_Template {
		[Serialize("anim"         )] public StringID anim;
		[Serialize("fx"           )] public Path fx;
		[Serialize("spawnOnMarker")] public bool spawnOnMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(spawnOnMarker));
			} else {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(fx));
				SerializeField(s, nameof(spawnOnMarker));
			}
		}
		public override uint? ClassCRC => 0xD3E3066E;
	}
}

