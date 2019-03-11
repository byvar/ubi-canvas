using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_DanceEyeComponent_Template : CSerializable {
		[Serialize("lockAnim"               )] public StringID lockAnim;
		[Serialize("occupiedAnim"           )] public StringID occupiedAnim;
		[Serialize("unlockAnim"             )] public StringID unlockAnim;
		[Serialize("lock_to_occupied_Anim"  )] public StringID lock_to_occupied_Anim;
		[Serialize("occupied_to_unlock_Anim")] public StringID occupied_to_unlock_Anim;
		[Serialize("unlock_to_occupied_Anim")] public StringID unlock_to_occupied_Anim;
		[Serialize("occupied_to_lock_Anim"  )] public StringID occupied_to_lock_Anim;
		[Serialize("unlock_to_off_Anim"     )] public StringID unlock_to_off_Anim;
		[Serialize("speedMoveParticles"     )] public float speedMoveParticles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lockAnim));
			SerializeField(s, nameof(occupiedAnim));
			SerializeField(s, nameof(unlockAnim));
			SerializeField(s, nameof(lock_to_occupied_Anim));
			SerializeField(s, nameof(occupied_to_unlock_Anim));
			SerializeField(s, nameof(unlock_to_occupied_Anim));
			SerializeField(s, nameof(occupied_to_lock_Anim));
			SerializeField(s, nameof(unlock_to_off_Anim));
			SerializeField(s, nameof(speedMoveParticles));
		}
		public override uint? ClassCRC => 0x562FAD79;
	}
}

