namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class TweenBallistic : TweenTranslation {
		public Vec3d movement = new Vec3d(float.MaxValue, float.MaxValue, float.MaxValue);
		public Vec3d startTangent = new Vec3d(float.MaxValue, float.MaxValue, float.MaxValue);
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			movement = s.SerializeObject<Vec3d>(movement, name: "movement");
			startTangent = s.SerializeObject<Vec3d>(startTangent, name: "startTangent");
		}
		public override uint? ClassCRC => 0x61D21A33;
	}
}

