using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIComponent_Template : ActorComponent_Template {
		[Serialize("registerToAIManager"  )] public bool registerToAIManager;
		[Serialize("faction"              )] public uint faction;
		[Serialize("health"               )] public int health;
		[Serialize("damageLevels"         )] public CArray<uint> damageLevels;
		[Serialize("scaleRandomFactor"    )] public float scaleRandomFactor;
		[Serialize("health"               )] public bool health;
		[Serialize("listenToActivateEvent")] public bool listenToActivateEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(registerToAIManager));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(damageLevels));
				SerializeField(s, nameof(scaleRandomFactor));
				SerializeField(s, nameof(listenToActivateEvent));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(registerToAIManager));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(damageLevels));
				SerializeField(s, nameof(scaleRandomFactor));
			} else {
				SerializeField(s, nameof(registerToAIManager));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(damageLevels));
				SerializeField(s, nameof(scaleRandomFactor));
			}
		}
		public override uint? ClassCRC => 0xE8B7E500;
	}
}

