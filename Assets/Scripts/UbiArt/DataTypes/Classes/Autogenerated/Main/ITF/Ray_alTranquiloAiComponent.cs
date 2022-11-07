namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_alTranquiloAiComponent : AIComponent {
		public float bubbleLifetime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				bubbleLifetime = s.Serialize<float>(bubbleLifetime, name: "bubbleLifetime");
			}
		}
		public override uint? ClassCRC => 0xCCB31478;
	}
}

