namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIComponent_Template : ActorComponent_Template {
		public bool registerToAIManager = true;
		public uint faction;
		public int health = 100;
		public CArrayP<uint> damageLevels = new CArrayP<uint>(new uint[] { 5, 25, 50, 100 });
		public float scaleRandomFactor;
		public int listenToActivateEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RJR) {
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

