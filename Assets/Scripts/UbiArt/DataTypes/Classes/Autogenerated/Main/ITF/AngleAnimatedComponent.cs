namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class AngleAnimatedComponent : ActorComponent {
		public bool Addanim;
		public Angle angleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
			} else {
				Addanim = s.Serialize<bool>(Addanim, name: "Addanim");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
			}
		}
		public override uint? ClassCRC => 0xB026081F;
	}
}

