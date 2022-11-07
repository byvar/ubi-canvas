namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventFlare_EffectLightStatus : Event {
		public bool bool__0;
		public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
		}
		public override uint? ClassCRC => 0xD3DDA28D;
	}
}

