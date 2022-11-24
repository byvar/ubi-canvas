namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class TweenBallistic : TweenTranslation {
		public Vec3d movement = new Vec3d(3.402823e+38f, 3.402823e+38f, 3.402823e+38f);
		public Vec3d startTangent = new Vec3d(3.402823e+38f, 3.402823e+38f, 3.402823e+38f);
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			movement = s.SerializeObject<Vec3d>(movement, name: "movement");
			startTangent = s.SerializeObject<Vec3d>(startTangent, name: "startTangent");
		}
		public override uint? ClassCRC => 0x61D21A33;
	}
}

