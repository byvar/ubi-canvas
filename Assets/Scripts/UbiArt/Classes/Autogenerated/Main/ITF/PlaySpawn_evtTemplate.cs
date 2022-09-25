using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlaySpawn_evtTemplate : SequenceEventWithActor_Template {
		public bool Visible;
		public bool Stay;
		public Path FileName;
		public Vec2d SpawnOffset;
		public bool Flipped;
		public Path IluFile;
		public string FileName2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				Visible = s.Serialize<bool>(Visible, name: "Visible");
				Stay = s.Serialize<bool>(Stay, name: "Stay");
				FileName2 = s.Serialize<string>(FileName2, name: "FileName");
				SpawnOffset = s.SerializeObject<Vec2d>(SpawnOffset, name: "SpawnOffset");
				Flipped = s.Serialize<bool>(Flipped, name: "Flipped");
			} else {
				Visible = s.Serialize<bool>(Visible, name: "Visible");
				Stay = s.Serialize<bool>(Stay, name: "Stay");
				FileName = s.SerializeObject<Path>(FileName, name: "FileName");
				SpawnOffset = s.SerializeObject<Vec2d>(SpawnOffset, name: "SpawnOffset");
				Flipped = s.Serialize<bool>(Flipped, name: "Flipped");
				IluFile = s.SerializeObject<Path>(IluFile, name: "IluFile");
			}
		}
		public override uint? ClassCRC => 0x7F4A6F90;
	}
}

