namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PushButtonComponent_Template : ActorComponent_Template {
		public float onOffDuration = 1f;
		public float delay;
		public bool activateChildren;
		public bool isProgressive;
		public float progressiveSpeed = 3f;
		public CArrayP<uint> progressiveHitLevels = new CArrayP<uint> { 5, 25, 50, 100 };
		public bool stayOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onOffDuration = s.Serialize<float>(onOffDuration, name: "onOffDuration");
			delay = s.Serialize<float>(delay, name: "delay");
			activateChildren = s.Serialize<bool>(activateChildren, name: "activateChildren");
			isProgressive = s.Serialize<bool>(isProgressive, name: "isProgressive");
			progressiveSpeed = s.Serialize<float>(progressiveSpeed, name: "progressiveSpeed");
			progressiveHitLevels = s.SerializeObject<CArrayP<uint>>(progressiveHitLevels, name: "progressiveHitLevels");
			stayOn = s.Serialize<bool>(stayOn, name: "stayOn");
		}
		public override uint? ClassCRC => 0xC81F9119;
	}
}

