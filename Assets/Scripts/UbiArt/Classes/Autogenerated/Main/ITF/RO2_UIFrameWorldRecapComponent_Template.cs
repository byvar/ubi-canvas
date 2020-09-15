using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UIFrameWorldRecapComponent_Template : ActorComponent_Template {
		[Serialize("locId"                )] public LocalisationId locId;
		[Serialize("FXFirework"           )] public StringID FXFirework;
		[Serialize("FXFireStreamRight"    )] public StringID FXFireStreamRight;
		[Serialize("FXFireStreamLeft"     )] public StringID FXFireStreamLeft;
		[Serialize("offsetFirework"       )] public Vec3d offsetFirework;
		[Serialize("offsetFireStreamRight")] public Vec3d offsetFireStreamRight;
		[Serialize("offsetFireStreamLeft" )] public Vec3d offsetFireStreamLeft;
		[Serialize("standEmptyAnim"       )] public StringID standEmptyAnim;
		[Serialize("standWithCupAnim"     )] public StringID standWithCupAnim;
		[Serialize("waitDuration"         )] public float waitDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(locId));
			SerializeField(s, nameof(FXFirework));
			SerializeField(s, nameof(FXFireStreamRight));
			SerializeField(s, nameof(FXFireStreamLeft));
			SerializeField(s, nameof(offsetFirework));
			SerializeField(s, nameof(offsetFireStreamRight));
			SerializeField(s, nameof(offsetFireStreamLeft));
			SerializeField(s, nameof(standEmptyAnim));
			SerializeField(s, nameof(standWithCupAnim));
			SerializeField(s, nameof(waitDuration));
		}
		public override uint? ClassCRC => 0x729EFDF7;
	}
}

