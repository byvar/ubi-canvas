namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_24_sub_9589F0 : BoxInterpolatorComponent {
		public SoundGUID OnEnter;
		public SoundGUID OnExit;
		public float DepthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			OnEnter = s.SerializeObject<SoundGUID>(OnEnter, name: "OnEnter");
			OnExit = s.SerializeObject<SoundGUID>(OnExit, name: "OnExit");
			DepthOffset = s.Serialize<float>(DepthOffset, name: "DepthOffset");
		}
		public override uint? ClassCRC => 0x70479393;
	}
}

