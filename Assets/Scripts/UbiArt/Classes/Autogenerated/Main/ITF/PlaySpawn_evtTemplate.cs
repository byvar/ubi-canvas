using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RFR | GameFlags.RO)]
	public partial class PlaySpawn_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("Visible"    )] public bool Visible;
		[Serialize("Stay"       )] public bool Stay;
		[Serialize("FileName"   )] public Path FileName;
		[Serialize("SpawnOffset")] public Vector2 SpawnOffset;
		[Serialize("Flipped"    )] public bool Flipped;
		[Serialize("IluFile"    )] public Path IluFile;
		[Serialize("FileName"   )] public string FileName2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(Visible));
				SerializeField(s, nameof(Stay));
				SerializeField(s, nameof(FileName2));
				SerializeField(s, nameof(SpawnOffset));
				SerializeField(s, nameof(Flipped));
			} else {
				SerializeField(s, nameof(Visible));
				SerializeField(s, nameof(Stay));
				SerializeField(s, nameof(FileName));
				SerializeField(s, nameof(SpawnOffset));
				SerializeField(s, nameof(Flipped));
				SerializeField(s, nameof(IluFile));
			}
		}
		public override uint? ClassCRC => 0x7F4A6F90;
	}
}

