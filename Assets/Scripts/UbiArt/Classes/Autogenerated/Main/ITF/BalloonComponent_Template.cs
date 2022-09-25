using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class BalloonComponent_Template : ActorComponent_Template {
		public Vec2d aabbMin;
		public bool is3D;
		public SoundGUID appearSoundGuid;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				aabbMin = s.SerializeObject<Vec2d>(aabbMin, name: "aabbMin");
				is3D = s.Serialize<bool>(is3D, name: "is3D");
				appearSoundGuid = s.SerializeObject<SoundGUID>(appearSoundGuid, name: "appearSoundGuid");
			} else {
				aabbMin = s.SerializeObject<Vec2d>(aabbMin, name: "aabbMin");
				is3D = s.Serialize<bool>(is3D, name: "is3D");
			}
		}
		public override uint? ClassCRC => 0xC29A3B3F;
	}
}

