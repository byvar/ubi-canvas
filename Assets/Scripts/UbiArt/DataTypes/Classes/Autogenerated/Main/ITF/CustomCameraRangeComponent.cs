namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class CustomCameraRangeComponent : ActorComponent {
		public float updateFrustumEnlargeRange = 18f;
		public float loadingFrustumEnlargeRange = 40f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			updateFrustumEnlargeRange = s.Serialize<float>(updateFrustumEnlargeRange, name: "updateFrustumEnlargeRange");
			loadingFrustumEnlargeRange = s.Serialize<float>(loadingFrustumEnlargeRange, name: "loadingFrustumEnlargeRange");
		}
		public override uint? ClassCRC => 0x9B9C5D7D;
	}
}

