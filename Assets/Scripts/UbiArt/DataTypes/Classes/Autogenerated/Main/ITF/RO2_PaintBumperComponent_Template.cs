namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PaintBumperComponent_Template : ActorComponent_Template {
		public uint LumRewardNb = 5;
		public StringID AnimPaint;
		public StringID AnimStand;
		public bool useAdditive;
		public StringID additiveInput;
		public float additiveDuration;
		public bool listenToStick;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LumRewardNb = s.Serialize<uint>(LumRewardNb, name: "LumRewardNb");
			AnimPaint = s.SerializeObject<StringID>(AnimPaint, name: "AnimPaint");
			AnimStand = s.SerializeObject<StringID>(AnimStand, name: "AnimStand");
			useAdditive = s.Serialize<bool>(useAdditive, name: "useAdditive");
			additiveInput = s.SerializeObject<StringID>(additiveInput, name: "additiveInput");
			additiveDuration = s.Serialize<float>(additiveDuration, name: "additiveDuration");
			listenToStick = s.Serialize<bool>(listenToStick, name: "listenToStick");
		}
		public override uint? ClassCRC => 0x715C8C35;
	}
}

