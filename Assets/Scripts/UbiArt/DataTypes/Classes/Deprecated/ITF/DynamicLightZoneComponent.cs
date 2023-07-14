namespace UbiArt.ITF {
	[Games(GameFlags.RL, platforms: PlatformFlags.Vita)] // Only on Vita!
	public partial class DynamicLightZoneComponent : ActorComponent {
		public bool Vita_Bool { get; set; }
		public Vec2d Vita_Vec_00 { get; set; } // Some of these are colors probably
		public Vec2d Vita_Vec_01 { get; set; }
		public Vec2d Vita_Vec_02 { get; set; }
		public Vec2d Vita_Vec_03 { get; set; }
		public Vec2d Vita_Vec_04 { get; set; }
		public Vec2d Vita_Vec_05 { get; set; }
		public Vec2d Vita_Vec_06 { get; set; }
		public Vec2d Vita_Vec_07 { get; set; }
		public Vec2d Vita_Vec_08 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vita_Bool = s.Serialize<bool>(Vita_Bool, name: nameof(Vita_Bool), options: CSerializerObject.Options.ForceAsByte);
			Vita_Vec_00 = s.SerializeObject<Vec2d>(Vita_Vec_00, name: nameof(Vita_Vec_00));
			Vita_Vec_01 = s.SerializeObject<Vec2d>(Vita_Vec_01, name: nameof(Vita_Vec_01));
			Vita_Vec_02 = s.SerializeObject<Vec2d>(Vita_Vec_02, name: nameof(Vita_Vec_02));
			Vita_Vec_03 = s.SerializeObject<Vec2d>(Vita_Vec_03, name: nameof(Vita_Vec_03));
			Vita_Vec_04 = s.SerializeObject<Vec2d>(Vita_Vec_04, name: nameof(Vita_Vec_04));
			Vita_Vec_05 = s.SerializeObject<Vec2d>(Vita_Vec_05, name: nameof(Vita_Vec_05));
			Vita_Vec_06 = s.SerializeObject<Vec2d>(Vita_Vec_06, name: nameof(Vita_Vec_06));
			Vita_Vec_07 = s.SerializeObject<Vec2d>(Vita_Vec_07, name: nameof(Vita_Vec_07));
			Vita_Vec_08 = s.SerializeObject<Vec2d>(Vita_Vec_08, name: nameof(Vita_Vec_08));
		}
		public override uint? ClassCRC => 0x8631DE9E;
	}
}
