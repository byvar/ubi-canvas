using UnityEngine;

namespace UbiArt.ITF {
	public partial class CheckpointComponent : ActorComponent {
		[Serialize("INDEX"              )] public uint INDEX;
		[Serialize("joinAlive"          )] public bool joinAlive;
		[Serialize("persistent"         )] public bool persistent;
		[Serialize("persistentSaveOnce" )] public bool persistentSaveOnce;
		[Serialize("active"             )] public bool active;
		[Serialize("persistentDataSaved")] public bool persistentDataSaved;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(INDEX));
					SerializeField(s, nameof(joinAlive));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(active));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(INDEX));
					SerializeField(s, nameof(joinAlive));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(active));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(INDEX));
					SerializeField(s, nameof(joinAlive));
				}
				SerializeField(s, nameof(persistent));
				SerializeField(s, nameof(persistentSaveOnce));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(active));
					SerializeField(s, nameof(persistentDataSaved));
				}
			}
		}
		public override uint? ClassCRC => 0x5534CAE2;
	}
}

