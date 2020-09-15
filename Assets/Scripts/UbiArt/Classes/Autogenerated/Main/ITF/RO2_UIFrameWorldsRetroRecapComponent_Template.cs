using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UIFrameWorldsRetroRecapComponent_Template : ActorComponent_Template {
		[Serialize("locId"           )] public LocalisationId locId;
		[Serialize("FXFirework"      )] public StringID FXFirework;
		[Serialize("FXFireStream"    )] public StringID FXFireStream;
		[Serialize("offsetFirework"  )] public Vec3d offsetFirework;
		[Serialize("offsetFireStream")] public Vec3d offsetFireStream;
		[Serialize("worldsList"      )] public CList<StringID> worldsList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(locId));
				SerializeField(s, nameof(worldsList));
				SerializeField(s, nameof(FXFirework));
				SerializeField(s, nameof(FXFireStream));
				SerializeField(s, nameof(offsetFirework));
				SerializeField(s, nameof(offsetFireStream));
			} else {
				SerializeField(s, nameof(locId));
				SerializeField(s, nameof(FXFirework));
				SerializeField(s, nameof(FXFireStream));
				SerializeField(s, nameof(offsetFirework));
				SerializeField(s, nameof(offsetFireStream));
			}
		}
		public override uint? ClassCRC => 0x98324F3A;
	}
}

