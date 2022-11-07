namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class EventLockPlayers : Event {
		public bool force;
		public bool stopPlayers;
		public bool stopInputs;
		public bool forceRevive;
		public int _lock;
		public int applyToPlayers;
		public int applyToInputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				_lock = s.Serialize<int>(_lock, name: "lock");
				applyToPlayers = s.Serialize<int>(applyToPlayers, name: "applyToPlayers");
				applyToInputs = s.Serialize<int>(applyToInputs, name: "applyToInputs");
				forceRevive = s.Serialize<bool>(forceRevive, name: "forceRevive");
			} else {
				force = s.Serialize<bool>(force, name: "force");
				stopPlayers = s.Serialize<bool>(stopPlayers, name: "stopPlayers");
				stopInputs = s.Serialize<bool>(stopInputs, name: "stopInputs");
				forceRevive = s.Serialize<bool>(forceRevive, name: "forceRevive");
			}
		}
		public override uint? ClassCRC => 0x156EA254;
	}
}

