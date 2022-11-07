namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class DialogBaseComponent_Template : ActorComponent_Template {
		public bool useOasis;
		public bool replaceSpeakersByActivator;
		public bool activeOnTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useOasis = s.Serialize<bool>(useOasis, name: "useOasis");
			replaceSpeakersByActivator = s.Serialize<bool>(replaceSpeakersByActivator, name: "replaceSpeakersByActivator");
			activeOnTrigger = s.Serialize<bool>(activeOnTrigger, name: "activeOnTrigger");
		}
		public override uint? ClassCRC => 0x660B6720;
	}
}

