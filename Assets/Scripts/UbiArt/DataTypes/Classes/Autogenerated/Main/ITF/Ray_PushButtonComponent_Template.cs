namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PushButtonComponent_Template : ActorComponent_Template {
		public float onOffDuration;
		public float delay;
		public int activateChildren;
		public int triggerOnStick;
		public int triggerOnHit;
		public int isProgressive;
		public float progressiveSpeed;
		public CArrayP<uint> progressiveHitLevels;
		public int stayOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onOffDuration = s.Serialize<float>(onOffDuration, name: "onOffDuration");
			delay = s.Serialize<float>(delay, name: "delay");
			activateChildren = s.Serialize<int>(activateChildren, name: "activateChildren");
			triggerOnStick = s.Serialize<int>(triggerOnStick, name: "triggerOnStick");
			triggerOnHit = s.Serialize<int>(triggerOnHit, name: "triggerOnHit");
			isProgressive = s.Serialize<int>(isProgressive, name: "isProgressive");
			progressiveSpeed = s.Serialize<float>(progressiveSpeed, name: "progressiveSpeed");
			progressiveHitLevels = s.SerializeObject<CArrayP<uint>>(progressiveHitLevels, name: "progressiveHitLevels");
			stayOn = s.Serialize<int>(stayOn, name: "stayOn");
		}
		public override uint? ClassCRC => 0x9308A6E7;
	}
}

