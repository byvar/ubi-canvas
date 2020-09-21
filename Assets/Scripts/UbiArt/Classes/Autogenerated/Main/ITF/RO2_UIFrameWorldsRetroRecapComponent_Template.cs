using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UIFrameWorldsRetroRecapComponent_Template : ActorComponent_Template {
		public LocalisationId locId;
		public StringID FXFirework;
		public StringID FXFireStream;
		public Vec3d offsetFirework;
		public Vec3d offsetFireStream;
		public CListO<StringID> worldsList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
				worldsList = s.SerializeObject<CListO<StringID>>(worldsList, name: "worldsList");
				FXFirework = s.SerializeObject<StringID>(FXFirework, name: "FXFirework");
				FXFireStream = s.SerializeObject<StringID>(FXFireStream, name: "FXFireStream");
				offsetFirework = s.SerializeObject<Vec3d>(offsetFirework, name: "offsetFirework");
				offsetFireStream = s.SerializeObject<Vec3d>(offsetFireStream, name: "offsetFireStream");
			} else {
				locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
				FXFirework = s.SerializeObject<StringID>(FXFirework, name: "FXFirework");
				FXFireStream = s.SerializeObject<StringID>(FXFireStream, name: "FXFireStream");
				offsetFirework = s.SerializeObject<Vec3d>(offsetFirework, name: "offsetFirework");
				offsetFireStream = s.SerializeObject<Vec3d>(offsetFireStream, name: "offsetFireStream");
			}
		}
		public override uint? ClassCRC => 0x98324F3A;
	}
}

