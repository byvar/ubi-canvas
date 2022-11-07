namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ParachuteComponent_Template : ActorComponent_Template {
		public StringID animOpening;
		public StringID animFalling;
		public StringID animDrop;
		public StringID animCarryingStart;
		public StringID animCarryingStop;
		public StringID animEmpty;
		public StringID explodeFxName;
		public float collisionRadius;
		public Generic<Event> eventCarryingStart;
		public Generic<Event> eventCarryingStop;
		public Generic<Event> eventParachuteBroken;
		public uint reward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animOpening = s.SerializeObject<StringID>(animOpening, name: "animOpening");
			animFalling = s.SerializeObject<StringID>(animFalling, name: "animFalling");
			animDrop = s.SerializeObject<StringID>(animDrop, name: "animDrop");
			animCarryingStart = s.SerializeObject<StringID>(animCarryingStart, name: "animCarryingStart");
			animCarryingStop = s.SerializeObject<StringID>(animCarryingStop, name: "animCarryingStop");
			animEmpty = s.SerializeObject<StringID>(animEmpty, name: "animEmpty");
			explodeFxName = s.SerializeObject<StringID>(explodeFxName, name: "explodeFxName");
			collisionRadius = s.Serialize<float>(collisionRadius, name: "collisionRadius");
			eventCarryingStart = s.SerializeObject<Generic<Event>>(eventCarryingStart, name: "eventCarryingStart");
			eventCarryingStop = s.SerializeObject<Generic<Event>>(eventCarryingStop, name: "eventCarryingStop");
			eventParachuteBroken = s.SerializeObject<Generic<Event>>(eventParachuteBroken, name: "eventParachuteBroken");
			reward = s.Serialize<uint>(reward, name: "reward");
		}
		public override uint? ClassCRC => 0x8558B074;
	}
}

