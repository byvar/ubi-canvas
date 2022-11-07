namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DanceEyeComponent_Template : CSerializable {
		public StringID lockAnim;
		public StringID occupiedAnim;
		public StringID unlockAnim;
		public StringID lock_to_occupied_Anim;
		public StringID occupied_to_unlock_Anim;
		public StringID unlock_to_occupied_Anim;
		public StringID occupied_to_lock_Anim;
		public StringID unlock_to_off_Anim;
		public float speedMoveParticles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lockAnim = s.SerializeObject<StringID>(lockAnim, name: "lockAnim");
			occupiedAnim = s.SerializeObject<StringID>(occupiedAnim, name: "occupiedAnim");
			unlockAnim = s.SerializeObject<StringID>(unlockAnim, name: "unlockAnim");
			lock_to_occupied_Anim = s.SerializeObject<StringID>(lock_to_occupied_Anim, name: "lock_to_occupied_Anim");
			occupied_to_unlock_Anim = s.SerializeObject<StringID>(occupied_to_unlock_Anim, name: "occupied_to_unlock_Anim");
			unlock_to_occupied_Anim = s.SerializeObject<StringID>(unlock_to_occupied_Anim, name: "unlock_to_occupied_Anim");
			occupied_to_lock_Anim = s.SerializeObject<StringID>(occupied_to_lock_Anim, name: "occupied_to_lock_Anim");
			unlock_to_off_Anim = s.SerializeObject<StringID>(unlock_to_off_Anim, name: "unlock_to_off_Anim");
			speedMoveParticles = s.Serialize<float>(speedMoveParticles, name: "speedMoveParticles");
		}
		public override uint? ClassCRC => 0x562FAD79;
	}
}

