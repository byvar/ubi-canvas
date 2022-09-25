using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIComponent_Template : ActorComponent_Template {
		public bool registerToAIManager;
		public uint faction;
		public int health;
		public CArrayP<uint> damageLevels;
		public float scaleRandomFactor;
		public int listenToActivateEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RJR) {
				registerToAIManager = s.Serialize<bool>(registerToAIManager, name: "registerToAIManager");
				faction = s.Serialize<uint>(faction, name: "faction");
				health = s.Serialize<int>(health, name: "health");
				damageLevels = s.SerializeObject<CArrayP<uint>>(damageLevels, name: "damageLevels");
				scaleRandomFactor = s.Serialize<float>(scaleRandomFactor, name: "scaleRandomFactor");
				listenToActivateEvent = s.Serialize<int>(listenToActivateEvent, name: "listenToActivateEvent");
			} else {
				registerToAIManager = s.Serialize<bool>(registerToAIManager, name: "registerToAIManager");
				faction = s.Serialize<uint>(faction, name: "faction");
				health = s.Serialize<int>(health, name: "health");
				damageLevels = s.SerializeObject<CArrayP<uint>>(damageLevels, name: "damageLevels");
				scaleRandomFactor = s.Serialize<float>(scaleRandomFactor, name: "scaleRandomFactor");
			}
		}
		public override uint? ClassCRC => 0xE8B7E500;
	}
}

